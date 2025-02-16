using KeyStrokeSim;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace ControllerGUI
{
    public partial class MainForm : Form
    {

        readonly private KeyStrokeEmiter emiter;
        public MainForm()
        {
            InitializeComponent();
            emiter = new KeyStrokeEmiter(this);
        }

        // Public method to update the button text from another class
        public void UpdateJoystickPhoto(Bitmap img)
        {
            JoyStickPictureBox.BackgroundImage = img;
        }

        public void UpdateGasPedal(Bitmap img)
        {
            Gas_Picture_Box.BackgroundImage = img;
        }

        public void UpdateBrakePedal(Bitmap img)
        {
            Brake_Picture_Box.BackgroundImage = img;
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            //start collecting data here
            emiter.StartCollectingSerialPortData();
        }
    }
}

