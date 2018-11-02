using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WFF_Generic_HID_Demo_3
{
    
    public partial class Players : Form
    {
        public int passedFields = 0;
        public int jerseyNumber = 0;
        private MySqlConnection myConnection;
        private int team_id;
        private List<Player> player = new List<Player>();
        private List<Label> playerName = new List<Label>();
        private List<Label> playerPosition = new List<Label>();
        private List<Label> playerNumber = new List<Label>();
        private List<Button> playerButton = new List<Button>();
        private Panel scrollGroup = new Panel();
        private int YOffset = 0;
        private int x = 1;
        private usbDemoDevice theUsbDemoDevice;
        private int connectedPlayerIndex = 0;
        public Players(int index, MySqlConnection conn)
        {
            myConnection = conn;
            team_id = index;
            InitializeComponent();
            scrollGroup.AutoScroll = true;
            scrollGroup.Location = new System.Drawing.Point(0, 30);
            scrollGroup.Size = new System.Drawing.Size(275, 350);
            try
            {
                if (myConnection.State != ConnectionState.Open)
                    myConnection.Open();

                string sqlcmd="select * from teams where team_id="+index;
                MySqlCommand cmd = new MySqlCommand(sqlcmd, myConnection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblTeamName.Text = dr["name"].ToString();
                    /*
                    TextBox team = new TextBox();
                    Button teamButton = new Button();
                    //Country countr = new Country();
                    //city.Name = index.ToString();
                    //countr.Code = dr["Code"].ToString();
                    //countr.Name = city.Text = dr["Name"].ToString();
                    //countr.Population = Convert.ToInt32(dr["Population"]);
                    teamButton.Text = "players";
                    teamButton.Location = new System.Drawing.Point(120, YOffset);
                    teamButton.Name = index.ToString();
                    teamButton.AutoSize = true;
                    team.Text = dr["name"].ToString();
                    //team.Name = index.ToString();
                    team.Location = new System.Drawing.Point(0, YOffset);
                    teamButton.Click += arbitraryLabelClicked;
                    teamNames.Add(team);
                    teamNameButton.Add(teamButton);
                    //countryList.Add(countr);
                    YOffset += 30;


                    index++;*/
                }
                myConnection.Close();

                //label1.Text = "connection opened";
                myConnection.Open();
                sqlcmd = "CREATE TABLE IF NOT EXISTS `players` (player_id int(50) NOT NULL auto_increment primary key,team_id int(50),first_name varchar(25),last_name varchar(25),jersey_number int(2), position varchar(3), foreign key(team_id) references teams(team_id) on delete cascade) ENGINE = MEMORY; ";
                cmd = new MySqlCommand(sqlcmd, myConnection);
                dr = cmd.ExecuteReader();
                myConnection.Close();

                myConnection.Open();
                sqlcmd = "select * from players where team_id="+team_id;
                cmd = new MySqlCommand(sqlcmd, myConnection);
                dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    Player newPlayer = new Player();
                    Label newPlayerName = new Label();
                    Label newPlayerPosition = new Label();
                    Label newPlayerNumber = new Label();
                    Button newPlayerButton = new Button();
                    newPlayer.firstName = dr["first_name"].ToString();
                    newPlayer.lastName = dr["last_name"].ToString();
                    newPlayer.jerseyNumber = Convert.ToInt32(dr["jersey_number"]);
                    newPlayer.position = dr["position"].ToString();
                    newPlayerButton.Text = "Profile";
                    newPlayer.index = Convert.ToInt32(dr["player_id"]);
                    newPlayerName.Text = newPlayer.firstName + " " + newPlayer.lastName;
                    newPlayerName.Location = new System.Drawing.Point(0, YOffset);
                    newPlayerNumber.Text = newPlayer.jerseyNumber.ToString();
                    newPlayerNumber.Location = new System.Drawing.Point(100, YOffset);
                    newPlayerPosition.Text = newPlayer.position;
                    newPlayerPosition.Location = new System.Drawing.Point(120, YOffset);
                    newPlayerButton.Location = new System.Drawing.Point(180, YOffset);
                    newPlayerButton.Name = index.ToString();
                    newPlayerButton.AutoSize = true;
                    newPlayerButton.Click += arbitraryLabelClicked;
                    player.Add(newPlayer);
                    playerName.Add(newPlayerName);
                    playerPosition.Add(newPlayerPosition);
                    playerNumber.Add(newPlayerNumber);
                    playerButton.Add(newPlayerButton);
                    //countryList.Add(countr);
                    YOffset += 30;


                    x++;
                }
                myConnection.Close();
                int i = 0;
                foreach (Player p in player)
                {
                    scrollGroup.Controls.Add(playerButton[i]);
                    scrollGroup.Controls.Add(playerPosition[i]);
                    scrollGroup.Controls.Add(playerNumber[i]);
                    scrollGroup.Controls.Add(playerName[i]);                                               
                    i++;
                }
                this.Controls.Add(scrollGroup);
                



            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                //return false;
            }

            theUsbDemoDevice = new usbDemoDevice(0x04D8, 0x003F);

            // Add a listener for usb events
            theUsbDemoDevice.usbEvent += new usbDemoDevice.usbEventsHandler(usbEvent_receiver);

            // Perform an initial search for the target device
            theUsbDemoDevice.findTargetDevice();
        }


        private void usbEvent_receiver(object o, EventArgs e)
        {
            // Check the status of the USB device and update the form accordingly
            if (theUsbDemoDevice.isDeviceAttached)
            {
                // Device is currently attached

                // Update the status label
                this.lblConnectionStatus.Text = "connected";
                this.lblPacketLength.Text=theUsbDemoDevice.getDeviceInfo(2).ToString();
                int jerseyNumber = theUsbDemoDevice.getDeviceInfo(3);
                if (jerseyNumber != 255)
                {

                    this.lblAssociatedPlayer.Text = jerseyNumber.ToString();
                    try
                    {
                        if (myConnection.State != ConnectionState.Open)
                            myConnection.Open();

                        string sqlcmd = "select * from players where jersey_number=" + jerseyNumber+" and team_id="+team_id;
                        MySqlCommand cmd = new MySqlCommand(sqlcmd, myConnection);
                        MySqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Read();
                            lblAssociatedPlayer.Text = dr["first_name"].ToString() + " " + dr["last_name"].ToString();
                            connectedPlayerIndex = Convert.ToInt32(dr["player_id"]);
                        }

                        myConnection.Close();

                      




                    }
                    catch (MySqlException ex)
                    {
                        //When handling errors, you can your application's response based 
                        //on the error number.
                        //The two most common error numbers when connecting are as follows:
                        //0: Cannot connect to server.
                        //1045: Invalid user name and/or password.
                        switch (ex.Number)
                        {
                            case 0:
                                MessageBox.Show("Cannot connect to server.  Contact administrator");
                                break;

                            case 1045:
                                MessageBox.Show("Invalid username/password, please try again");
                                break;
                        }
                        //return false;
                    }
                }
                // Update the form
                //this.toggleLedStateButton.Enabled = true;
            }
            else
            {
                // Device is currently unattached

                // Update the status label
                this.lblConnectionStatus.Text = "not connected";

                // Update the form
                //is.toggleLedStateButton.Enabled = false;
            }
        }

        private void arbitraryLabelClicked(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            //MessageBox.Show(btn.Name);
            // MessageBox.Show(countryList[Convert.ToInt32(txt.Name)].Code);
            //Country selected = countryList.FindLast(x => x.Name.Contains(txt.Text));
            Players p = new Players(Convert.ToInt32(btn.Name), myConnection);
            p.Show();
            //this.Visible = false;
            //if (c.IsDisposed)
            //{
            //    this.Visible = true;
            //}
        }

        private void lblTeamName_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboxPosition.Text != "")
            {
                chk_Position.Checked = true;
            }
            else
            {
                chk_Position.Checked = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtbx_firstName.Text != "")
            {
                chk_firstName.Checked = true;
            }
            else
            {
                chk_firstName.Checked = false;
            }
        }

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
            }
            CheckBox chk = sender as CheckBox;
            if (chk.Checked)
            {
                passedFields++;
            }
            else
            {
                passedFields--;
            }
            lblStatus.Text = passedFields.ToString() + "/4 fields complete";
        }

        private void txtbox_lastName_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_lastName.Text != "")
            {
                chk_lastName.Checked = true;
            }
            else
            {
                chk_lastName.Checked = false;
            }
        }

        private void txtbx_Jersey_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(txtbx_Jersey.Text,out jerseyNumber))
            {
                if (jerseyNumber < 100&&jerseyNumber>0)
                {
                    chk_Jersey.Checked = true;
                }
                else
                {
                    chk_Jersey.Checked = false;
                }
                
            }
            else
            {
                chk_Jersey.Checked = false;
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (passedFields == 4)
            {
                try
                {
                    if (myConnection.State != ConnectionState.Open)
                        myConnection.Open();
                    string sqlcmd = "INSERT INTO players(team_id,first_name,last_name,jersey_number,position) VALUES("+team_id+",'"+txtbx_firstName.Text+"','"+txtbox_lastName.Text+"',"+jerseyNumber+",'"+cmboxPosition.Text+"')";
                    MySqlCommand cmd = new MySqlCommand(sqlcmd, myConnection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    
                    txtbox_lastName.Text = "";
                    txtbx_firstName.Text = "";
                    txtbx_Jersey.Text = "";
                    cmboxPosition.Text = "";
                    lblStatus.Text = "data sent successfully";
                    timer1.Enabled = true;
                    myConnection.Close();
                    //while (dr.Read())
                    //{
                    //  lblTeamName.Text = dr["name"].ToString();
                    /*
                    TextBox team = new TextBox();
                    Button teamButton = new Button();
                    //Country countr = new Country();
                    //city.Name = index.ToString();
                    //countr.Code = dr["Code"].ToString();
                    //countr.Name = city.Text = dr["Name"].ToString();
                    //countr.Population = Convert.ToInt32(dr["Population"]);
                    teamButton.Text = "players";
                    teamButton.Location = new System.Drawing.Point(120, YOffset);
                    teamButton.Name = index.ToString();
                    teamButton.AutoSize = true;
                    team.Text = dr["name"].ToString();
                    //team.Name = index.ToString();
                    team.Location = new System.Drawing.Point(0, YOffset);
                    teamButton.Click += arbitraryLabelClicked;
                    teamNames.Add(team);
                    teamNameButton.Add(teamButton);
                    //countryList.Add(countr);
                    YOffset += 30;


                    index++;*/
                    //}
                    //myConnection.Close();

                    //label1.Text = "connection opened";
                    //myConnection.Open();
                    //sqlcmd = "select * from players where team_id=" + index;
                    //cmd = new MySqlCommand(sqlcmd, myConnection);
                    //dr = cmd.ExecuteReader();
                    /*
                    while (dr.Read())
                    {
                        TextBox team = new TextBox();
                        Button teamButton = new Button();
                        //Country countr = new Country();
                        //city.Name = index.ToString();
                        //countr.Code = dr["Code"].ToString();
                        //countr.Name = city.Text = dr["Name"].ToString();
                        //countr.Population = Convert.ToInt32(dr["Population"]);
                        teamButton.Text = "players";
                        teamButton.Location = new System.Drawing.Point(120, YOffset);
                        teamButton.Name = index.ToString();
                        teamButton.AutoSize = true;
                        team.Text = dr["name"].ToString();
                        //team.Name = index.ToString();
                        team.Location = new System.Drawing.Point(0, YOffset);
                        teamButton.Click += arbitraryLabelClicked;
                        teamNames.Add(team);
                        teamNameButton.Add(teamButton);
                        //countryList.Add(countr);
                        YOffset += 30;


                        index++;
                    }
                    int i = 0;
                    foreach (TextBox text in teamNames)
                    {
                        scrollGroup.Controls.Add(text);
                        scrollGroup.Controls.Add(teamNameButton[i]);
                        i++;
                    }
                    this.Controls.Add(scrollGroup);
                    myConnection.Close();*/



                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    //return false;
                }
            }
            else
            {
                string debugReport="";
                if (!chk_firstName.Checked)
                {
                    debugReport += "Please Provide a first Name";
                    debugReport += Environment.NewLine;
                }
                if (!chk_lastName.Checked)
                {
                    debugReport += "Please Provide a last Name";
                    debugReport += Environment.NewLine;
                }
                if (!chk_Jersey.Checked)
                {
                    debugReport += "Jersey value must be a number between 0 and 100";
                    debugReport += Environment.NewLine;
                }
                if (!chk_Position.Checked)
                {
                    debugReport += "please select a provided value for the position";
                    debugReport += Environment.NewLine;
                }
                MessageBox.Show(debugReport);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = "waiting";
            timer1.Enabled = false;
        }
    }
}

public class Player
{

    private int Index;
    public int index
    {
        get { return Index; }
        set { Index = value; }
    }

    private string FirstName;
    public string firstName
    {
        get { return FirstName; }
        set { FirstName = value; }
    }

    private string LastName;
    public string lastName
    {
        get { return LastName; }
        set { LastName = value; }
    }

    private int JerseyNumber;
    public int jerseyNumber
    {
        get { return JerseyNumber; }
        set { JerseyNumber = value; }
    }

    private string Position;
    public string position
    {
        get { return Position; }
        set { Position = value; }
    }
}
