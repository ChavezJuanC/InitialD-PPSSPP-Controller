using System.Windows.Forms;

namespace ControllerGUI
{
    public partial class KeyBindsForm : Form
    {
        private MainForm _mainForm;
        public KeyBindsForm(MainForm form)
        {
            InitializeComponent();
            _mainForm = form;
        }

        private void BackHomeButton_Click(object sender, System.EventArgs e)
        {
            _mainForm.ComeBackHome();
        }
    }
}
