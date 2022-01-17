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
    public partial class UCDashboard : UserControl
    {
        public bool isInvite = false;
        public UCDashboard()
        {
            InitializeComponent();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(sender, e);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtLogs.SelectionStart = txtLogs.Text.Length;
            txtLogs.ScrollToCaret();
        }

        public void AddLog(string log)
        {
            txtLogs.AppendText($"[{DateTime.Now.ToShortTimeString()}] {log}{Environment.NewLine}");
        }

        public void AddLog(string log, Color foreground)
        {
            txtLogs.SelectionStart = txtLogs.TextLength;
            txtLogs.SelectionLength = 0;
            txtLogs.SelectionColor = foreground;
            txtLogs.AppendText($"[{DateTime.Now.ToShortTimeString()}] {log}{Environment.NewLine}");
            txtLogs.SelectionColor = txtLogs.ForeColor;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text != string.Empty)
            {
                AddLog($"You: {txtMessage.Text}");
                FormMain.Instance.SendRequest($"chat\0{txtMessage.Text}");
                txtMessage.Text = string.Empty;
            }
        }

        public void AddToList(string username)
        {
            lbxClients.Items.Add(username);
        }

        public void RemoveFromList(string username)
        {
            lbxClients.Items.Remove(username);
        }

        public void Clear()
        {
            txtLogs.Text = string.Empty;
            txtMessage.Text = string.Empty;
            lbxClients.Items.Clear();
        }

        private void btnInvite_Click(object sender, EventArgs e)
        {
            if (lbxClients.SelectedIndex != -1 && !isInvite)
            {
                FormMain.Instance.SendRequest($"invite\0username\0{lbxClients.SelectedItem.ToString()}");
                isInvite = true;
            }
        }

        private void lbxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnInvite.BackColor = Color.LightSkyBlue;
        }
    }
}
