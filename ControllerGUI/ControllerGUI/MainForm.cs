using KeyStrokeSim;
using System;
using System.Windows.Forms;


namespace ControllerGUI
{
    public partial class MainForm : Form
    {

        readonly private KeyStrokeEmiter emiter;
        public MainForm()
        {
            InitializeComponent();
            emiter = new KeyStrokeEmiter();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            //start collecting data here
            emiter.StartCollectingSerialPortData();
        }
    }
}

