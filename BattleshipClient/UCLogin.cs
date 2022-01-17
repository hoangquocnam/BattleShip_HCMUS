using System;
using System.Windows.Forms;

namespace BattleshipClient
{
    public partial class UCLogin : UserControl
    {
        public UCLogin()
        {
            InitializeComponent();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Clear();
            FormMain.Instance.OpenUCSignUp();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Username can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("Password can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }

            if (cbxEncypt.Checked)
            {
                FormMain.Instance.SendRequest($"login\0{Encrypt.StringToHex(txtUsername.Text)}\0{Encrypt.StringToHex(txtPassword.Text)}\01");
            }
            else
            {
                FormMain.Instance.SendRequest($"login\0{txtUsername.Text}\0{txtPassword.Text}\00");
            }
        }

        public void Clear()
        {
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
        }

      
    }
}
