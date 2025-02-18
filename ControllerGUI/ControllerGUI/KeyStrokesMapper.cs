using ControllerGUI;
using System;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Threading;

namespace KeyStrokeSim
{
    public class KeyStrokeEmiter
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        private byte GasKey  = 0x57; //W
        private byte LeftKey  = 0x41; //A
        private byte BrakeKey  = 0x53; //S
        private byte RightKey  = 0x44; //D

        const int KEYEVENTF_KEYUP = 0x0002;

        public string currentInputCommand = string.Empty;
        private const string comPort = "COM4";
        private readonly SerialPort serialPort = new SerialPort(comPort, 9600, Parity.None, 8, StopBits.One);

        private char currentDirIndicator = 'm';

        // Constructor that accepts a MainForm instance
        private MainForm _form;
        public KeyStrokeEmiter(MainForm form)
        {
            _form = form;
        }

        public void StartCollectingSerialPortData()
        {
            serialPort.DataReceived += new SerialDataReceivedEventHandler(SPDataRecieved);
            serialPort.Open();
            Console.ReadLine();
        }

        private void SPDataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            currentInputCommand = serialPort.ReadExisting();
            HandleInputCommand(currentInputCommand);
        }

        private void ResetGasPedal()
        {
            //check pedals state here too
            _form.UpdateGasPedal(global::ControllerGUI.Properties.Resources.Gas_Pedal_Down);
        }

        private void ResetBrakePedal()
        {
            _form.UpdateBrakePedal(global::ControllerGUI.Properties.Resources.Brake_Pedal_Down);
        }


        private void UpdateJoystickImg(char direction)
        {
            if (direction == 'l' && currentDirIndicator != 'l')
            {
                currentDirIndicator = 'l';
                _form.UpdateJoystickPhoto(global::ControllerGUI.Properties.Resources.Analog_L);

            }
            else if (direction == 'r' && currentDirIndicator != 'r')
            {
                currentDirIndicator = 'r';
                _form.UpdateJoystickPhoto(global::ControllerGUI.Properties.Resources.Analog_R);
            }
            else if (direction == 'm' && currentDirIndicator != 'm')
            {
                currentDirIndicator = 'm';
                _form.UpdateJoystickPhoto(global::ControllerGUI.Properties.Resources.Analog_M);
            }
        }

        public void updateKeyBinds(char[] keyBindChars)
        {
            byte[] newCodes = new byte[4];
            //right //left // gas // brake //
            Console.WriteLine("Updating key binds....");
            //with a for loop..
            for (int i =0; i < keyBindChars.Length; i++)
            {
                byte keyCode = (byte)keyBindChars[i];
                newCodes[i] = keyCode;
                //convert char into VK_code from list of chars
                //set the keycode for each kay in keys array to Vk_code..
            }

            RightKey = newCodes[0];
            LeftKey = newCodes[1];
            GasKey = newCodes[2];
            BrakeKey = newCodes[3];

            Console.WriteLine();
        }

        private void HandleInputCommand(string inputcommand)
        {
            switch (inputcommand.Trim())
            {
                case "I":
                    Console.WriteLine("Idle");
                    UpdateJoystickImg('m');
                    ResetGasPedal();
                    ResetBrakePedal();
                    break;
                case "A":
                    Console.WriteLine("Accelarate + Brake");
                    keybd_event(GasKey, 0, 0, 0);
                    keybd_event(BrakeKey, 0, 0, 0);
                    Thread.Sleep(100);
                    keybd_event(GasKey, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(BrakeKey, 0, KEYEVENTF_KEYUP, 0);
                    UpdateJoystickImg('m');
                    _form.UpdateGasPedal(global::ControllerGUI.Properties.Resources.Gas_Pedal_Up);
                    _form.UpdateBrakePedal(global::ControllerGUI.Properties.Resources.Brake_Pedal_Up);
                    break;
                case "B":
                    Console.WriteLine("Accelerating");
                    keybd_event(GasKey, 0, 0, 0);
                    Thread.Sleep(100);
                    keybd_event(GasKey, 0, KEYEVENTF_KEYUP, 0);
                    UpdateJoystickImg('m');
                    _form.UpdateGasPedal(global::ControllerGUI.Properties.Resources.Gas_Pedal_Up);
                    ResetBrakePedal();
                    break;
                case "C":
                    Console.WriteLine("Braking");
                    keybd_event(BrakeKey, 0, 0, 0);
                    Thread.Sleep(100);
                    keybd_event(BrakeKey, 0, KEYEVENTF_KEYUP, 0);
                    UpdateJoystickImg('m');
                    ResetGasPedal();
                    _form.UpdateBrakePedal(global::ControllerGUI.Properties.Resources.Brake_Pedal_Up);
                    break;
                case "0":
                    Console.WriteLine("Accelarate + Brake + Right");
                    keybd_event(GasKey, 0, 0, 0);
                    keybd_event(BrakeKey, 0, 0, 0);
                    keybd_event(RightKey, 0, 0, 0);
                    Thread.Sleep(100);
                    keybd_event(GasKey, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(BrakeKey, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(RightKey, 0, KEYEVENTF_KEYUP, 0);
                    UpdateJoystickImg('r');
                    _form.UpdateGasPedal(global::ControllerGUI.Properties.Resources.Gas_Pedal_Up);
                    _form.UpdateBrakePedal(global::ControllerGUI.Properties.Resources.Brake_Pedal_Up);
                    break;
                case "1":
                    Console.WriteLine("Accelarate + Right");
                    keybd_event(GasKey, 0, 0, 0);
                    keybd_event(RightKey, 0, 0, 0);
                    Thread.Sleep(100);
                    keybd_event(GasKey, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(RightKey, 0, KEYEVENTF_KEYUP, 0);
                    UpdateJoystickImg('r');
                    _form.UpdateGasPedal(global::ControllerGUI.Properties.Resources.Gas_Pedal_Up);
                    ResetBrakePedal();
                    break;
                case "2":
                    Console.WriteLine("Brake + Right");
                    keybd_event(BrakeKey, 0, 0, 0);
                    keybd_event(RightKey, 0, 0, 0);
                    Thread.Sleep(100);
                    keybd_event(BrakeKey, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(RightKey, 0, KEYEVENTF_KEYUP, 0);
                    UpdateJoystickImg('r');
                    ResetGasPedal();
                    _form.UpdateBrakePedal(global::ControllerGUI.Properties.Resources.Brake_Pedal_Up);
                    break;
                case "3":
                    Console.WriteLine("Just Right");
                    keybd_event(RightKey, 0, 0, 0);
                    Thread.Sleep(100);
                    keybd_event(RightKey, 0, KEYEVENTF_KEYUP, 0);
                    UpdateJoystickImg('r');
                    ResetGasPedal();
                    ResetBrakePedal();
                    break;
                case "4":
                    Console.WriteLine("Accelarate + Brake + Left");
                    keybd_event(GasKey, 0, 0, 0);
                    keybd_event(BrakeKey, 0, 0, 0);
                    keybd_event(LeftKey, 0, 0, 0);
                    Thread.Sleep(100);
                    keybd_event(GasKey, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(BrakeKey, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(LeftKey, 0, KEYEVENTF_KEYUP, 0);
                    UpdateJoystickImg('l');
                    _form.UpdateGasPedal(global::ControllerGUI.Properties.Resources.Gas_Pedal_Up);
                    _form.UpdateBrakePedal(global::ControllerGUI.Properties.Resources.Brake_Pedal_Up);
                    break;
                case "5":
                    Console.WriteLine("Accelarate + Left");
                    keybd_event(GasKey, 0, 0, 0);
                    keybd_event(LeftKey, 0, 0, 0);
                    Thread.Sleep(100);
                    keybd_event(GasKey, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(LeftKey, 0, KEYEVENTF_KEYUP, 0);
                    UpdateJoystickImg('l');
                    _form.UpdateGasPedal(global::ControllerGUI.Properties.Resources.Gas_Pedal_Up);
                    _form.UpdateBrakePedal(global::ControllerGUI.Properties.Resources.Brake_Pedal_Up);
                    ResetBrakePedal();
                    break;
                case "6":
                    Console.WriteLine("Brake + Left");
                    keybd_event(BrakeKey, 0, 0, 0);
                    keybd_event(LeftKey, 0, 0, 0);
                    Thread.Sleep(100);
                    keybd_event(BrakeKey, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(LeftKey, 0, KEYEVENTF_KEYUP, 0);
                    UpdateJoystickImg('l');
                    ResetGasPedal();
                    _form.UpdateBrakePedal(global::ControllerGUI.Properties.Resources.Brake_Pedal_Up);
                    break;
                case "7":
                    Console.WriteLine("Just Left");
                    keybd_event(LeftKey, 0, 0, 0);
                    Thread.Sleep(100);
                    keybd_event(LeftKey, 0, KEYEVENTF_KEYUP, 0);
                    UpdateJoystickImg('l');
                    ResetGasPedal();
                    ResetBrakePedal();
                    break;
                case "8":
                    Console.WriteLine("UP");
                    break;
                case "9":
                    Console.WriteLine("DOWN");
                    break;
            }
        }
    }
}
