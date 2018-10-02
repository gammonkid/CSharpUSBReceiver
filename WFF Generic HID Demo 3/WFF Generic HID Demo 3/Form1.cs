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

namespace WFF_Generic_HID_Demo_3
    {
    public partial class Form1 : Form
        {
        private const int Offset = 350;
        private const int Spread = 4;
        private Graphics graphdrawx;
        private Graphics graphdrawy;
        private Graphics graphdrawz;
        Pen Redpen = new Pen(Color.Red,4);
        Pen Bluepen = new Pen(Color.Blue,4);
        Pen Greenpen = new Pen(Color.Green,4);
        Pen Blackpen = new Pen(Color.Black, 2);
        int max= 512,  min = 512;

        public Form1()
            {
            InitializeComponent();
            graphdrawx= GraphSpace.CreateGraphics();
            graphdrawy = GraphSpace.CreateGraphics();
            graphdrawz = GraphSpace.CreateGraphics();
            // Create the USB reference device object (passing VID and PID)
            theUsbDemoDevice = new usbDemoDevice(0x04D8, 0x003F);

            // Add a listener for usb events
            theUsbDemoDevice.usbEvent += new usbDemoDevice.usbEventsHandler(usbEvent_receiver);

            // Perform an initial search for the target device
            theUsbDemoDevice.findTargetDevice();
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
            if(pause.Checked&&debugCollectionTimer.Enabled)
            {
                debugCollectionTimer.Enabled = false;
            }
            else if(!debugCollectionTimer.Enabled&&!pause.Checked)
            {
                debugCollectionTimer.Enabled = true;
            }
            if (theUsbDemoDevice.isDeviceAttached)
                {
                // Read the push button state
                this.MaxValue.Text = max.ToString();
                this.MinValue.Text = min.ToString();
                int datasize = theUsbDemoDevice.readData();

                pushButtonStateLabel.Text = datasize.ToString();


                // Read the LED state
                bool ledState = theUsbDemoDevice.readLedState();
                
                if (ledState == true) this.ledStateLabel.Text = "Toggle on";
                else this.ledStateLabel.Text = "Toggle off";
                
            }
            }

        private void xGraph_CheckedChanged(object sender, EventArgs e)
        {
            max = min = 512;
        }

        private void yGraph_CheckedChanged(object sender, EventArgs e)
        {
            max = min = 512;
        }

        private void zGraph_CheckedChanged(object sender, EventArgs e)
        {
            max = min = 512;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            if (int.TryParse(returnValue.Text, out int val))
            {
                f.init = val;
            }
            if (f.ShowDialog() == DialogResult.OK)
            {
                returnValue.Text = f.Value.ToString();
            };
        }

        // Collect debug timer has ticked
        private void debugCollectionTimer_Tick(object sender, EventArgs e)
            {
                int previous = 0;
                int count = 0;
                if (xGraph.Checked)
                {
                    graphdrawx.Clear(Color.White);
                    graphdrawx.DrawLine(Blackpen, 0, max-Offset, 1000, max-Offset);
                    graphdrawx.DrawLine(Blackpen, 0, min-Offset, 1000, min-Offset);
                    foreach (int value in theUsbDemoDevice.xQ)
                    {
                        if (count == 0)
                        {
                            graphdrawx.DrawLine(Redpen, count, value - Offset, count, value - Offset);
                        }
                        else
                        {
                            graphdrawx.DrawLine(Redpen, count - Spread, previous - Offset, count, value - Offset);
                        }
                        if (value> max)
                            max = value;
                        if (value< min)
                            min = value;
                        count += Spread;
                        previous = value;
                        //this.ledStateLabel.Text = (value.ToString());

                    }
                }
                if (yGraph.Checked)
                {
                    graphdrawy.Clear(Color.White);
                    graphdrawx.DrawLine(Blackpen, 0, max - Offset, 1000, max - Offset);
                    graphdrawx.DrawLine(Blackpen, 0, min - Offset, 1000, min - Offset);

                foreach (int value in theUsbDemoDevice.yQ)
                    {
                        if (count == 0)
                        {
                            graphdrawy.DrawLine(Greenpen, count, value - Offset, count, value - Offset);
                        }
                        else
                        {
                            graphdrawy.DrawLine(Greenpen, count - Spread, previous - Offset, count, value - Offset);
                        }
                        if (value > max)
                            max = value;
                        if (value < min)
                            min = value;
                        count += Spread;
                        previous = value;
                    }
                }
                if (zGraph.Checked)
                {
                    graphdrawz.Clear(Color.White);
                    graphdrawx.DrawLine(Blackpen, 0, max - Offset, 1000, max - Offset);
                    graphdrawx.DrawLine(Blackpen, 0, min - Offset, 1000, min - Offset);
                foreach (int value in theUsbDemoDevice.zQ)
                    {
                        if (count == 0)
                        {
                            graphdrawz.DrawLine(Bluepen, count, value - Offset, count, value - Offset);
                        }
                        else
                        {
                            graphdrawz.DrawLine(Bluepen, count - Spread, previous - Offset, count, value - Offset);
                        }
                        if (value > max)
                            max = value;
                        if (value < min)
                            min = value;
                        count += Spread;
                        previous = value;
                    }
                }

            }
        }
    }
