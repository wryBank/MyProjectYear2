namespace Vocabulary_Project
{
    partial class CustomMSB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMSB));
            this.pbYes = new System.Windows.Forms.PictureBox();
            this.pbNo = new System.Windows.Forms.PictureBox();
            this.lbText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbYes
            // 
            this.pbYes.Image = ((System.Drawing.Image)(resources.GetObject("pbYes.Image")));
            this.pbYes.Location = new System.Drawing.Point(34, 127);
            this.pbYes.Name = "pbYes";
            this.pbYes.Size = new System.Drawing.Size(100, 50);
            this.pbYes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbYes.TabIndex = 0;
            this.pbYes.TabStop = false;
            this.pbYes.Click += new System.EventHandler(this.pbYes_Click);
            this.pbYes.MouseEnter += new System.EventHandler(this.pbYes_MouseEnter);
            // 
            // pbNo
            // 
            this.pbNo.Image = ((System.Drawing.Image)(resources.GetObject("pbNo.Image")));
            this.pbNo.Location = new System.Drawing.Point(171, 127);
            this.pbNo.Name = "pbNo";
            this.pbNo.Size = new System.Drawing.Size(100, 50);
            this.pbNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNo.TabIndex = 1;
            this.pbNo.TabStop = false;
            this.pbNo.Click += new System.EventHandler(this.pbNo_Click);
            this.pbNo.MouseEnter += new System.EventHandler(this.pbNo_MouseEnter);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(63)))), ((int)(((byte)(40)))));
            this.lbText.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbText.ForeColor = System.Drawing.Color.White;
            this.lbText.Location = new System.Drawing.Point(34, 45);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(0, 25);
            this.lbText.TabIndex = 2;
            // 
            // CustomMSB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.pbNo);
            this.Controls.Add(this.pbYes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMSB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMSB";
            this.Load += new System.EventHandler(this.CustomMSB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbYes;
        private System.Windows.Forms.PictureBox pbNo;
        private System.Windows.Forms.Label lbText;
    }
}