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

    public partial class Collisions : Form
    {
        private usbDemoDevice theUsbDemoDevice;
        private Player player;
        public Collisions(Player p, MySqlConnection conn)
        {
            InitializeComponent();
            player = p;
            lblPlayerName.Text = p.firstName + " " + p.lastName;
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
                /*count = theUsbDemoDevice.getDeviceInfo(2);
                this.lblPacketLength.Text = count.ToString();
                int jerseyNumber = theUsbDemoDevice.getDeviceInfo(3);
                if (jerseyNumber != 255)
                {

                    this.lblAssociatedPlayer.Text = jerseyNumber.ToString();
                    try
                    {
                        if (myConnection.State != ConnectionState.Open)
                            myConnection.Open();

                        string sqlcmd = "select * from players where jersey_number=" + jerseyNumber + " and team_id=" + team_id;
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
                //this.toggleLedStateButton.Enabled = true;*/
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (theUsbDemoDevice.isDeviceAttached)
            {
                theUsbDemoDevice.setPlayerId(player.index);
            }
        }
    }
}
