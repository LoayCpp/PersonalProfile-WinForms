namespace Personal
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSoft = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAboutMe = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.picGithub = new System.Windows.Forms.PictureBox();
            this.PicLinkedIn = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGithub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLinkedIn)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(290, 72);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(208, 45);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Luai Alarify";
            // 
            // lblSoft
            // 
            this.lblSoft.AutoSize = true;
            this.lblSoft.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoft.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSoft.Location = new System.Drawing.Point(305, 118);
            this.lblSoft.Name = "lblSoft";
            this.lblSoft.Size = new System.Drawing.Size(168, 25);
            this.lblSoft.TabIndex = 2;
            this.lblSoft.Text = "Software Engineer";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.Color.Black;
            this.lblCode.Location = new System.Drawing.Point(291, 199);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(206, 20);
            this.lblCode.TabIndex = 3;
            this.lblCode.Text = "\"Code. Learn. Build. Repeat.\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(287, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "----------------◉----------------";
            // 
            // btnAboutMe
            // 
            this.btnAboutMe.BackColor = System.Drawing.Color.LightCyan;
            this.btnAboutMe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutMe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutMe.Location = new System.Drawing.Point(48, 265);
            this.btnAboutMe.Name = "btnAboutMe";
            this.btnAboutMe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAboutMe.Size = new System.Drawing.Size(152, 53);
            this.btnAboutMe.TabIndex = 5;
            this.btnAboutMe.Text = "About ME";
            this.btnAboutMe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAboutMe.UseVisualStyleBackColor = false;
            this.btnAboutMe.Click += new System.EventHandler(this.btnAboutMe_Click);
            // 
            // btnContact
            // 
            this.btnContact.BackColor = System.Drawing.Color.LightGreen;
            this.btnContact.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContact.Location = new System.Drawing.Point(248, 265);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(152, 53);
            this.btnContact.TabIndex = 6;
            this.btnContact.Text = "Contact";
            this.btnContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContact.UseVisualStyleBackColor = false;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(448, 265);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 53);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(166, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "----------------  Connect with me  ----------------";
            // 
            // picGithub
            // 
            this.picGithub.Image = ((System.Drawing.Image)(resources.GetObject("picGithub.Image")));
            this.picGithub.Location = new System.Drawing.Point(137, 380);
            this.picGithub.Name = "picGithub";
            this.picGithub.Size = new System.Drawing.Size(63, 54);
            this.picGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGithub.TabIndex = 9;
            this.picGithub.TabStop = false;
            this.picGithub.Click += new System.EventHandler(this.picGithub_Click);
            this.picGithub.MouseEnter += new System.EventHandler(this.Cursors_Hand);
            // 
            // PicLinkedIn
            // 
            this.PicLinkedIn.Image = ((System.Drawing.Image)(resources.GetObject("PicLinkedIn.Image")));
            this.PicLinkedIn.Location = new System.Drawing.Point(383, 380);
            this.PicLinkedIn.Name = "PicLinkedIn";
            this.PicLinkedIn.Size = new System.Drawing.Size(90, 54);
            this.PicLinkedIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLinkedIn.TabIndex = 10;
            this.PicLinkedIn.TabStop = false;
            this.PicLinkedIn.Click += new System.EventHandler(this.PicLinkedIn_Click);
            this.PicLinkedIn.MouseEnter += new System.EventHandler(this.Cursors_Hand);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(166, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "© 2026 Luai Al-Arify. All Rights Reserved.";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(613, 521);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PicLinkedIn);
            this.Controls.Add(this.picGithub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.btnAboutMe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblSoft);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGithub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLinkedIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSoft;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAboutMe;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picGithub;
        private System.Windows.Forms.PictureBox PicLinkedIn;
        private System.Windows.Forms.Label label3;
    }
}

