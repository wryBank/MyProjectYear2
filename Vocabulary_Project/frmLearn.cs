using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Vocabulary_Project.Models;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using System.Media;

namespace Vocabulary_Project

{
    public partial class frmLearn : Form
    {
        static string _buttonPassSound = System.IO.Directory.GetParent(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))).ToString() + @"\Sound\pop.wav";
        SoundPlayer popSound = new SoundPlayer(_buttonPassSound);
        private List<QuizModel> Vocabulary;
        private int _Page;
        private int _totalRowCounts;
        public frmLearn()
        {
            InitializeComponent();
        }

        private void pbNextButton_Click(object sender, EventArgs e)
        {
                _Page++;
            _totalRowCounts = GetRowCount();
            pbBackButton.Show();
            //MessageBox.Show("answer" + _Quiz[_Page - 1].Vocabulary.ToUpper().ToString());
            if(_Page > _totalRowCounts)
            {
                CustomMSB MSG = new CustomMSB();
                bool check =  MSG.GotoQuiz();
                if(check == true)
                {
                    this.Close();
                }
                else if(check == false)
                {
                    _Page--;

                }
                
            }
            else
            {
                string directoryInfo = System.IO.Directory.GetParent(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))).ToString() + @"\Pic\" + Vocabulary[_Page - 1].PicFile;
                pbPic.Image = Image.FromFile(directoryInfo);
                lbVocabulary.Text = Vocabulary[_Page -1].Vocabulary;
            }
        }

        private void frmLearn_Load(object sender, EventArgs e)
        {
            pbBackButton.Hide();
            _Page = 1;
            _totalRowCounts = GetRowCount();
            string directoryInfo = System.IO.Directory.GetParent(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))).ToString() + @"\Pic\" + Vocabulary[_Page - 1].PicFile;
            pbPic.Image = Image.FromFile(directoryInfo);
            lbVocabulary.Text = Vocabulary[_Page -1].Vocabulary;

        }
        private int GetRowCount()
        {
            int rowCount = 0;
            using (SqlConnection conn = new SqlConnection(SQLHelper.ConnectionString))
            {
                conn.Open();
                string command = "SELECT * FROM [Vocabulary_Project].[dbo].[Quiz]";
                SqlDataAdapter ad = new SqlDataAdapter(command,conn);
                DataTable datatable = new DataTable();
                ad.Fill(datatable);
                
                rowCount = datatable.Rows.Count;
                Vocabulary = ConvertDataTableToList(datatable);
                conn.Close();

            }
            return rowCount;
        }
        private List<QuizModel> ConvertDataTableToList(DataTable dataTable)
        {
            List<QuizModel> Quizlist = new List<QuizModel>();
            for(int i = 0; i < dataTable.Rows.Count; i++)
            {
                QuizModel quiz = new QuizModel();
                quiz.QuizId = Convert.ToInt32(dataTable.Rows[i]["QuizId"]);
                quiz.Vocabulary = dataTable.Rows[i]["Vocabulary"].ToString();
                quiz.PicFile = dataTable.Rows[i]["PicFile"].ToString();
                Quizlist.Add(quiz);
            }
           
            return Quizlist;

        }

        private void pbBackButton_Click(object sender, EventArgs e)
        {
                _Page--;
                string directoryInfo = System.IO.Directory.GetParent(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))).ToString() + @"\Pic\" + Vocabulary[_Page - 1].PicFile;
                pbPic.Image = Image.FromFile(directoryInfo);
                lbVocabulary.Text = Vocabulary[_Page -1].Vocabulary;
            if(_Page == 1)
            {
                pbBackButton.Hide();
            }
        }

        private void pbExitButton_Click(object sender, EventArgs e)
        {
            CustomMSB MSB = new CustomMSB();
            MSB.MSG_EXIT();

        }

        private void pbNextButton_MouseEnter(object sender, EventArgs e)
        {
            popSound.Play();
        }
    }
}
