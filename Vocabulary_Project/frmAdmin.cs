using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using Vocabulary_Project.Models;

namespace Vocabulary_Project
{
    public partial class frmAdmin : Form
    {
        CustomMSB MSB = new CustomMSB();
        string _Vocabulary;
        string _fileName;
        string _jpefileName;
        public frmAdmin()
        {
            InitializeComponent();
        }
        private void frmAdmin_Load(object sender, EventArgs e)
        {


        }

        private void btBwors_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if(result == DialogResult.OK)
            {
                pbInput.Image = Image.FromFile(ofd.FileName);
                _fileName = ofd.FileName;
                _jpefileName = Path.GetFileName(ofd.FileName);
            }
            //MessageBox.Show(_jpefileName.ToString());
            

        }

        private void btOK_Click(object sender, EventArgs e)
        {
            string newPath = System.IO.Directory.GetParent(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))).ToString() + @"\Pic\" + _jpefileName;
            if (_fileName == null)
            {
                MSB.JustMessage("Please add image.");
            }
            else if (tbVocabulary.Text.Equals("") )
            {
                MSB.JustMessage("Vocabulary can't be emty.");

            }
            else if (File.Exists(newPath))
            {
                MSB.JustMessage("File already exist \n please change filename.");
            }
            else
            {

                _Vocabulary = tbVocabulary.Text.ToLower().ToString();
                using (SqlConnection conn = new SqlConnection(SQLHelper.ConnectionString))
                {
                    conn.Open();
                    string command = "SELECT * FROM [Vocabulary_Project].[dbo].[Quiz] WHERE Vocabulary = '" + _Vocabulary + "'";
                    SqlDataReader reader = SQLHelper.ExecuteReader(conn, CommandType.Text, command, null);
                    if (reader.HasRows)
                    {
                        MSB.JustMessage("this Vocabulary \n has already been added.");
                    }
                    else
                    {

                        File.Copy(_fileName, newPath, false);
                        string command2 = "INSERT INTO [Vocabulary_Project].[dbo].[Quiz] ( Vocabulary , PicFile) VALUES ('" + _Vocabulary + "','" + _jpefileName + "')";
                        int query = SQLHelper.ExecuteNonQuery(conn, command2, null);
                        if (query > 0)
                        {
                            MSB.JustMessage("Add vocabulary success.");
                        }

                    }
                    conn.Close();
                }
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            MSB.MSG_EXIT();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            frmSelect frmSelect = new frmSelect(true);
            this.Hide();
            frmSelect.ShowDialog();

        }
    }
}
