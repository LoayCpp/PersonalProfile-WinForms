using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;

            btnAboutMe.Image = new Bitmap(
      Image.FromFile(@"images/information.png"),
      new Size(24, 24));
            btnContact.Image = new Bitmap(Image.FromFile(@"images/whatsapp.png"), new Size(24, 24));
            btnExit.Image = new Bitmap(Image.FromFile(@"images/Power.png"), new Size(24, 24));
            btnContact.BackColor = Color.FromArgb(218, 238, 221);
            btnExit.BackColor = Color.FromArgb(243, 219, 219);


        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        private void Contact_WithLink(string Link)
        {

            Process.Start(new ProcessStartInfo { FileName = Link, UseShellExecute = true });


        }
        private void picGithub_Click(object sender, EventArgs e)
        {
            Contact_WithLink("https://github.com/LoayCpp");
        }

      
        private void PicLinkedIn_Click(object sender, EventArgs e)
        {
            Contact_WithLink("https://www.linkedin.com/in/luai-anwar");

        }

       
       private void Cursors_Hand(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Cursor = Cursors.Hand;

        }

        private void btnAboutMe_Click(object sender, EventArgs e)
        {
            Form frmAbout = new frmAboutMe();
            frmAbout.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            Form frmContact = new frmContact();
            frmContact.ShowDialog();
        

    }
    }
}
