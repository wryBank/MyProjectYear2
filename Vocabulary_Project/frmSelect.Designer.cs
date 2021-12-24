namespace Vocabulary_Project
{
    partial class frmSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelect));
            this.pbLearnIcon = new System.Windows.Forms.PictureBox();
            this.pbTestIcon = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbNewV = new System.Windows.Forms.PictureBox();
            this.lbAddV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLearnIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewV)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLearnIcon
            // 
            this.pbLearnIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbLearnIcon.Image")));
            this.pbLearnIcon.Location = new System.Drawing.Point(70, 148);
            this.pbLearnIcon.Name = "pbLearnIcon";
            this.pbLearnIcon.Size = new System.Drawing.Size(159, 153);
            this.pbLearnIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLearnIcon.TabIndex = 0;
            this.pbLearnIcon.TabStop = false;
            this.pbLearnIcon.Click += new System.EventHandler(this.pbLearnIcon_Click);
            // 
            // pbTestIcon
            // 
            this.pbTestIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbTestIcon.Image")));
            this.pbTestIcon.Location = new System.Drawing.Point(551, 148);
            this.pbTestIcon.Name = "pbTestIcon";
            this.pbTestIcon.Size = new System.Drawing.Size(159, 153);
            this.pbTestIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTestIcon.TabIndex = 2;
            this.pbTestIcon.TabStop = false;
            this.pbTestIcon.Click += new System.EventHandler(this.pbTestIcon_Click);
            // 
            // pbExit
            // 
            this.pbExit.BackColor = System.Drawing.SystemColors.Control;
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(739, 28);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(34, 34);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 3;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // pbNewV
            // 
            this.pbNewV.Image = ((System.Drawing.Image)(resources.GetObject("pbNewV.Image")));
            this.pbNewV.Location = new System.Drawing.Point(312, 148);
            this.pbNewV.Name = "pbNewV";
            this.pbNewV.Size = new System.Drawing.Size(159, 153);
            this.pbNewV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNewV.TabIndex = 4;
            this.pbNewV.TabStop = false;
            this.pbNewV.Click += new System.EventHandler(this.pbNewV_Click);
            // 
            // lbAddV
            // 
            this.lbAddV.AutoSize = true;
            this.lbAddV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(63)))), ((int)(((byte)(40)))));
            this.lbAddV.Font = new System.Drawing.Font("Kanit", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAddV.ForeColor = System.Drawing.Color.White;
            this.lbAddV.Location = new System.Drawing.Point(312, 336);
            this.lbAddV.Name = "lbAddV";
            this.lbAddV.Size = new System.Drawing.Size(175, 33);
            this.lbAddV.TabIndex = 5;
            this.lbAddV.Text = "Add Vocabulary";
            // 
            // frmSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.lbAddV);
            this.Controls.Add(this.pbNewV);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbTestIcon);
            this.Controls.Add(this.pbLearnIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSelect";
            this.Load += new System.EventHandler(this.frmSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLearnIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLearnIcon;
        private System.Windows.Forms.PictureBox pbTestIcon;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbNewV;
        private System.Windows.Forms.Label lbAddV;
    }
}