namespace Vocabulary_Project
{
    partial class frmLearn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLearn));
            this.pbPic = new System.Windows.Forms.PictureBox();
            this.pbNextButton = new System.Windows.Forms.PictureBox();
            this.lbVocabulary = new System.Windows.Forms.Label();
            this.pbBackButton = new System.Windows.Forms.PictureBox();
            this.pbExitButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNextButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPic
            // 
            this.pbPic.Location = new System.Drawing.Point(263, 70);
            this.pbPic.Name = "pbPic";
            this.pbPic.Size = new System.Drawing.Size(570, 367);
            this.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPic.TabIndex = 0;
            this.pbPic.TabStop = false;
            // 
            // pbNextButton
            // 
            this.pbNextButton.Image = ((System.Drawing.Image)(resources.GetObject("pbNextButton.Image")));
            this.pbNextButton.Location = new System.Drawing.Point(892, 604);
            this.pbNextButton.Name = "pbNextButton";
            this.pbNextButton.Size = new System.Drawing.Size(150, 64);
            this.pbNextButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbNextButton.TabIndex = 1;
            this.pbNextButton.TabStop = false;
            this.pbNextButton.Click += new System.EventHandler(this.pbNextButton_Click);
            this.pbNextButton.MouseEnter += new System.EventHandler(this.pbNextButton_MouseEnter);
            // 
            // lbVocabulary
            // 
            this.lbVocabulary.AutoSize = true;
            this.lbVocabulary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(63)))), ((int)(((byte)(40)))));
            this.lbVocabulary.Font = new System.Drawing.Font("Kanit", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbVocabulary.ForeColor = System.Drawing.Color.White;
            this.lbVocabulary.Location = new System.Drawing.Point(432, 468);
            this.lbVocabulary.Name = "lbVocabulary";
            this.lbVocabulary.Size = new System.Drawing.Size(216, 102);
            this.lbVocabulary.TabIndex = 2;
            this.lbVocabulary.Text = "label1";
            // 
            // pbBackButton
            // 
            this.pbBackButton.Image = ((System.Drawing.Image)(resources.GetObject("pbBackButton.Image")));
            this.pbBackButton.Location = new System.Drawing.Point(736, 604);
            this.pbBackButton.Name = "pbBackButton";
            this.pbBackButton.Size = new System.Drawing.Size(150, 64);
            this.pbBackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBackButton.TabIndex = 3;
            this.pbBackButton.TabStop = false;
            this.pbBackButton.Click += new System.EventHandler(this.pbBackButton_Click);
            this.pbBackButton.MouseEnter += new System.EventHandler(this.pbNextButton_MouseEnter);
            // 
            // pbExitButton
            // 
            this.pbExitButton.Image = ((System.Drawing.Image)(resources.GetObject("pbExitButton.Image")));
            this.pbExitButton.Location = new System.Drawing.Point(1024, 46);
            this.pbExitButton.Name = "pbExitButton";
            this.pbExitButton.Size = new System.Drawing.Size(30, 30);
            this.pbExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExitButton.TabIndex = 4;
            this.pbExitButton.TabStop = false;
            this.pbExitButton.Click += new System.EventHandler(this.pbExitButton_Click);
            // 
            // frmLearn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1093, 726);
            this.Controls.Add(this.pbExitButton);
            this.Controls.Add(this.pbBackButton);
            this.Controls.Add(this.lbVocabulary);
            this.Controls.Add(this.pbNextButton);
            this.Controls.Add(this.pbPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLearn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLearn";
            this.Load += new System.EventHandler(this.frmLearn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNextButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPic;
        private System.Windows.Forms.PictureBox pbNextButton;
        private System.Windows.Forms.Label lbVocabulary;
        private System.Windows.Forms.PictureBox pbBackButton;
        private System.Windows.Forms.PictureBox pbExitButton;
    }
}