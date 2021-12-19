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
        public frmSelect()
        {
            InitializeComponent();
        }

        private void frmSelect_Load(object sender, EventArgs e) { 


        }

        private void pbLearnIcon_Click(object sender, EventArgs e)
        {
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
    }
}
