using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Vocabulary_Project
{
    public partial class frmSelect : Form
    {
        bool Isadmin;
        public frmSelect()
        {
            InitializeComponent();
        }

        public frmSelect(bool Isadmin)
        {
            InitializeComponent();
            this.Isadmin = Isadmin;
        }
        private void frmSelect_Load(object sender, EventArgs e) { 

            if(Isadmin == true)
            {
                pbNewV.Show();
                lbAddV.Show();
            }
            else
            {
                lbAddV.Hide();
                pbNewV.Hide();
            }

        }

        private void pbLearnIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLearn frmlearn = new frmLearn();
            frmlearn.ShowDialog();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            CustomMSB MSB = new CustomMSB();
            MSB.MSG_EXIT();

        }

        private void pbTestIcon_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Quiz frmquiz = new Quiz();
            frmquiz.ShowDialog();
        }

        private void pbNewV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdmin addVo = new frmAdmin();
            addVo.ShowDialog();

        }
    }
}
