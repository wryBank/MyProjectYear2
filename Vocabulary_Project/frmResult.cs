using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Vocabulary_Project.Models;

namespace Vocabulary_Project
{
    public partial class frmResult : Form
    {
        public int score { get; set; }
        public int allVocabulary { get; set; }
        public Result userInfo { get; set; }
        public frmResult()
        {
            InitializeComponent();
        }
        public frmResult(int score,int allVocabulary)
        {
            InitializeComponent();
            this.score = score;
            this.allVocabulary = allVocabulary;
        }
        private void frmResult_Load(object sender, EventArgs e)
        {
            lbUsername.Text = frmLogin.Username;
                starIcon1.Hide();
                starIcon2.Hide();
                starIcon3.Hide();
                starIcon4.Hide();
                starIcon5.Hide();
                lbScore.Text = score.ToString() +" / " + allVocabulary.ToString();
                 score  = Convert.ToInt32(((float)score / allVocabulary) * 100f);
            MessageBox.Show("Score = " + score);
                calScore(Convert.ToInt32(score));
            
        }
        private void showStar(int star)
        {
            
            if(star == 5)
            {
                starIcon1.Show();
                starIcon2.Show();
                starIcon3.Show();
                starIcon4.Show();
                starIcon5.Show();
            }
            else if(star == 4)
            {
                starIcon1.Show();
                starIcon2.Show();
                starIcon3.Show();
                starIcon4.Show();
            }
            else if(star == 3)
            {
                starIcon1.Show();
                starIcon2.Show();
                starIcon3.Show();
            }
            else if(star == 2)
            {
                starIcon1.Show();
                starIcon2.Show();
            }
            else if(star == 1)
            {
                starIcon1.Show();
            }
            else
            {
                starIcon1.Hide();
                starIcon2.Hide();
                starIcon3.Hide();
                starIcon4.Hide();
                starIcon5.Hide();

            }
        }
        private void calScore(int score)
        {

            int star = 0;
            if(score <=0)
            {
                star = 0;
            }
            else if(score > 0 && score <=40)
            {
                star = 1;
            }
            else if(score >40 && score <=60)
            {
                star = 2;
            }
            else if(score >60 & score <=80)
            {
                star = 3;
            }
            else if(score >80 && score <=100)
            {
                star = 4;
            }
            else if(score >100)
            {
                star = 5;
            }
            MessageBox.Show("star" + star);
            showStar(star);
            
        }
        private void pbExit_Click(object sender, EventArgs e)
        {
            CustomMSB MSB = new CustomMSB();
            MSB.MSG_EXIT();
        }

    }
}
