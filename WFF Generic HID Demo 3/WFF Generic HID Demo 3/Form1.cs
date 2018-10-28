//-----------------------------------------------------------------------------
//
//  Form1.cs
//
//  USB Generic HID Demonstration 3_0_0_0
//
//  A reference test application for the usbGenericHidCommunications library
//  Copyright (C) 2011 Simon Inns
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
//  Web:    http://www.waitingforfriday.com
//  Email:  simon.inns@gmail.com
//
//-----------------------------------------------------------------------------

//
//  Current reference class library version:
//  usbGenericHidCommunications class library version 3.0.0.0
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WFF_Generic_HID_Demo_3
    {
    public partial class Form1 : Form
        {
        List<TextBox> teamNames = new List<TextBox>();
        private MySqlConnection myConnection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private int year = DateTime.Now.Year;
        private Panel scrollGroup = new Panel();
        private int YOffset = 0;
        private int index = 0;

        public Form1()
            {
            InitializeComponent();
            lblYear.Text += year.ToString();
            
            scrollGroup.AutoScroll = true;
            scrollGroup.Location = new System.Drawing.Point(0, 0);
            scrollGroup.Size = new System.Drawing.Size(100, 350);
            server = "localhost";
            database = "concussion";
            uid = "root";
            password = "root";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            myConnection = new MySqlConnection(connectionString);

            try
            {
                if (myConnection.State != ConnectionState.Open)
                    myConnection.Open();
                //label1.Text = "connection opened";
                string sqlcmd = "select * from teams";
                MySqlCommand cmd = new MySqlCommand(sqlcmd, myConnection);
                MySqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    TextBox team = new TextBox();

                    //Country countr = new Country();
                    //city.Name = index.ToString();
                    //countr.Code = dr["Code"].ToString();
                    //countr.Name = city.Text = dr["Name"].ToString();
                    //countr.Population = Convert.ToInt32(dr["Population"]);
                    team.Text = dr["name"].ToString();
                    team.Name = index.ToString();
                    team.Location = new System.Drawing.Point(0, YOffset); ;
                    teamNames.Add(team);
                    //countryList.Add(countr);
                    YOffset += 20;
                    team.Click += arbitraryLabelClicked;

                    index++;
                }
                foreach (TextBox text in teamNames)
                {
                    scrollGroup.Controls.Add(text);
                }
                this.Controls.Add(scrollGroup);
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

            // Create the USB reference device object (passing VID and PID)
            theUsbDemoDevice = new usbDemoDevice(0x04D8, 0x003F);

            // Add a listener for usb events
            theUsbDemoDevice.usbEvent += new usbDemoDevice.usbEventsHandler(usbEvent_receiver);

            // Perform an initial search for the target device
            theUsbDemoDevice.findTargetDevice();
            }

        private void arbitraryLabelClicked(object sender, EventArgs e)
        {

            TextBox txt = sender as TextBox;
            MessageBox.Show(txt.Text);
           // MessageBox.Show(countryList[Convert.ToInt32(txt.Name)].Code);
            //Country selected = countryList.FindLast(x => x.Name.Contains(txt.Text));
            //Cities c = new Cities(selected, myConnection);
            //c.Show();
            //this.Visible = false;
            //if (c.IsDisposed)
            //{
            //    this.Visible = true;
            //}
        }

        // Create an instance of the USB reference device
        private usbDemoDevice theUsbDemoDevice;

        // Listener for USB events
        private void usbEvent_receiver(object o, EventArgs e)
            {
            // Check the status of the USB device and update the form accordingly
            if (theUsbDemoDevice.isDeviceAttached)
                {
                // Device is currently attached

                // Update the status label
                this.toolStripStatusLabel1.Text = "USB Device is attached";

                // Update the form
                this.toggleLedStateButton.Enabled = true;
                }
            else
                {
                // Device is currently unattached

                // Update the status label
                this.toolStripStatusLabel1.Text = "USB Device is detached";

                // Update the form
                this.toggleLedStateButton.Enabled = false;
                }
            }


        // Toggle LED state button pressed
        private void toggleLedStateButton_Click(object sender, EventArgs e)
            {
            if (theUsbDemoDevice.isDeviceAttached)
                {
                theUsbDemoDevice.toggleLedState();

            }
            }

        // Timer 1 has ticked, poll the USB device for status
        private void timer1_Tick(object sender, EventArgs e)
            {
            timer1.Enabled = false;
            lblStatus.Text = "waiting";
            
            }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            if (int.TryParse(returnValue.Text, out int val))
            {
                val = (val > 512) ? 512 : val;
                val = (val < 0) ? 0 : val;
                f.init = val;
            }

            
            if (f.ShowDialog() == DialogResult.OK)
            {
                returnValue.Text = f.MyVal.ToString();
            };
        }

        // Collect debug timer has ticked
        private void debugCollectionTimer_Tick(object sender, EventArgs e)
            {
                

            }

        private void button2_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "attempting to send";
            try
            {
                if (myConnection.State != ConnectionState.Open)
                    myConnection.Open();
                //label1.Text = "connection opened";
                string sqlcmd = "INSERT INTO teams(name,year) VALUES('" + txtName.Text + "'," + year + ")";
                MySqlCommand cmd = new MySqlCommand(sqlcmd, myConnection);
                MySqlDataReader dr = cmd.ExecuteReader();
                myConnection.Close();
                
                timer1.Enabled = true;

                TextBox team = new TextBox();

                //Country countr = new Country();
                //city.Name = index.ToString();
                //countr.Code = dr["Code"].ToString();
                //countr.Name = city.Text = dr["Name"].ToString();
                //countr.Population = Convert.ToInt32(dr["Population"]);
                team.Text = txtName.Text;
                team.Name = index.ToString();
                int previous = index - 1;
                scrollGroup.ScrollControlIntoView(teamNames[0]);
                team.Location = new System.Drawing.Point(0, YOffset);
                
                //countryList.Add(countr);
                YOffset += 20;
                team.Click += arbitraryLabelClicked;
                scrollGroup.Controls.Add(team);
                index++;
                txtName.Text = "";
                lblStatus.Text = "send successful";




            }
            catch (MySqlException ex)
            {
                lblStatus.Text = "send not successful";
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "receiving new name";
        }
    }
    }
