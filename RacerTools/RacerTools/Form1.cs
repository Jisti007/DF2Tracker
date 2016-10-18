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

namespace RacerTools
{
    public partial class Form1 : Form
    {
        #region Global variables
        Memory myMemory = new Memory();
        Process[] myProcess;
        bool isGameAvailable = false;
        
        string xPointer = "004BFD28";
        int[] xOff = {0x50};
        string zPointer = "004D7878";
        int[] zOff = {0x54};
        string yPointer = "00E29C04";
        int[] yOff = {0x58};

        float xCoord = 0;
        float zCoord = 0;
        float yCoord = 0;

        float savedXcoord;
        float savedZcoord;
        float savedYcoord;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            KeyboardHook.CreateHook(KeyReader);
        }

        private void gotoZerobtn_Click(object sender, EventArgs e)
        {
            goToZeroPosition();
        }
        private void savePositionbtn_Click(object sender, EventArgs e)
        {
            saveCurrentPosition();
        }
        private void gotoPositionbtn_Click(object sender, EventArgs e)
        {
            goToSavedPosition();
        }
        private void GameAvailableTimer_Tick(object sender, EventArgs e)
        {
            myProcess = Process.GetProcessesByName("SWEP1RCR");
            if (myProcess.Length != 0)
            {
                isGameAvailable = true;
                statusLabel.Text = "Status: SWEP1RCR.exe found";
            }
            else
            {
                statusLabel.Text = "Status: SWEP1RCR.exe NOT found";
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
        public void goToZeroPosition()
        {
            #region X
            if (isGameAvailable)
            {
                myMemory.ReadProcess = myProcess[0];
                myMemory.Open();
                int XpointerAddress = HexToDec(xPointer);
                int[] XpointerOffSet = xOff;
                int bytesWritten;
                byte[] valueToWrite = BitConverter.GetBytes(xCoord);
                string writtenAddress = myMemory.PointerWrite((IntPtr)XpointerAddress, valueToWrite, XpointerOffSet, out bytesWritten);
                myMemory.CloseHandle();
            }
            #endregion
            #region Z
            if (isGameAvailable)
            {
                myMemory.ReadProcess = myProcess[0];
                myMemory.Open();
                int ZpointerAddress = HexToDec(zPointer);
                int[] ZpointerOffSet = zOff;
                int bytesWritten;
                byte[] valueToWrite = BitConverter.GetBytes(zCoord);
                string writtenAddress = myMemory.PointerWrite((IntPtr)ZpointerAddress, valueToWrite, ZpointerOffSet, out bytesWritten);
                myMemory.CloseHandle();
            }
            #endregion
            #region Y
            if (isGameAvailable)
            {
                myMemory.ReadProcess = myProcess[0];
                myMemory.Open();
                int YpointerAddress = HexToDec(yPointer);
                int[] YpointerOffSet = yOff;
                int bytesWritten;
                byte[] valueToWrite = BitConverter.GetBytes(yCoord);
                string writtenAddress = myMemory.PointerWrite((IntPtr)YpointerAddress, valueToWrite, YpointerOffSet, out bytesWritten);
                myMemory.CloseHandle();
            }
            #endregion
        }

        public void saveCurrentPosition()
        {
            #region X
            if (isGameAvailable)
            {
                myMemory.ReadProcess = myProcess[0];
                myMemory.Open();
                int XpointerAddress = HexToDec(xPointer);
                int[] XpointerOffSet = xOff;
                int bytesRead;
                uint valueToRead = 50;
                byte[] readAddress = myMemory.PointerRead((IntPtr)XpointerAddress, valueToRead, XpointerOffSet, out bytesRead);
                savedXcoord = BitConverter.ToSingle(readAddress, 0);
                myMemory.CloseHandle();
            }
            #endregion
            #region Z
            if (isGameAvailable)
            {
                myMemory.ReadProcess = myProcess[0];
                myMemory.Open();
                int ZpointerAddress = HexToDec(zPointer);
                int[] ZpointerOffSet = zOff;
                int bytesRead;
                uint valueToRead = 54;
                byte[] readAddress = myMemory.PointerRead((IntPtr)ZpointerAddress, valueToRead, ZpointerOffSet, out bytesRead);
                savedZcoord = BitConverter.ToSingle(readAddress, 0);
                myMemory.CloseHandle();
            }
            #endregion
            #region Y
            if (isGameAvailable)
            {
                myMemory.ReadProcess = myProcess[0];
                myMemory.Open();
                int YpointerAddress = HexToDec(yPointer);
                int[] YpointerOffSet = yOff;
                int bytesRead;
                uint valueToRead = 54;
                byte[] readAddress = myMemory.PointerRead((IntPtr)YpointerAddress, valueToRead, YpointerOffSet, out bytesRead);
                savedYcoord = BitConverter.ToSingle(readAddress, 0);
                myMemory.CloseHandle();
            }
            #endregion
        }
        public void goToSavedPosition()
        {
            #region X
            if (isGameAvailable)
            {
                myMemory.ReadProcess = myProcess[0];
                myMemory.Open();
                int XpointerAddress = HexToDec(xPointer);
                int[] XpointerOffSet = xOff;
                int bytesWritten;
                byte[] valueToWrite = BitConverter.GetBytes(savedXcoord);
                string writtenAddress = myMemory.PointerWrite((IntPtr)XpointerAddress, valueToWrite, XpointerOffSet, out bytesWritten);
                myMemory.CloseHandle();
            }
            #endregion
            #region Z
            if (isGameAvailable)
            {
                myMemory.ReadProcess = myProcess[0];
                myMemory.Open();
                int ZpointerAddress = HexToDec(zPointer);
                int[] ZpointerOffSet = zOff;
                int bytesWritten;
                byte[] valueToWrite = BitConverter.GetBytes(savedZcoord);
                string writtenAddress = myMemory.PointerWrite((IntPtr)ZpointerAddress, valueToWrite, ZpointerOffSet, out bytesWritten);
                myMemory.CloseHandle();
            }
            #endregion
            #region Y
            if (isGameAvailable)
            {
                myMemory.ReadProcess = myProcess[0];
                myMemory.Open();
                int YpointerAddress = HexToDec(yPointer);
                int[] YpointerOffSet = yOff;
                int bytesWritten;
                byte[] valueToWrite = BitConverter.GetBytes(savedYcoord);
                string writtenAddress = myMemory.PointerWrite((IntPtr)YpointerAddress, valueToWrite, YpointerOffSet, out bytesWritten);
                myMemory.CloseHandle();
            }
            #endregion
        }

        private void positionTimer_Tick(object sender, EventArgs e)
        {
            curPosXLbl.Text = "X: " + savedXcoord;
            curPosYLbl.Text = "Y: " + savedYcoord;
            curPosZLbl.Text = "Z: " + savedZcoord;
        }

        private void addSavedYValue_Click(object sender, EventArgs e)
        {
            savedYcoord = savedYcoord + 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pressing 1 saves current position\nPressing 2 goes to saved position\n\n"
                + "Tested to work with manually installed Racer with DGVoodoo. 64-bit installed versions may not work\n\n"
                + "For the source code and credits to other people, press Help to go the Github page", "hello I'm a help box", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, "https://github.com/JichiSenpai/RacerTools");
        }
    }

}
