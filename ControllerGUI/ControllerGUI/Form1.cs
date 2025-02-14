using System;
using System.IO.Ports;

using System.Windows.Forms;

namespace ControllerGUI
{
    public partial class MainForm : Form
    {
        static string currentInputCommand = string.Empty;
        static string comPort = "COM4";
        readonly static SerialPort serialPort = new SerialPort(comPort, 9600, Parity.None, 8, StopBits.One);
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            StartCollectingSerailPortData();
        }

        private void StartCollectingSerailPortData()
        {
            serialPort.DataReceived += new SerialDataReceivedEventHandler(SPDataRecieved);
            serialPort.Open();
        }

        private void SPDataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            currentInputCommand = serialPort.ReadExisting();
            HandleInputCommand(currentInputCommand);
        }

        private void HandleInputCommand(string inputCommand)
        {
            switch (inputCommand.Trim())
            {
                case "A":
                    Console.WriteLine("Accelarate + Brake");
                    break;
                case "B":
                    Console.WriteLine("Accelerating");
                    break;
                case "C":
                    Console.WriteLine("Braking");
                    break;
                case "0":
                    Console.WriteLine("Accelarate + Brake + Right");
                    break;
                case "1":
                    Console.WriteLine("Accelarate + Right");
                    break;
                case "2":
                    Console.WriteLine("Brake + Right");
                    break;
                case "3":
                    Console.WriteLine("Just Right");
                    break;
                case "4":
                    Console.WriteLine("Accelarate + Brake + Left");
                    break;
                case "5":
                    Console.WriteLine("Accelarate + Left");
                    break;
                case "6":
                    Console.WriteLine("Brake + Left");
                    break;
                case "7":
                    Console.WriteLine("Just Left");
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
