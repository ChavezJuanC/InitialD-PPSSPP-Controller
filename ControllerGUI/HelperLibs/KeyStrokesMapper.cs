using System;
using System.Runtime.InteropServices;
using System.IO.Ports;
using System.Threading;

namespace KeyStrokeSim
{
    public class KeyStrokeEmiter
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        const byte VK_W = 0x57;
        const byte VK_A = 0x41;
        const byte VK_S = 0x53;
        const byte VK_D = 0x44;
        const int KEYEVENTF_KEYUP = 0x0002;

        private string currentInputCommand = string.Empty;
        private const string comPort = "COM4";
        private readonly SerialPort serialPort = new SerialPort(comPort, 9600, Parity.None, 8, StopBits.One);

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

        private void HandleInputCommand(string inputcommand)
        {
            switch (inputcommand.Trim())
            {
                case "A":
                    Console.WriteLine("Accelarate + Brake");
                    keybd_event(VK_W, 0, 0, 0);
                    keybd_event(VK_S, 0, 0, 0);
                    Thread.Sleep(100);
                    keybd_event(VK_W, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(VK_S, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case "B":
                    Console.WriteLine("Accelerating");
                    keybd_event(VK_W, 0, 0, 0);
                    Thread.Sleep(100);
                    keybd_event(VK_W, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case "C":
                    Console.WriteLine("Braking");
                    keybd_event(VK_S, 0, 0, 0);
                    Thread.Sleep(100);
                    keybd_event(VK_S, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case "0":
                    Console.WriteLine("Accelarate + Brake + Right");
                    keybd_event(VK_W, 0, 0, 0);
                    keybd_event(VK_S, 0, 0, 0);
                    keybd_event(VK_D, 0, 0, 0);
                    Thread.Sleep(100);
                    keybd_event(VK_W, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(VK_S, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(VK_D, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case "1":
                    Console.WriteLine("Accelarate + Right");
                    keybd_event(VK_W, 0, 0, 0);
                    keybd_event(VK_D, 0, 0, 0);
                    Thread.Sleep(100);
                    keybd_event(VK_W, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(VK_D, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case "2":
                    Console.WriteLine("Brake + Right");
                    keybd_event(VK_S, 0, 0, 0);
                    keybd_event(VK_D, 0, 0, 0);
                    Thread.Sleep(100);
                    keybd_event(VK_S, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(VK_D, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case "3":
                    Console.WriteLine("Just Right");
                    keybd_event(VK_D, 0, 0, 0);
                    Thread.Sleep(100);
                    keybd_event(VK_D, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case "4":
                    Console.WriteLine("Accelarate + Brake + Left");
                    keybd_event(VK_W, 0, 0, 0);
                    keybd_event(VK_S, 0, 0, 0);
                    keybd_event(VK_A, 0, 0, 0);
                    Thread.Sleep(100);
                    keybd_event(VK_W, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(VK_S, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(VK_A, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case "5":
                    Console.WriteLine("Accelarate + Left");
                    keybd_event(VK_W, 0, 0, 0);
                    keybd_event(VK_A, 0, 0, 0);
                    Thread.Sleep(100);
                    keybd_event(VK_W, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(VK_A, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case "6":
                    Console.WriteLine("Brake + Left");
                    keybd_event(VK_S, 0, 0, 0);
                    keybd_event(VK_A, 0, 0, 0);
                    Thread.Sleep(100);
                    keybd_event(VK_S, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(VK_A, 0, KEYEVENTF_KEYUP, 0);
                    break;
                case "7":
                    Console.WriteLine("Just Left");
                    keybd_event(VK_A, 0, 0, 0);
                    Thread.Sleep(100);
                    keybd_event(VK_A, 0, KEYEVENTF_KEYUP, 0);
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
