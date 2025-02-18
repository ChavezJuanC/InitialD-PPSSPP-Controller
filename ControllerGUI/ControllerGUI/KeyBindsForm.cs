using System;
using System.Windows.Forms;
using KeyStrokeSim;

namespace ControllerGUI
{
    public partial class KeyBindsForm : Form
    {
        private MainForm _mainForm;
        private KeyStrokeEmiter _emiter;

        //keybind text box values //right //left // gas // brake //
        public char[] KeyBindChars { get; set; } = new char[4] { 'd', 'a', 'w', 's' };
        private TextBox[] keyBindFields;

        public KeyBindsForm(MainForm form, KeyStrokeEmiter emiter)
        {
            InitializeComponent();
            _mainForm = form;
            _emiter = emiter;

            keyBindFields = new TextBox[4] { RightInputBox, LeftInputBox, GasInputBox, BrakeInputBox };

            Console.WriteLine("Default Keybinds: ");
            for (int i = 0; i < KeyBindChars.Length; i++)
            {
                keyBindFields[i].Text = KeyBindChars[i].ToString();
                Console.Write(KeyBindChars[i]);
            }
            Console.WriteLine();
        }

        private void BackHomeButton_Click(object sender, System.EventArgs e)
        {
            _mainForm.ComeBackHome(this.Location);
        }

        private void SetKey(int index, TextBox textBox)
        {
            if (textBox.Text != "")
            {
                KeyBindChars[index] = textBox.Text.ToCharArray()[0];
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < KeyBindChars.Length; i++)
            {
                SetKey(i, keyBindFields[i]);
            }

            //update binds
            _emiter.updateKeyBinds(KeyBindChars);
            _mainForm.ComeBackHome(this.Location);
        }
    }
}
