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
        CustomMSB MSB = new CustomMSB();
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
                MSB.JustMessage("Username and Password \n can't be emty");
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(SQLHelper.ConnectionString))
                {
                    conn.Open();
                    string Username = tbUsername.Text;
                    string Password = tbPassword.Text;
                    string command = "SELECT * FROM [Vocabulary_Project].[dbo].[Users] WHERE Username = '" + Username+"'";
                    SqlDataReader reader = SQLHelper.ExecuteReader(conn, CommandType.Text, command, null);
                    if (reader.HasRows)
                    {
                        MSB.JustMessage("this Username \n has already been registered.");
                    }
                    else
                    {

                        string command2 = "INSERT INTO [Vocabulary_Project].[dbo].[Users] ( Username , Password) VALUES ('" + Username + "','" + Password + "')";
                        int query = SQLHelper.ExecuteNonQuery(conn, command2, null);
                        if (query > 0)
                        {
                            MSB.JustMessage("Register success.");
                            frmLogin login = new frmLogin();
                            login.ShowDialog();
                            this.Close();
                        }
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


        private void pbBack_MouseEnter(object sender, EventArgs e)
        {
            popSound.Play();
        }

    }
}
