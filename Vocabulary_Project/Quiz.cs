using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vocabulary_Project.Models;
using System.Media;

namespace Vocabulary_Project
{
    public partial class Quiz : Form
    {
        static string _buttonPassSound = System.IO.Directory.GetParent(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))).ToString() + @"\Sound\pop.wav";
        SoundPlayer popSound = new SoundPlayer(_buttonPassSound);
        private List<QuizModel> _Quiz;
        private int _totalRowCounts;
        private int _Page;

        private int _Score { get; set; }
        private Random _random = new Random();
        List <char>alphalist = new List<char>(26) {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z' };
        private char [] answer;
        private string answer2;
        private int _lastButtonClick;
        private List <int> _StackButtonClick = new List<int> ();
            
        public Quiz()
        {
            InitializeComponent();
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            _Page = 1;
            _totalRowCounts = GetRowCount();
            answer2 = _Quiz[_Page - 1].Vocabulary.ToUpper();
            answer = _Quiz[_Page - 1].Vocabulary.ToUpper().ToCharArray(); 
            string directoryInfo = System.IO.Directory.GetParent(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))).ToString() + @"\Pic\" + _Quiz[_Page - 1].PicFile;
            pbQuiz.Image = Image.FromFile(directoryInfo);
            lbScore.Text = _Score.ToString();
            GetButtonWord();
        }
        private void GetButtonWord()
        {
            int numran = _random.Next(0,alphalist.Count);
            int ranWordAnswer = _random.Next(0, answer.Length);
            int  tempForAnswerindex = answer.Length;
            for(int i = 0; i<alphalist.Count; i++)
            {
                 numran = _random.Next(0,alphalist.Count);
                if (i == 0)
                {
                    btWord1.Text = alphalist[numran].ToString();
                    
                }
                else if(i == 1)
                {
                   btWord2.Text = alphalist[numran].ToString();
                }
                else if(i == 2)
                {
                    btWord3.Text = alphalist[numran].ToString();

                }
                else if(i == 3)
                {
                    btWord4.Text = alphalist[numran].ToString();

                }
                else if(i == 4)
                {
                    btWord5.Text = alphalist[numran].ToString();

                }
                else if(i == 5)
                {

                    btWord6.Text = alphalist[numran].ToString();
                }
                else if(i == 6)
                {
                    btWord7.Text = alphalist[numran].ToString();

                }
                else if(i == 7)
                {
                    btWord8.Text = alphalist[numran].ToString();

                }
                else if(i == 8)
                {
                    btWord9.Text = alphalist[numran].ToString();

                }
                else if(i == 9)
                {
                    btWord10.Text = alphalist[numran].ToString();

                }
            }
            
            

            
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
                _Quiz = ConvertDataTableToList(datatable);
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
        private void reset()
        {
            GetButtonWord();
            btWord1.Show();
            btWord2.Show();
            btWord3.Show();
            btWord4.Show();
            btWord5.Show();
            btWord6.Show();
            btWord7.Show();
            btWord8.Show();
            btWord9.Show();
            btWord10.Show();

        }
        private void resetToNextPage()
        {
            GetButtonWord();
            btWord1.Show();
            btWord2.Show();
            btWord3.Show();
            btWord4.Show();
            btWord5.Show();
            btWord6.Show();
            btWord7.Show();
            btWord8.Show();
            btWord9.Show();
            btWord10.Show();
            tbTextSelected.Text = null;
            keepword.Clear();


        }

        List<char> keepword = new List<char>(20);
        private void ButtonToTextbox(char [] text)
        {
            string listToText;
            for(int k = 0; k< text.Length; k++)
            {
                keepword.Add(text[k]); 
            }
            listToText = string.Join(null,keepword);

            tbTextSelected.Text = listToText;

        }
        private void TextRemove()
        {

            if (tbTextSelected.TextLength > 0)
            {
                tbTextSelected.Text = tbTextSelected.Text.Substring(0, (tbTextSelected.TextLength-1));
                keepword.RemoveAt(tbTextSelected.Text.Length);
            }

        }
        private void pbQuiz_Click(object sender, EventArgs e)
        {

        }



        private void SwitchAlphabet_Click_1(object sender, EventArgs e)
        {
            reset();
        }

        private void btWord1_Click(object sender, EventArgs e)
        {
            ButtonToTextbox(btWord1.Text.ToUpper().ToCharArray());
            _lastButtonClick = 1;
            _StackButtonClick.Add(_lastButtonClick);
            
                btWord1.Hide();        
        }

        private void btWord2_Click(object sender, EventArgs e)
        {
            ButtonToTextbox(btWord2.Text.ToUpper().ToCharArray());
            _lastButtonClick = 2;
            _StackButtonClick.Add(_lastButtonClick);
                btWord2.Hide();        
        }

        private void btWord3_Click(object sender, EventArgs e)
        {
            ButtonToTextbox(btWord3.Text.ToUpper().ToCharArray());
            _lastButtonClick = 3;
            _StackButtonClick.Add(_lastButtonClick);
                btWord3.Hide();

        }

        private void btWord4_Click(object sender, EventArgs e)
        {

            ButtonToTextbox(btWord4.Text.ToUpper().ToCharArray());
            _lastButtonClick = 4;
            _StackButtonClick.Add(_lastButtonClick);
                btWord4.Hide();
        }

        private void btWord5_Click(object sender, EventArgs e)
        {
            ButtonToTextbox(btWord5.Text.ToUpper().ToCharArray());
            _lastButtonClick = 5;
            _StackButtonClick.Add(_lastButtonClick);
                btWord5.Hide();

        }

        private void btWord6_Click(object sender, EventArgs e)
        {

            ButtonToTextbox(btWord6.Text.ToUpper().ToCharArray());
            _lastButtonClick = 6;
            _StackButtonClick.Add(_lastButtonClick);
                btWord6.Hide();
        }

        private void btWord7_Click(object sender, EventArgs e)
        {

            ButtonToTextbox(btWord7.Text.ToUpper().ToCharArray());
            _lastButtonClick = 7;
            _StackButtonClick.Add(_lastButtonClick);
                btWord7.Hide();
        }

        private void btWord8_Click(object sender, EventArgs e)
        {

            ButtonToTextbox(btWord8.Text.ToUpper().ToCharArray());
            _lastButtonClick = 8;
            _StackButtonClick.Add(_lastButtonClick);
                btWord8.Hide();
        }

        private void btWord9_Click(object sender, EventArgs e)
        {

            ButtonToTextbox(btWord9.Text.ToUpper().ToCharArray());
            _lastButtonClick = 9;
            _StackButtonClick.Add(_lastButtonClick);
                btWord9.Hide();
        }

        private void btWord10_Click(object sender, EventArgs e)
        {

            ButtonToTextbox(btWord10.Text.ToUpper().ToCharArray());
            _lastButtonClick = 10;
            _StackButtonClick.Add(_lastButtonClick);
                btWord10.Hide();
        }
        

        private void btnNext_Click(object sender, EventArgs e)
        {
            string directorySound = System.IO.Directory.GetParent(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))).ToString() + @"\Sound\CorretSound.wav";
            SoundPlayer Sound = new SoundPlayer(directorySound);
            string directoryBadSound = System.IO.Directory.GetParent(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))).ToString() + @"\Sound\notCorretSound.wav";
            SoundPlayer BadSound = new SoundPlayer(directoryBadSound);
            
            
            if (tbTextSelected.Text.Equals(answer2))
            {
                Sound.Play();
                _Score++;

            }
            else
            {
                BadSound.Play();

            }
                _Page++;
                resetToNextPage();
                nextPage();
        }
        private void nextPage()
        {
            
            _totalRowCounts = GetRowCount();
            if(_Page > _totalRowCounts)
            {
                int allrowcount = GetRowCount();
                lbScore.Text = _Score.ToString();
                this.Hide();
                frmResult result = new frmResult(_Score,allrowcount);
                result.ShowDialog();
            }
            else
            {
            answer = _Quiz[_Page - 1].Vocabulary.ToUpper().ToCharArray();
            answer2 = _Quiz[_Page - 1].Vocabulary.ToUpper();
            string directoryInfo = System.IO.Directory.GetParent(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))).ToString() + @"\Pic\" + _Quiz[_Page - 1].PicFile;
            pbQuiz.Image = Image.FromFile(directoryInfo);

            lbScore.Text = _Score.ToString();
            }

        }


        private void pbExit_Click(object sender, EventArgs e)
        {

            CustomMSB MSB = new CustomMSB();
            MSB.MSG_EXIT();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (tbTextSelected.Text.Equals(""))
            {

            }
            else
            {
                _lastButtonClick = _StackButtonClick[_StackButtonClick.Count - 1];


                if (_lastButtonClick == 1)
                {
                    btWord1.Show();
                    _StackButtonClick.Remove(_StackButtonClick[_StackButtonClick.Count - 1]);

                }
                else if (_lastButtonClick == 2)
                {
                    btWord2.Show();
                    _StackButtonClick.Remove(_StackButtonClick[_StackButtonClick.Count - 1]);
                }
                else if (_lastButtonClick == 3)
                {
                    btWord3.Show();
                    _StackButtonClick.Remove(_StackButtonClick[_StackButtonClick.Count - 1]);
                }
                else if (_lastButtonClick == 4)
                {
                    btWord4.Show();
                    _StackButtonClick.Remove(_StackButtonClick[_StackButtonClick.Count - 1]);
                }
                else if (_lastButtonClick == 5)
                {
                    btWord5.Show();
                    _StackButtonClick.Remove(_StackButtonClick[_StackButtonClick.Count - 1]);
                }
                else if (_lastButtonClick == 6)
                {
                    btWord6.Show();
                    _StackButtonClick.Remove(_StackButtonClick[_StackButtonClick.Count - 1]);
                }
                else if (_lastButtonClick == 7)
                {
                    btWord7.Show();
                    _StackButtonClick.Remove(_StackButtonClick[_StackButtonClick.Count - 1]);
                }
                else if (_lastButtonClick == 8)
                {
                    btWord8.Show();
                    _StackButtonClick.Remove(_StackButtonClick[_StackButtonClick.Count - 1]);
                }
                else if (_lastButtonClick == 9)
                {
                    btWord9.Show();
                    _StackButtonClick.Remove(_StackButtonClick[_StackButtonClick.Count - 1]);
                }
                else if (_lastButtonClick == 10)
                {
                    btWord10.Show();
                    _StackButtonClick.Remove(_StackButtonClick[_StackButtonClick.Count - 1]);
                }
            }
            _lastButtonClick = 0;
            TextRemove();
        }

        private void propSound(object sender, EventArgs e)
        {
            popSound.Play();

        }
        private void btSwitchAlphabet_MouseEnter(object sender, EventArgs e)
        {
            popSound.Play();

        }
    }
}
