using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BattleshipServer
{
    public partial class FormMain : Form
    {
        private static FormMain _instance;
        private Server server;

        public static FormMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FormMain();

                return _instance;
            }
        }
        public FormMain()
        {
            InitializeComponent();
            _instance = this;
            server = new Server();
        }

        #region Control Handler

        private delegate void AddLogDelegate(string log);
        public void AddLog(string log)
        {
            if (txtLogs.InvokeRequired)
            {
                txtLogs.Invoke(new AddLogDelegate(AddLog), log);
            }
            else
            {
                txtLogs.AppendText($"[{DateTime.Now.ToShortTimeString()}] {log}{Environment.NewLine}");
            }
        }

        private delegate void AddLogWithColorDelegate(string log, Color foreground);
        public void AddLog(string log, Color foreground)
        {
            if (txtLogs.InvokeRequired)
            {
                txtLogs.Invoke(new AddLogWithColorDelegate(AddLog), new object[] { log, foreground });
            }
            else
            {
                txtLogs.SelectionStart = txtLogs.TextLength;
                txtLogs.SelectionLength = 0;
                txtLogs.SelectionColor = foreground;
                txtLogs.AppendText($"[{DateTime.Now.ToShortTimeString()}] {log}{Environment.NewLine}");
                txtLogs.SelectionColor = txtLogs.ForeColor;
            }
        }

        private delegate void AddToListDelegate(string username);
        public void AddToList(string username)
        {
            if (lbxClients.InvokeRequired)
            {
                lbxClients.Invoke(new AddToListDelegate(AddToList), new object[] { username });
            }
            else
            {
                lbxClients.Items.Add(username);
            }
        }

        private delegate void RemoveFromListDelegate(string username);
        public void RemoveFromList(string username)
        {
            if (lbxClients.InvokeRequired)
            {
                lbxClients.Invoke(new RemoveFromListDelegate(RemoveFromList), new object[] { username });
            }
            else
            {
                lbxClients.Items.Remove(username);
            }
        }

        private delegate void ClearListDelegate();
        public void ClearList()
        {
            if (lbxClients.InvokeRequired)
            {
                lbxClients.Invoke(new ClearListDelegate(ClearList));
            }
            else
            {
                lbxClients.Items.Clear();
            }
        }

        #endregion

        #region Event Handler

        private void btnStart_Click(object sender, EventArgs e)
        {
            server.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            server.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            server.Stop();
        }

        // event kéo thả của panel header
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0x112, 0xf012, 0);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion
    }
}
