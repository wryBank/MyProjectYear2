using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Vocabulary_Project
{
    public partial class frmRegister : Form
    {
        static string _buttonPassSound = System.IO.Directory.GetParent(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))).ToString() + @"\Sound\pop.wav";
        SoundPlayer popSound = new SoundPlayer(_buttonPassSound);
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void pbRegister_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text.Equals("") || (tbPassword.Text.Equals("")))
            { 
                MessageBox.Show("Username and Password can't be emty");
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(SQLHelper.ConnectionString))
                {
                    conn.Open();
                    string Username = tbUsername.Text;
                    string Password = tbPassword.Text;
                    string command = "INSERT INTO [Vocabulary_Project].[dbo].[Users] ( Username , Password) VALUES ('"+Username+"','"+Password+"')"; 
                    int query = SQLHelper.ExecuteNonQuery(conn, command, null);
                    if(query > 0)
                    {
                        MessageBox.Show("Done.");

                    }
                    conn.Close();

                }

            }

        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            frmLogin frmlogin = new frmLogin();
            this.Hide();
            frmlogin.ShowDialog();

        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            CustomMSB MSB = new CustomMSB();
            MSB.MSG_EXIT();
        }

        private void pnlRegister_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbBack_MouseEnter(object sender, EventArgs e)
        {
            popSound.Play();
        }
    }
}
