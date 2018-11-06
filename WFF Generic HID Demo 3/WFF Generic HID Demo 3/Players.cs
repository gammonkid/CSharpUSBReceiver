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
        private int count = 0;
        private List<string> GameString = new List<string>();
        private List<int> gameIndex = new List<int>();
        private int newGameCounter=0;
        //private int jerseyNumber = 0;
        public Players(int index, MySqlConnection conn)
        {
            myConnection = conn;
            team_id = index;
            InitializeComponent();
            GameString.Add("Season");
            gameIndex.Add(0);
            scrollGroup.AutoScroll = true;
            scrollGroup.Location = new System.Drawing.Point(0, 30);
            scrollGroup.Size = new System.Drawing.Size(275, 350);
            this.Draw_Screen();
            this.drawComboBox();
           

            theUsbDemoDevice = new usbDemoDevice(0x04D8, 0x003F);

            // Add a listener for usb events
            theUsbDemoDevice.usbEvent += new usbDemoDevice.usbEventsHandler(usbEvent_receiver);

            // Perform an initial search for the target device
            theUsbDemoDevice.findTargetDevice();
            tmr_pollDevice.Enabled = true;
        }

        void Draw_Screen()
        {
            try
            {
                if (myConnection.State != ConnectionState.Open)
                    myConnection.Open();

                player.Clear();
                playerName.Clear();
                playerNumber.Clear();
                playerPosition.Clear();
                playerButton.Clear();
                scrollGroup.Controls.Clear();
                YOffset = 0;
                x = 1;
                //this.Controls.Remove(scrollGroup);

                string sqlcmd = "select * from teams where team_id=" + team_id;
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
                sqlcmd = "select * from players where team_id=" + team_id;
                if(comboBox1.Text!="All Players")
                {
                    sqlcmd += " and position='" + comboBox1.Text + "'";
                }
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
                    newPlayerButton.Name = x.ToString();
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
                myConnection.Open();
                sqlcmd = "select * from games where team_id=" + team_id;
                cmd = new MySqlCommand(sqlcmd, myConnection);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string newGame = dr["opponent"].ToString() + " " + dr["day"].ToString();
                    int newIndex = Convert.ToInt32(dr["game_id"]);
                    GameString.Add(newGame);
                    gameIndex.Add(newIndex);
                }
                cmBoxGameSelect.DataSource = GameString;
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

        private void drawComboBox()
        {
            try
            {
                if (myConnection.State != ConnectionState.Open)
                    myConnection.Open();
               
                
                string sqlcmd = "select * from games where team_id=" + team_id;
                MySqlCommand cmd = new MySqlCommand(sqlcmd, myConnection);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string newGame = dr["opponent"].ToString() + " " + dr["day"].ToString();
                    int newIndex = Convert.ToInt32(dr["game_id"]);
                    GameString.Add(newGame);
                    gameIndex.Add(newIndex);
                }
                cmBoxGameSelect.DataSource = GameString;
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


        private void usbEvent_receiver(object o, EventArgs e)
        {
            // Check the status of the USB device and update the form accordingly
            if (theUsbDemoDevice.isDeviceAttached)
            {
                // Device is currently attached

                // Update the status label
                this.lblConnectionStatus.Text = "connected";
                count = theUsbDemoDevice.getDeviceInfo(2);
                this.lblPacketLength.Text=count.ToString();
                int newjerseyNumber = theUsbDemoDevice.getDeviceInfo(3);
                if (newjerseyNumber != 255 && newjerseyNumber!=jerseyNumber)
                {
                    jerseyNumber = newjerseyNumber;

                    //this.lblAssociatedPlayer.Text = jerseyNumber.ToString();
                    try
                    {
                        if (myConnection.State != ConnectionState.Open)
                            myConnection.Open();

                        string sqlcmd = "select * from players where player_id=" + jerseyNumber+" and team_id="+team_id;
                        MySqlCommand cmd = new MySqlCommand(sqlcmd, myConnection);
                        MySqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Read();
                            lblAssociatedPlayer.Text = dr["first_name"].ToString() + " " + dr["last_name"].ToString();
                            connectedPlayerIndex = Convert.ToInt32(dr["player_id"]);
                        }
                        else
                        {
                            lblAssociatedPlayer.Text = "none";
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
            int playerIndex = Convert.ToInt32(btn.Name);

            //MessageBox.Show(player[playerIndex-1].firstName);
            // MessageBox.Show(countryList[Convert.ToInt32(txt.Name)].Code);
            //Country selected = countryList.FindLast(x => x.Name.Contains(txt.Text));
            Collisions c = new Collisions(player[playerIndex-1], myConnection);
            c.Show();
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
                    this.Draw_Screen();
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

        private void btn_sendData_Click(object sender, EventArgs e)
        {
            if (theUsbDemoDevice.isDeviceAttached)
            {

                count = theUsbDemoDevice.getDeviceInfo(2);
                while (count > 0)
                {
                    theUsbDemoDevice.readXData();
                    theUsbDemoDevice.readYData();
                    theUsbDemoDevice.readZData();
                    count = theUsbDemoDevice.getDeviceInfo(2);
                    lblPacketLength.Text = count.ToString();
                    //label6.Text = "";
                    //label7.Text = "";
                    //label8.Text = "";
                    string xStore = "";
                    string yStore = "";
                    string zStore = "";
                    foreach (int i in theUsbDemoDevice.xArray)
                    {
                        if (i >= 1000)
                        {
                            xStore += 999.ToString() + " ";
                        }
                        else
                            xStore += i.ToString() + " ";
                    }
                    foreach (int i in theUsbDemoDevice.yArray)
                    {
                        if (i >= 1000)
                        {
                            yStore += 999.ToString() + " ";
                        }
                        else
                            yStore += i.ToString() + " ";
                    }
                    foreach (int i in theUsbDemoDevice.zArray)
                    {
                        if (i >= 1000)
                        {
                            zStore += 999.ToString() + " ";
                        }
                        else
                            zStore += i.ToString() + " ";
                    }
                    //label6.Text = xStore;
                    //label7.Text = yStore;
                    //label8.Text = zStore;
                    try
                    {
                        if (myConnection.State != ConnectionState.Open)
                            myConnection.Open();
                        //label1.Text = "connection opened";
                        string sqlcmd = "INSERT INTO collisions(player_id,x,y,z) VALUES(" + connectedPlayerIndex + ",'" + xStore + "','" + yStore + "','" + zStore + "')";
                        MySqlCommand cmd = new MySqlCommand(sqlcmd, myConnection);
                        MySqlDataReader dr = cmd.ExecuteReader();
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
            }
        }

        private void tmr_pollDevice_Tick(object sender, EventArgs e)
        {
            this.usbEvent_receiver(sender,e);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //ComboBox cmbx = sender as ComboBox;
            // MessageBox.Show(gameIndex[cmbx.SelectedIndex].ToString());
            lblGameAss.Text = GameString[cmBoxGameSelect.SelectedIndex];
            //call function to check combobox indexs
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (newGameCounter == 1 && lblOutcome.Text != "undefined")
            {
                try
                {
                    if (myConnection.State != ConnectionState.Open)
                        myConnection.Open();

                    string sqlcmd = "CREATE TABLE IF NOT EXISTS `games` (game_id int(50) NOT NULL auto_increment primary key,team_id int(50),opponent varchar(25),this_score int(2),other_score int(2), day date, foreign key(team_id) references teams(team_id) on delete cascade) ENGINE = MEMORY; ";
                    MySqlCommand cmd = new MySqlCommand(sqlcmd, myConnection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    myConnection.Close();
                    
                    myConnection.Open();
                    int myScore = Convert.ToInt32(txtMyScore.Text);
                    int theirScore = Convert.ToInt32(txtTheirScore.Text);
                    string selectedDate = dateTimePicker1.Value.Year.ToString() + '-' + dateTimePicker1.Value.Month.ToString() + '-' + dateTimePicker1.Value.Day.ToString();
                    //lblDate.Text = selectedDate;
                    sqlcmd = "INSERT INTO games(team_id,opponent,this_score,other_score,day) VALUES(" + team_id + ",'" + txtOpponent.Text + "'," + myScore + "," + theirScore + ",'" + selectedDate + "')";
                    cmd = new MySqlCommand(sqlcmd, myConnection);
                    dr = cmd.ExecuteReader();
                    myConnection.Close();

                    myConnection.Open();
                    sqlcmd = "SELECT COUNT(*) FROM games";
                    cmd = new MySqlCommand(sqlcmd, myConnection);
                    int newIndex = Convert.ToInt32(cmd.ExecuteScalar());
                    GameString.Insert(1, txtOpponent.Text + " " + dateTimePicker1.Value.Date.ToString());
                    gameIndex.Insert(1, newIndex);
                    cmBoxGameSelect.DataSource = null;
                    cmBoxGameSelect.DataSource = GameString;
                    myConnection.Close();

                    /*while (dr.Read())
                    {
                        
                    }
                    myConnection.Close();
                    int i = 0;
                    foreach (Player p in player)
                    {
                        scrollGroup.Controls.Add(playerButton[i]);
                        scrollGroup.Controls.Add(playerPosition[i]);
                        scrollGroup.Controls.Add(playerNumber[i]);
                        scrollGroup.Controls.Add(playerName[i]);
                        playerNames.Add(p.firstName + " " + p.lastName);
                        i++;
                    }
                    this.Controls.Add(scrollGroup);
                    this.cmBoxGameSelect.DataSource = playerNames;
                    
    */

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
        }

        private void txtOpponent_TextChanged(object sender, EventArgs e)
        {
            if (txtOpponent.Text != "")
            {
                newGameCounter = 1;
            }
            else
            {
                newGameCounter = 0;
            }
        }

        private void txtMyScore_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(txtMyScore.Text,out int myVal))
            {
                if(int.TryParse(txtTheirScore.Text,out int theirVal))
                {
                    this.checkScore(myVal, theirVal);
                }
                else
                {
                    this.checkScore(-1, -1);
                }
            }
            else
            {
                this.checkScore(-1, -1);
            }
        }
        private void checkScore(int home,int opponent)
        {
            if (home < 0 || opponent < 0)
            {
                lblOutcome.Text = "undefined";
            }
            else if (home > opponent)
            {
                lblOutcome.Text = "Win";
            }
            else if (home < opponent)
            {
                lblOutcome.Text = "lose";
            }
            else
            {
                lblOutcome.Text = "Draw";
            }
        }

        private void txtTheirScore_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtMyScore.Text, out int myVal))
            {
                if (int.TryParse(txtTheirScore.Text, out int theirVal))
                {
                    this.checkScore(myVal, theirVal);
                }
                else
                {
                    this.checkScore(-1, -1);
                }
            }
            else
            {
                this.checkScore(-1, -1);
            }
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            grpBoxStats.Text = "Game Stats for " + comboBox1.Text;
            lblAvgHitText.Text = "Average Hit for " + comboBox1.Text;
            lblMaxHitText.Text = "Maximum Hit for" + comboBox1.Text;
            //calll function to change game stats
            //call function to change selected players
            this.Draw_Screen();

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
