using System;
using System.Windows.Forms;
using System.Net;
using System.Runtime.InteropServices;

namespace BattleshipClient
{
    public partial class FormConnect : Form
    {
        public FormConnect()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            int port;
            if (!IPAddress.TryParse(txtIPAddress.Text, out ip))
            {

                try
                {
                    ip = Dns.GetHostAddresses(txtIPAddress.Text)[0];
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid IP Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIPAddress.Focus();
                    return;
                }
            }

            if (!int.TryParse(txtPort.Text, out port))
            {
                MessageBox.Show("Invalid port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPort.Focus();
                return;
            }

            try
            {
                FormMain.Instance.Connect(ip, port);
                Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Can't connect to the server!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConnectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void FormConnect_Load(object sender, EventArgs e)
        {
            btnConnect.Select();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

       
    }
}
