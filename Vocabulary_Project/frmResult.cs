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
                calScore(score);
            
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
            this.score  = (score / allVocabulary) * 100;
            int star;
            if(score > 100)
            {
                star = 5;
            }
            else if(score > 80)
            {
                star = 4;
            }
            else if(score > 60)
            {
                star = 3;
            }
            else if(score > 40)
            {
                star = 2;
            }
            else if(score >0)
            {
                star = 1;
            }
            else
            {
                star = 0;
            }
            showStar(star);
            
        }
        private void pbExit_Click(object sender, EventArgs e)
        {
            CustomMSB MSB = new CustomMSB();
            MSB.MSG_EXIT();
        }

    }
}
