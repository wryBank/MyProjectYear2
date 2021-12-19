using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vocabulary_Project.Models;

namespace Vocabulary_Project
{
    public partial class frmLogin : Form
    {

        static string _buttonPassSound = System.IO.Directory.GetParent(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))).ToString() + @"\Sound\pop.wav";
        SoundPlayer popSound = new SoundPlayer(_buttonPassSound);
        public static string Username;
        static string Password;
        public Result userInfo { get; set; }
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void btRegister_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonLoginEnterEvent(object sender, EventArgs e)
        {

        }

        private void pbRegister_Click(object sender, EventArgs e)
        {
            frmRegister registerPage = new frmRegister();
            this.Hide();
            registerPage.ShowDialog();

        }
        private void pbLogin_Click(object sender, EventArgs e)
        {
            Username = tbUsername.Text;
            Password = tbPassword.Text;
           
            using (SqlConnection conn = new SqlConnection(SQLHelper.ConnectionString))
            {
                conn.Open();
                string command = "SELECT * FROM [Vocabulary_Project].[dbo].[Users] WHERE Username = '" + Username+"' AND Password = '"+Password+"'";
                SqlDataReader reader = SQLHelper.ExecuteReader(conn, CommandType.Text, command, null);
                if (reader.HasRows)
                {
                    this.Hide();
                    frmSelect frmSelect = new frmSelect();
                    frmSelect.ShowDialog();
                }
                else
                {
                    CustomMSB Msg = new CustomMSB();
                    Msg.LoginFailed();
                }

                conn.Close();

            }

        }
        private void pbExit_Click(object sender, EventArgs e)
        {

            CustomMSB MSB = new CustomMSB();
            MSB.MSG_EXIT();
        }

        private void pbLogin_MouseEnter(object sender, EventArgs e)
        {
            popSound.Play();
        }

        private void pbRegister_MouseEnter(object sender, EventArgs e)
        {

            popSound.Play();
        }
    }
}
