using System;
using System.IO.Ports;

using System.Windows.Forms;

namespace ControllerGUI
{
    public partial class MainForm : Form
    {
        static string comPort = "COM4";
        static SerialPort serialPort = new SerialPort(comPort, 9600, Parity.None, 8, StopBits.One);
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
            Console.WriteLine(serialPort.ReadExisting());
        }
    }
}
