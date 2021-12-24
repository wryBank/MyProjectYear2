namespace Vocabulary_Project
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.btBwors = new System.Windows.Forms.Button();
            this.pbInput = new System.Windows.Forms.PictureBox();
            this.btOK = new System.Windows.Forms.Button();
            this.tbVocabulary = new System.Windows.Forms.TextBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.btBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // btBwors
            // 
            this.btBwors.Image = ((System.Drawing.Image)(resources.GetObject("btBwors.Image")));
            this.btBwors.Location = new System.Drawing.Point(890, 383);
            this.btBwors.Name = "btBwors";
            this.btBwors.Size = new System.Drawing.Size(133, 54);
            this.btBwors.TabIndex = 0;
            this.btBwors.UseVisualStyleBackColor = true;
            this.btBwors.Click += new System.EventHandler(this.btBwors_Click);
            // 
            // pbInput
            // 
            this.pbInput.Location = new System.Drawing.Point(262, 70);
            this.pbInput.Name = "pbInput";
            this.pbInput.Size = new System.Drawing.Size(570, 367);
            this.pbInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInput.TabIndex = 1;
            this.pbInput.TabStop = false;
            // 
            // btOK
            // 
            this.btOK.Image = ((System.Drawing.Image)(resources.GetObject("btOK.Image")));
            this.btOK.Location = new System.Drawing.Point(890, 481);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(133, 57);
            this.btOK.TabIndex = 2;
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // tbVocabulary
            // 
            this.tbVocabulary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(41)))), ((int)(((byte)(26)))));
            this.tbVocabulary.Font = new System.Drawing.Font("Kanit", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbVocabulary.ForeColor = System.Drawing.Color.White;
            this.tbVocabulary.Location = new System.Drawing.Point(317, 475);
            this.tbVocabulary.Name = "tbVocabulary";
            this.tbVocabulary.Size = new System.Drawing.Size(468, 63);
            this.tbVocabulary.TabIndex = 3;
            // 
            // pbExit
            // 
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(1025, 45);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(30, 29);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 4;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // btBack
            // 
            this.btBack.Image = ((System.Drawing.Image)(resources.GetObject("btBack.Image")));
            this.btBack.Location = new System.Drawing.Point(890, 588);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(133, 57);
            this.btBack.TabIndex = 5;
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1093, 726);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.tbVocabulary);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.pbInput);
            this.Controls.Add(this.btBwors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBwors;
        private System.Windows.Forms.PictureBox pbInput;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox tbVocabulary;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Button btBack;
    }
}