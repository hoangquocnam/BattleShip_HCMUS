using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleshipClient
{
    public partial class UCProfile : UserControl
    {
        private ClientInfo profile = new ClientInfo();

        public UCProfile()
        {
            InitializeComponent();
        }

        public void SetProfile(ClientInfo cli)
        {
            profile = cli;
            txtUsername.Text = cli.Username;
            txtFullName.Text = cli.FullName;
            string[] dob = cli.DateOfBirth.Split('/');
            dtpDOB.Value = DateTime.ParseExact(cli.DateOfBirth, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            txtNote.Text = cli.Note;
            txtPoint.Text = cli.Point.ToString();
        }

        public void ChangePassword(bool isChange, string fail)
        {
            if (!isChange) MessageBox.Show(fail, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else btnCancel2.PerformClick();
        }

        private void btnChangeSave1_Click(object sender, EventArgs e)
        {
            if (btnChangeSave1.Text == "Change")
            {
                btnCancel1.Enabled = true;
                btnCancel1.BackColor = Color.Salmon;
                txtFullName.Enabled = true;
                dtpDOB.Enabled = true;
                txtNote.Enabled = true;
                btnChangeSave1.Text = "Save";
                btnChangeSave1.BackColor = Color.PaleGreen;
            }
            else
            {
                profile.FullName = txtFullName.Text;
                profile.DateOfBirth = dtpDOB.Text;
                profile.Note = txtNote.Text;
                FormMain.Instance.UpdateClientInfo(profile);
                FormMain.Instance.SendRequest($"setup_info\0{profile.FullName}\0{profile.DateOfBirth}\0{profile.Note}\0{profile.Point}");
                btnCancel1.PerformClick();
            }
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            SetProfile(profile);
            btnCancel1.BackColor = Color.Gray;
            btnCancel1.Enabled = false;
            txtFullName.Enabled = false;
            dtpDOB.Enabled = false;
            txtNote.Enabled = false;
            btnChangeSave1.Text = "Change";
            btnChangeSave1.BackColor = Color.Beige;
        }

        private void btnChangeSave2_Click(object sender, EventArgs e)
        {
            if (btnChangeSave2.Text == "Change")
            {
                btnCancel2.Enabled = true;
                btnCancel2.BackColor = Color.Salmon;
                txtCurrentPassword.Enabled = true;
                txtNewPassword.Enabled = true;
                txtConfirmNewPassword.Enabled = true;
                btnChangeSave2.Text = "Save";
                btnChangeSave2.BackColor = Color.PaleGreen;
            }
            else
            {
                if (txtCurrentPassword.Text == string.Empty || txtNewPassword.Text == string.Empty || txtConfirmNewPassword.Text != txtNewPassword.Text || txtConfirmNewPassword.Text == string.Empty)
                {
                    MessageBox.Show("Change Password Fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (cbxEncrypt.Checked)
                    {
                        FormMain.Instance.SendRequest($"changepassword\01\0{Encrypt.StringToHex(txtCurrentPassword.Text)}\0{Encrypt.StringToHex(txtNewPassword.Text)}");
                    }
                    else
                    {
                        FormMain.Instance.SendRequest($"changepassword\00\0{txtCurrentPassword.Text}\0{txtNewPassword.Text}");
                    }

                }

            }
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            btnCancel2.BackColor = Color.Gray;
            btnCancel2.Enabled = false;
            txtConfirmNewPassword.Text = string.Empty;
            txtNewPassword.Text = string.Empty;
            txtCurrentPassword.Text = string.Empty;
            txtCurrentPassword.Enabled = false;
            txtNewPassword.Enabled = false;
            txtConfirmNewPassword.Enabled = false;
            btnChangeSave2.Text = "Change";
            btnChangeSave2.BackColor = Color.Beige;
        }

        public void Clear(object sender, EventArgs e)
        {
            btnCancel1_Click(sender, e);
            btnCancel2_Click(sender, e);
        }
    }
}
