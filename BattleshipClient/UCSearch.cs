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
    public partial class UCSearch : UserControl
    {
        public UCSearch()
        {
            InitializeComponent();
        }
        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        private void UCSearch_Load(object sender, EventArgs e)
        {
            cbxSearchField.SelectedIndex = 0;
        }

        public void SetProfile(string fullName, string dob, string status, string point, string note)
        {
            txtFullName.Text = fullName;
            txtDOB.Text = dob;
            txtStatus.Text = status;
            txtPoint.Text = point;
            txtNote.Text = note;
        }

        public void Clear()
        {
            txtFullName.Text = string.Empty;
            txtDOB.Text = string.Empty;
            txtNote.Text = string.Empty;
            txtStatus.Text = string.Empty;
            txtPoint.Text = string.Empty;
            txtUsername.Text = string.Empty;
            cbxSearchField.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
            {
                if (cbxSearchField.Text == "All")
                {
                    FormMain.Instance.SendRequest($"search\0{txtUsername.Text}\0all");
                }
                else if (cbxSearchField.Text == "Full Name")
                {
                    FormMain.Instance.SendRequest($"search\0{txtUsername.Text}\0fullname");
                }
                else if (cbxSearchField.Text == "Date Of Birth")
                {
                    FormMain.Instance.SendRequest($"search\0{txtUsername.Text}\0dob");

                }
                else if (cbxSearchField.Text == "Note")
                {
                    FormMain.Instance.SendRequest($"search\0{txtUsername.Text}\0note");

                }
                else if (cbxSearchField.Text == "Point")
                {
                    FormMain.Instance.SendRequest($"search\0{txtUsername.Text}\0point");
                }
                else // status
                {
                    FormMain.Instance.SendRequest($"search\0{txtUsername.Text}\0status");
                }
            }
            else
            {
                txtFullName.Text = string.Empty;
                txtDOB.Text = string.Empty;
                txtNote.Text = string.Empty;
                txtStatus.Text = string.Empty;
                txtPoint.Text = string.Empty;
            }
        }
    }
}
