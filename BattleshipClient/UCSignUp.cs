using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleshipClient
{
    public partial class UCSignUp : UserControl
    {
        public UCSignUp()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Clear();
            FormMain.Instance.OpenUCLogin();
        }

        public void Clear()
        {
            lblUsername.ForeColor = Color.Black;
            lblPassword.ForeColor = Color.Black;
            lblConfirmPassword.ForeColor = Color.Black;
            lblFullName.ForeColor = Color.Black;
            txtConfirmPassword.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtNote.Text = string.Empty;
            dtpDOB.Value = DateTime.Now;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            if (username == string.Empty || username.IndexOf(" ") != -1) lblUsername.ForeColor = Color.Red;

            string password = txtPassword.Text;
            if (password == string.Empty) lblPassword.ForeColor = Color.Red;

            string cf_password = txtConfirmPassword.Text;
            if (cf_password != password || cf_password == string.Empty) lblConfirmPassword.ForeColor = Color.Red;

            string fullname = txtFullName.Text;
            if (fullname == string.Empty) lblFullName.ForeColor = Color.Red;

            string dob = dtpDOB.Text;
            string note = txtNote.Text;

            if (username.IndexOf(" ") != -1 || username == string.Empty || password == string.Empty || cf_password != password || cf_password == string.Empty || fullname == string.Empty)
            {
            }
            else
            {
                lblUsername.ForeColor = Color.Black;
                lblPassword.ForeColor = Color.Black;
                lblConfirmPassword.ForeColor = Color.Black;
                lblFullName.ForeColor = Color.Black;

                string encrypt;

                if (cbxEncypt.Checked)
                {
                    username = Encrypt.StringToHex(username);
                    password = Encrypt.StringToHex(password);
                    encrypt = "1";
                }
                else
                {
                    encrypt = "0";
                }

                string request = $"signup\0{encrypt}\0{username}\0{password}\0{fullname}\0{dob}\0{note}";
                FormMain.Instance.SendRequest(request);
            }
        }
    }
}
