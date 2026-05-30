using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal
{
    public partial class frmContact : Form
    {
        public frmContact()
        {
            InitializeComponent();
            txtName.BackColor =btnCancel.BackColor= txtEmail.BackColor = txtMessage.BackColor = Color.FromArgb(7, 20, 36);
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            btnSend.Image = new Bitmap(Image.FromFile(@"images/gmail.png"),new Size(24,24));
            btnCancel.Image = new Bitmap(Image.FromFile(@"images/false.png"),new Size(24,24));

        }

      

        private void frmContact_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.Cursor = Cursors.Hand;
        }

        private void btnSend_MouseEnter(object sender, EventArgs e)
        {
            btnSend.Cursor = Cursors.Hand;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }
       private bool HaveSympol(String Email)
        {

            if (string.IsNullOrWhiteSpace(Email))
                return false;

            return Email.Contains("@") && Email.Contains("gmail") && Email.Contains(".com");

        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {

                if(MessageBox.Show("Please Enter The Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)== DialogResult.OK)
                    {
                    txtName.Clear();
                    txtName.Focus();

                    }
                    
                    
            }
            if (!HaveSympol(txtEmail.Text) )
            {

                if(MessageBox.Show("Email must be *****@gmail.com", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    txtEmail.Clear();
                    txtEmail.Focus();
                }
            }

            if (string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                if (MessageBox.Show("Please Enter The Message", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    txtMessage.Clear();
                    txtMessage.Focus();

                }
            }


            if(!string.IsNullOrWhiteSpace(txtMessage.Text)&& !string.IsNullOrWhiteSpace(txtName.Text)&& !string.IsNullOrWhiteSpace(txtEmail.Text))
            {

                if(MessageBox.Show("Are you sure to send this message", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    MessageBox.Show("Message send is Successfully", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                txtEmail.Clear();
                txtName.Clear();
                txtMessage.Clear();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }

    }

