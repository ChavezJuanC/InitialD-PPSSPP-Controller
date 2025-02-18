using KeyStrokeSim;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace ControllerGUI
{
    public partial class MainForm : Form
    {

        readonly private KeyStrokeEmiter emiter;
        readonly private KeyBindsForm bindsForm;

        public MainForm()
        {
            InitializeComponent();
            emiter = new KeyStrokeEmiter(this);
            bindsForm = new KeyBindsForm(this, emiter);
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

        public void ComeBackHome(Point location)
        {
            Point currentPosition = location;
            bindsForm.Hide();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = currentPosition;
            this.Show();
        }

        private void SetKeybindsButton_Click(object sender, EventArgs e)
        {
            Point currentPosition = this.Location;
            // Get the current position of this form
            this.Hide();
            bindsForm.StartPosition = FormStartPosition.Manual;
            bindsForm.Location = currentPosition;
            bindsForm.Show();
        }

    }
}

