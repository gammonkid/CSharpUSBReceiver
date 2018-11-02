﻿//-----------------------------------------------------------------------------
//
//  usbDemoDevice.cs
//
//  USB Generic Demonstration 3_0_0_0
//
//  A demonstration application for the usbGenericHidCommunications library
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

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// The following namespace allows debugging output (when compiled in debug mode)
using System.Diagnostics;

namespace WFF_Generic_HID_Demo_3
{
    using usbGenericHidCommunications;

    /// <summary>
    /// This class performs several different tests against the 
    /// reference hardware/firmware to confirm that the USB
    /// communication library is functioning correctly.
    /// 
    /// It also serves as a demonstration of how to use the class
    /// library to perform different types of read and write
    /// operations.
    /// </summary>
    class usbDemoDevice : usbGenericHidCommunication
    {
        /// <summary>
        /// Class constructor - place any initialisation here

        public int[] xArray = new int[64];
        public int[] yArray = new int[64];
        public int[] zArray = new int[64];
        /// </summary>
        /// <param name="vid"></param>
        /// <param name="pid"></param>
        public usbDemoDevice(int vid, int pid) : base(vid, pid)
        {
        }

        public bool toggleLedState()
        {
            // Command 0x80 - Toggle LED state

            // Declare our output buffer
            Byte[] outputBuffer = new Byte[65];

            // Byte 0 must be set to 0
            outputBuffer[0] = 0;

            // Byte 1 must be set to our command
            outputBuffer[1] = 0x80;

            // Perform the write command
            bool success;
            success = writeRawReportToDevice(outputBuffer);

            // We can't tell if the device receieved the data ok, we are
            // only indicating that the write was error free.
            return success;
        }


        public void readXData()
        {
            // Command 0x81 - Read the push button state

            // Declare our output buffer
            //StreamWriter writer;
            //writer = File.AppendText("c:\\Users\\gammo\\Desktop\\txtdataKBTest.txt");
            int x = 0;
            int total = 0;
            Byte[] outputBuffer = new Byte[65];

            // Declare our input buffer
            Byte[] inputBuffer = new Byte[65];
            while (x != 64)
            {
                // Byte 0 must be set to 0
                outputBuffer[0] = 0;

                // Byte 1 must be set to our command
                outputBuffer[1] = 0x81;

                // Perform the write command
                bool success;
                success = writeRawReportToDevice(outputBuffer);

                // Only proceed if the write was successful
                if (success)
                {
                    // Perform the read
                    success = readSingleReportFromDevice(ref inputBuffer);
                }

                int i = 1;

                int num_of_packets = 65;
                while (i < num_of_packets)
                {
                    /*if (x % 3 == 0)
                    {
                        writer.Write("\r\n");
                    }*/
                    total = inputBuffer[i];
                    total = total | (inputBuffer[i + 1] << 8);
                    xArray[x] = total;
                    x += 1;
                    i += 2;
                    //writer.Write(total+" ");

                }
            }
            //writer.Close();

            return;
        }
        public void readYData()
        {
            // Command 0x81 - Read the push button state

            // Declare our output buffer
            //StreamWriter writer;
            //writer = File.AppendText("c:\\Users\\gammo\\Desktop\\txtdataKBTest.txt");
            int x = 0;
            int total = 0;
            Byte[] outputBuffer = new Byte[65];

            // Declare our input buffer
            Byte[] inputBuffer = new Byte[65];
            while (x != 64)
            {
                // Byte 0 must be set to 0
                outputBuffer[0] = 0;

                // Byte 1 must be set to our command
                outputBuffer[1] = 0x82;

                // Perform the write command
                bool success;
                success = writeRawReportToDevice(outputBuffer);

                // Only proceed if the write was successful
                if (success)
                {
                    // Perform the read
                    success = readSingleReportFromDevice(ref inputBuffer);
                }

                int i = 1;

                int num_of_packets = 65;
                while (i < num_of_packets)
                {
                    /*if (x % 3 == 0)
                    {
                        writer.Write("\r\n");
                    }*/
                    total = inputBuffer[i];
                    total = total | (inputBuffer[i + 1] << 8);
                    yArray[x] = total;
                    x += 1;
                    i += 2;
                    //writer.Write(total+" ");

                }
            }
            //writer.Close();

            return;
        }
        public void readZData()
        {
            // Command 0x81 - Read the push button state

            // Declare our output buffer
            //StreamWriter writer;
            //writer = File.AppendText("c:\\Users\\gammo\\Desktop\\txtdataKBTest.txt");
            int x = 0;
            int total = 0;
            Byte[] outputBuffer = new Byte[65];

            // Declare our input buffer
            Byte[] inputBuffer = new Byte[65];
            while (x != 64)
            {
                // Byte 0 must be set to 0
                outputBuffer[0] = 0;

                // Byte 1 must be set to our command
                outputBuffer[1] = 0x83;

                // Perform the write command
                bool success;
                success = writeRawReportToDevice(outputBuffer);

                // Only proceed if the write was successful
                if (success)
                {
                    // Perform the read
                    success = readSingleReportFromDevice(ref inputBuffer);
                }

                int i = 1;

                int num_of_packets = 65;
                while (i < num_of_packets)
                {
                    /*if (x % 3 == 0)
                    {
                        writer.Write("\r\n");
                    }*/
                    total = inputBuffer[i];
                    total = total | (inputBuffer[i + 1] << 8);
                    zArray[x] = total;
                    x += 1;
                    i += 2;
                    //writer.Write(total+" ");

                }
            }
            //writer.Close();

            return;
        }

        public int getDeviceInfo(int index)//index 2 is packets, index 3 is jersey number
        {
            // Command 0x82 - Read the LED state

            // Declare our output buffer
            Byte[] outputBuffer = new Byte[65];

            // Declare our input buffer
            Byte[] inputBuffer = new Byte[65];

            // Byte 0 must be set to 0
            outputBuffer[0] = 0;

            // Byte 1 must be set to our command
            outputBuffer[1] = 0x84;

            // Perform the write command
            bool success;
            success = writeRawReportToDevice(outputBuffer);

            // Only proceed if the write was successful
            if (success)
            {
                // Perform the read
                success = readSingleReportFromDevice(ref inputBuffer);
            }

            return inputBuffer[index];
        }

        // Collect debug information from the device
        public String collectDebug()
        {/*
            // Collect debug information from USB device
            Debug.WriteLine("Reference Application -> Collecting debug information from device");

            // Declare our output buffer
            Byte[] outputBuffer = new Byte[65];

            // Declare our input buffer
            Byte[] inputBuffer = new Byte[65];

            // Byte 0 must be set to 0
            outputBuffer[0] = 0;

            // Byte 1 must be set to our command
            outputBuffer[1] = 0x10;

            // Send the collect debug command
            writeRawReportToDevice(outputBuffer);

            // Read the response from the device
            readSingleReportFromDevice(ref inputBuffer);

            // Byte 1 contains the number of characters transfered
            if (inputBuffer[1] == 0) return String.Empty;

            // Convert the Byte array into a string of the correct length
            */
            string s = ""; /*System.Text.ASCIIEncoding.ASCII.GetString(inputBuffer, 2, inputBuffer[1]);
            */
            return s;
        }
    }
}