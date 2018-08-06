using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Threading;

//made using tutorial by Guided Hacker https://www.youtube.com/watch?v=0osZuafJuB0
//KeyboardHook and Memory not made by me, they are made by the guys credited in the files

namespace DF2Tracker
{
    public partial class TrackerMain : Form
    {
        // Global variables
        Memory myMemory = new Memory();
        Process[] myProcess;
        bool isGameAvailable = false;

        //BASE ADDRESS: 008C53B8
        //some pointer: 00006954
        //This might not be correct, pointer scans yielded 110 results which sucks. will try to find a proper one soon
        string currentSecretCountAddress = "008C53B8";
        int[] currentSecretOffset = { 0x388 };
        float currentSecretCount;

        //BASE ADDRESS: 008C53D0
        //some pointer: 00005E94
        //same with this, many results and this one has worked so far
        string maxSecretCountAddress = "008C53D0";
        int[] maxSecretOffset = { 0x6a0 };
        float maxSecretCount;


        /* i am very stupid and forget how to do this
        
        //old racertool stuff

        string xPointer = "004BFD28";
        int[] xOff = { 0x50 };
        string zPointer = "004D7878";
        int[] zOff = { 0x54 };
        string yPointer = "00E29C04";
        int[] yOff = { 0x58 };

        float xCoord = 0;
        float zCoord = 0;
        float yCoord = 0;

        float savedXcoord;
        float savedZcoord;
        float savedYcoord;*/

        public TrackerMain()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            KeyboardHook.CreateHook(KeyReader);
        }

        private void GameAvailableTimer_Tick(object sender, EventArgs e)
        {
            myProcess = Process.GetProcessesByName("JediKnight");
            if (myProcess.Length != 0)
            {
                isGameAvailable = true;
                statusLabel.Text = "Status: JediKnight.exe found";
            }
            else
            {
                isGameAvailable = false;
                statusLabel.Text = "Status: JediKnight.exe NOT found";
            }
        }
        public static string HexToDec(int DEC)
        {
            return DEC.ToString("X");
        }
        public static int HexToDec(string Hex)
        {
            return int.Parse(Hex, NumberStyles.HexNumber);
        }

        public void KeyReader(IntPtr wParam, IntPtr lParam)
        {
            int key = Marshal.ReadInt32(lParam);
            KeyboardHook.VK vk = (KeyboardHook.VK)key;
            String temp = "";

            switch (vk)
            {
                case KeyboardHook.VK.VK_F1:
                    temp = "<-F1->";
                    break;
                case KeyboardHook.VK.VK_F2:
                    temp = "<-F2->";
                    break;
                case KeyboardHook.VK.VK_F3:
                    temp = "<-F3->";
                    break;
                case KeyboardHook.VK.VK_F4:
                    temp = "<-F4->";
                    break;
                case KeyboardHook.VK.VK_F5:
                    temp = "<-F5->";
                    break;
                case KeyboardHook.VK.VK_F6:
                    temp = "<-F6->";
                    break;
                case KeyboardHook.VK.VK_F7:
                    temp = "<-F7->";
                    break;
                case KeyboardHook.VK.VK_F8:
                    temp = "<-F8->";
                    break;
                case KeyboardHook.VK.VK_F9:
                    temp = "<-F9->";
                    break;
                case KeyboardHook.VK.VK_F10:
                    temp = "<-F10->";
                    break;
                case KeyboardHook.VK.VK_F11:
                    temp = "<-F11->";
                    break;
                case KeyboardHook.VK.VK_F12:
                    temp = "<-F12->";
                    break;
                case KeyboardHook.VK.VK_LSHIFT:
                    temp = "<-left shift->";
                    break;
                case KeyboardHook.VK.VK_LCONTROL:
                    temp = "<-left control->";
                    break;
                case KeyboardHook.VK.VK_SUBTRACT:
                    temp = "-";
                    break;
                case KeyboardHook.VK.VK_ADD:
                    temp = "+";
                    break;
                case KeyboardHook.VK.VK_DECIMAL:
                    temp = ".";
                    break;
                case KeyboardHook.VK.VK_DIVIDE:
                    temp = "/";
                    break;
                case KeyboardHook.VK.VK_NUMPAD0:
                    temp = "0";
                    break;
                case KeyboardHook.VK.VK_NUMPAD1:
                    temp = "1";
                    break;
                case KeyboardHook.VK.VK_NUMPAD2:
                    temp = "2";
                    break;
                case KeyboardHook.VK.VK_NUMPAD3:
                    temp = "3";
                    break;
                case KeyboardHook.VK.VK_NUMPAD4:
                    temp = "4";
                    break;
                case KeyboardHook.VK.VK_NUMPAD5:
                    temp = "5";
                    break;
                case KeyboardHook.VK.VK_NUMPAD6:
                    temp = "6";
                    break;
                case KeyboardHook.VK.VK_NUMPAD7:
                    temp = "7";
                    break;
                case KeyboardHook.VK.VK_NUMPAD8:
                    temp = "8";
                    break;
                case KeyboardHook.VK.VK_NUMPAD9:
                    temp = "9";
                    break;
                case KeyboardHook.VK.VK_0:
                    temp = "0";
                    break;
                case KeyboardHook.VK.VK_1:
                    temp = "1";
                    break;
                case KeyboardHook.VK.VK_2:
                    temp = "2";
                    break;
                case KeyboardHook.VK.VK_3:
                    temp = "3";
                    break;
                case KeyboardHook.VK.VK_4:
                    temp = "4";
                    break;
                case KeyboardHook.VK.VK_5:
                    temp = "5";
                    break;
                case KeyboardHook.VK.VK_6:
                    temp = "6";
                    break;
                case KeyboardHook.VK.VK_7:
                    temp = "7";
                    break;
                case KeyboardHook.VK.VK_8:
                    temp = "8";
                    break;
                case KeyboardHook.VK.VK_9:
                    temp = "9";
                    break;
                default: break;
            }

            /* Racertools key triggers
            #region Key triggers
            if (temp == "1")
            {
                if (isGameAvailable)
                {
                    saveCurrentPosition();
                }
                else
                {
                    ReportError();
                }
            }
            if (temp == "2")
            {
                if (isGameAvailable)
                {
                    goToSavedPosition();
                }
                else
                {
                    ReportError();
                }
            }
            #endregion
            */

        }
        private void ReportError()
        {
            int debug = Thread.CurrentThread.ManagedThreadId;
            Action action = ShowMessage;
            IAsyncResult res = BeginInvoke(action);
        }
        private void ShowMessage()
        {
            MessageBox.Show("Make sure game is running");

        }

        private void currentSecretTimer_Tick(object sender, EventArgs e)
        {

            //reader for base address
            if (isGameAvailable)
            {
                myMemory.ReadProcess = myProcess[0];
                myMemory.Open();
                int XpointerAddress = HexToDec(currentSecretCountAddress);
                int bytesRead;
                uint valueToRead = 4;
                byte[] readAddress = myMemory.Read((IntPtr)XpointerAddress, valueToRead, out bytesRead);
                currentSecretCount = BitConverter.ToSingle(readAddress, 0);
                myMemory.CloseHandle();
                //CloseHandle will crash the program if the game is in admin mode and the program isn't
            }

            /*if (isGameAvailable)
            {
                myMemory.ReadProcess = myProcess[0];
                myMemory.Open();
                int secretPointerAddress = HexToDec(currentSecretCountAddress);
                int[] secretPointerOffSet = currentSecretOffset;
                int bytesRead;
                uint valueToRead = 4;
                byte[] readAddress = myMemory.PointerRead((IntPtr)secretPointerAddress, valueToRead, secretPointerOffSet, out bytesRead);
                currentSecretCount = BitConverter.ToSingle(readAddress, 0);
                myMemory.CloseHandle();
            }*/
            //closehandle outside if-loop? ???? ? 

            //getting maxsecret
            if (isGameAvailable)
            {
                myMemory.ReadProcess = myProcess[0];
                myMemory.Open();
                int XpointerAddress = HexToDec(maxSecretCountAddress);
                int bytesRead;
                uint valueToRead = 4;
                byte[] readAddress = myMemory.Read((IntPtr)XpointerAddress, valueToRead, out bytesRead);
                maxSecretCount = BitConverter.ToSingle(readAddress, 0);
                myMemory.CloseHandle();
            }

            string oldSecretText = currentSecretLabel.Text;

            currentSecretLabel.Text = currentSecretCount + "/" + maxSecretCount;

            //trying to write this to textfile, probably big shit
            if (currentSecretLabel.Text != oldSecretText) {
                System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\DF2Tracker_export.txt", currentSecretLabel.Text);            
            }
            

            if (currentSecretCount == maxSecretCount)
            {
                currentSecretLabel.ForeColor = Color.Green;
            } else
            {
                currentSecretLabel.ForeColor = Color.Black;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("remember to edit this\n\n"
                + "Currently only works for 1.0 EXE and tested to work with the Steam version. No guarantees this will work. If you experience issues, please make an issue on GitHub and specify your JK version."
                + "For the source code and credits to other people, press Help to go the Github page", "hello I'm a help box", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, "https://github.com/Jisti007/DF2Tracker");
        }

    }

}
