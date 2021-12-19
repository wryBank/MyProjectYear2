using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Vocabulary_Project
{
    public partial class CustomMSB : Form
    {
        string _text;
        bool _exitProgram;
        static string _buttonPassSound = System.IO.Directory.GetParent(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))).ToString() + @"\Sound\pop.wav";
        SoundPlayer popSound = new SoundPlayer(_buttonPassSound);
        public CustomMSB()
        {
            InitializeComponent();
        }
        public void LoginFailed()
        {
            _text = "Username or Password invalid";
            this.ShowDialog();

        }

        public void MSG_EXIT()
        {
            _text = "Exit Program";
            _exitProgram = true;
            this.ShowDialog();
        }
        private void CustomMSB_Load(object sender, EventArgs e)
        {
            lbText.Text = _text;

        }

        private void pbYes_Click(object sender, EventArgs e)
        {
            if(_exitProgram == true)
            {
                Application.Exit();
            }
            else
            {
                this.Close();
            }
        }

        private void pbNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbYes_MouseEnter(object sender, EventArgs e)
        {
            popSound.Play();

        }

        private void pbNo_MouseEnter(object sender, EventArgs e)
        {
            popSound.Play();

        }
    }
}
