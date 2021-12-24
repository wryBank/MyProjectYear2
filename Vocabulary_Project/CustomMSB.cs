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
        string ButtonOK = System.IO.Directory.GetParent(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))).ToString() + @"\Button\ButtonOK.png";
        string ButtonYes = System.IO.Directory.GetParent(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))).ToString() + @"\Button\btYesnew.png";
        string ButtonNo = System.IO.Directory.GetParent(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))).ToString() + @"\Button\btNo.png";
        bool _ClickYes = true;
        public CustomMSB()
        {
            InitializeComponent();
        }
        public void LoginFailed()
        {
            _text = "Username or Password invalid";
            pbYes.Hide();
            pbNo.Image = Image.FromFile(ButtonOK);
            pbNo.Show();
            
            this.ShowDialog();

        }

        public void MSG_EXIT()
        {
            _text = "Exit Program";
            _exitProgram = true;
            pbNo.Image=Image.FromFile(ButtonNo);
            pbYes.Image=Image.FromFile(ButtonYes);
            pbYes.Show();
            pbNo.Show();
            this.ShowDialog();
        }
        private void CustomMSB_Load(object sender, EventArgs e)
        {
            lbText.Text = _text;

        }
        public bool GotoQuiz()
        {
            _text = "Go to QuizPage";
            this.ShowDialog();
            if(_ClickYes == true)
            {
                this.Hide();
                Quiz frmQuiz = new Quiz();
                frmQuiz.ShowDialog();
                return true;
            }
            else 
            {
                this.Hide();
                return false;
            }


        }

        private void pbYes_Click(object sender, EventArgs e)
        {
            _ClickYes = true;
            if(_exitProgram == true)
            {
                Application.Exit();
            }
            else
            {
                this.Close();
            }
        }
        public void JustMessage(string text)
        {
            _text = text;
            pbNo.Image=Image.FromFile(ButtonOK);
            pbNo.Show();
            pbYes.Hide();
            this.ShowDialog();
            
        }

        private void pbNo_Click(object sender, EventArgs e)
        {
            _ClickYes = false;
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
