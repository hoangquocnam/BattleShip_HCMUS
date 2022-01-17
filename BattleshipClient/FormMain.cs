using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace BattleshipClient
{
    public partial class FormMain : Form
    {
        #region region define variables

        private Client client = new Client();
        private bool isDipose = false;
        private Button currentButton;

        private static FormMain _instance;
        public static FormMain Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormMain();
                }

                return _instance;
            }
        }

        #endregion

        #region region define user control

        private UserControl currentUC;
        private UCDashboard ucDashboard = new UCDashboard();
        private UCProfile ucProfile = new UCProfile();
        private UCSearch ucSearch = new UCSearch();
        private UCLogin ucLogin = new UCLogin();
        private UCSignUp ucSignUp = new UCSignUp();

        #endregion

        #region region constructor

        public FormMain()
        {
            InitializeComponent();
            _instance = this;

            panelContainer.Controls.Add(ucDashboard);
            panelContainer.Controls.Add(ucProfile);
            panelContainer.Controls.Add(ucSearch);
            panelContainer.Controls.Add(ucLogin);
            panelContainer.Controls.Add(ucSignUp);

            ucDashboard.Hide();
            ucProfile.Hide();
            ucSearch.Hide();
            ucSignUp.Hide();

            currentUC = ucLogin;
        }

        #endregion

        #region region handle socket

        public void Connect(IPAddress ip, int port)
        {
            client.socket.Connect(ip, port);
            client.socket.BeginReceive(client.buffers, 0, client.buffers.Length, SocketFlags.None, ReceiveCallback, null);
        }

        private void ReceiveCallback(IAsyncResult result)
        {
            try
            {
                int packetSize = client.socket.EndReceive(result);

                if (packetSize != 0)
                {
                    byte[] packet = new byte[packetSize];
                    Array.Copy(client.buffers, packet, packet.Length);

                    client.sb.Append(Encoding.UTF8.GetString(packet));

                    string s = client.sb.ToString();

                    // đã nhận đủ gói tin
                    while (s.IndexOf("<EOF>") != -1)
                    {
                        string response = s.Substring(0, s.IndexOf("<EOF>"));
                        s = s.Substring(s.IndexOf("<EOF>") + 5);

                        if (response == "exit")
                        {
                            MessageBox.Show("Server is offline. Disconnected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Exit();
                            return;
                        }

                        ProcessPacket(response);
                    }

                    client.sb.Clear();
                    client.sb.Append(s);
                    client.socket.BeginReceive(client.buffers, 0, client.buffers.Length, SocketFlags.None, ReceiveCallback, client);
                }
            }
            catch (Exception)
            {
                if (!isDipose)
                {
                    // server forcibly exit
                    MessageBox.Show("Server is offline. Disconnected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Exit();
                }
            }
        }

        private void Exit()
        {
            isDipose = true;
            if (client.socket.Connected)
                client.socket.Shutdown(SocketShutdown.Both);
            client.socket.Close();
            Application.Exit();
        }

        public void SendRequest(string request)
        {
            client.socket.Send(Encoding.UTF8.GetBytes(request + "<EOF>"));
        }

        #endregion

        #region region handle packet

        public FormPlaying playMain;

        private delegate void ProcessPacketDelegate(string response);
        private void ProcessPacket(string response)
        {
            if (InvokeRequired)
            {
                Invoke(new ProcessPacketDelegate(ProcessPacket), new object[] { response });
                return;
            }

            string[] tokens = response.Split('\0');

            switch (tokens[0])
            {
                case "login":
                    HandleLoginResponse(tokens);
                    break;

                case "signup":
                    HandleSignUpResponse(tokens);
                    break;

                case "changepassword":
                    HandleChangePasswordResponse(tokens);
                    break;

                case "search":
                    HandleSearchResponse(tokens);
                    break;

                case "online":
                    HandleOnlineResponse(tokens);
                    break;

                case "offline":
                    HandleOfflineResponse(tokens);
                    break;

                case "invite":
                    HandleInviteRequest(tokens);
                    break;

                case "game":
                    HandleGamingRequest(tokens);
                    break;

                case "chat":
                    ucDashboard.AddLog(tokens[1]);
                    break;

            }
        }

        private void HandleLoginResponse(string[] tokens)
        {
            if (tokens[1] == "1")
            {
                if (tokens[2] == "1")
                    client.info = new ClientInfo(Encrypt.HexToString(tokens[3]), tokens[4], tokens[5], tokens[6], Convert.ToInt32(tokens[7]));
                else
                    client.info = new ClientInfo(tokens[3], tokens[4], tokens[5], tokens[6], Convert.ToInt32(tokens[7]));
                lblUsername.Text = $"Hi, {client.info.Username}";
                ucProfile.SetProfile(client.info);
                btnLogin.Text = "  Log out";
                btnLogin.Image = Properties.Resources.Logout;
                ucLogin.Clear();
                btnSearch.Visible = true;
                btnProfile.Visible = true;
                btnDashboard.Visible = true;
                OpenUCDashboard();
                ucDashboard.AddLog("Logged in successfully", Color.Green);
                ucDashboard.AddLog("Welcome to Battleship", Color.MidnightBlue);
            }
            else
            {
                MessageBox.Show(tokens[2], "Failed to logged in", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleLogoutResponse()
        {
            SendRequest("logout");
            lblUsername.Text = "";
            client.Clear();
            btnLogin.Text = "  Login";
            btnLogin.Image = Properties.Resources.Login;
            OpenUCLogin();
            ucSearch.Clear();
            ucDashboard.Clear();
        }

        private void HandleSignUpResponse(string[] tokens)
        {
            if (tokens[1] == "1")
            {
                MessageBox.Show("Sign up successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucSignUp.Clear();
                OpenUCLogin();
            }
            else
            {
                MessageBox.Show("This username is already used to sign up.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleChangePasswordResponse(string[] tokens)
        {
            if (tokens[1] == "0")
            {
                ucProfile.ChangePassword(false, tokens[2]);
            }
            else
            {
                ucProfile.ChangePassword(true, "");
                HandleLogoutResponse();
            }
        }

        private void HandleSearchResponse(string[] tokens)
        {
            if (tokens[1] == "1")
            {
                ucSearch.SetProfile(tokens[2], tokens[3], tokens[4], tokens[5], tokens[6]);
            }
            else
            {
                MessageBox.Show("The username is not exist");
            }
        }

        private void HandleOnlineResponse(string[] tokens)
        {
            for (int i = 1; i < tokens.Length; ++i)
            {
                ucDashboard.AddToList(tokens[i]);
            }
        }

        private void HandleOfflineResponse(string[] tokens)
        {
            ucDashboard.RemoveFromList(tokens[1]);
        }

        // update lúc profile thay đổi
        public void UpdateClientInfo(ClientInfo info)
        {
            client.info = info;
        }

        public void HandleInviteRequest(string[] tokens)
        {
            switch (tokens[1])
            {
                case "quest":
                    DialogResult dlr = MessageBox.Show(new Form { TopMost = true }, $"{tokens[2]} has invited you to play", "Invite", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dlr == DialogResult.Yes)
                    {
                        SendRequest($"invite\01\0{client.info.Username}\0{tokens[2]}");
                    }
                    else SendRequest($"invite\00\0{client.info.Username}\0{tokens[2]}");
                    break;

                case "ingame":
                    ucDashboard.isInvite = false;
                    MessageBox.Show($"{tokens[3]} is in game now.", "Denide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case "1":
                    this.Hide();
                    playMain = new FormPlaying(client.info.Username, tokens[2], tokens[4]);
                    playMain.Show();
                    break;

                case "0":
                    ucDashboard.isInvite = false;
                    MessageBox.Show($"{tokens[2]} have refused your invitation", "Denide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

            }
        }

        private void HandleGamingRequest(string[] tokens)
        {
            switch (tokens[1])
            {
                case "ready":
                    playMain.Ready(false);
                    break;

                case "turn":
                    if (tokens[2] == "1") playMain.Turn(true);
                    else playMain.Turn(false);
                    break;

                case "clicked":
                    playMain.Clicked(tokens[2], tokens[3], tokens[4]);
                    break;

                case "hit":
                    playMain.Hit(tokens[2], tokens[3]);
                    break;

                case "win":
                    playMain.Stop(true, tokens);
                    client.info.Point++;
                    ucProfile.SetProfile(client.info);
                    break;

                case "lose":
                    playMain.Stop(false, tokens);
                    break;

                case "chat":
                    playMain.AddLog(tokens[2]);
                    break;

                case "end":
                    playMain.EndGame(tokens);
                    this.Show();
                    ucDashboard.isInvite = false;
                    break;
            }
        }
        #endregion

        #region region handle button

        public void ActivateCurrentButtonNav(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableOtherButtonNav();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.SlateGray;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableOtherButtonNav()
        {
            foreach (Control ctrl in panelNav.Controls)
            {
                if (ctrl.GetType() == typeof(Button))
                {
                    ctrl.BackColor = Color.FromArgb(40, 46, 52);
                    ctrl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        #endregion

        #region region handle user control

        public void ShowUC(UserControl uc)
        {
            if (currentUC.Equals(uc))
                return;

            if (uc is UCDashboard)
                ucDashboard.BringToFront();
            else if (uc is UCProfile)
                ucProfile.BringToFront();
            else if (uc is UCSearch)
                ucSearch.BringToFront();
            else if (uc is UCLogin)
                ucLogin.BringToFront();
            else
                ucSignUp.BringToFront();

            uc.Show();
            currentUC.Hide();
            currentUC = uc;
        }

        public void OpenUCDashboard()
        {
            ActivateCurrentButtonNav(btnDashboard);
            ShowUC(ucDashboard);
            lblHeader.Text = "Dashboard";
        }

        public void OpenUCProfile()
        {
            ActivateCurrentButtonNav(btnProfile);
            ShowUC(ucProfile);
            lblHeader.Text = "Profile";
        }

        public void OpenUCSearch()
        {
            ActivateCurrentButtonNav(btnSearch);
            ShowUC(ucSearch);
            lblHeader.Text = "Search";
        }

        public void OpenUCLogin()
        {
            ActivateCurrentButtonNav(btnLogin);
            ShowUC(ucLogin);
            lblHeader.Text = "Login";
            btnProfile.Visible = false;
            btnDashboard.Visible = false;
            btnSearch.Visible = false;
            lblUsername.Text = "";
        }

        public void OpenUCSignUp()
        {
            ActivateCurrentButtonNav(btnLogin);
            ShowUC(ucSignUp);
            lblHeader.Text = "Sign Up";
        }

        #endregion

        #region region handle event

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormConnect connectForm = new FormConnect();
            connectForm.ShowDialog();
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
            SendRequest("exit");
            Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ucProfile.Clear(sender, e);
            ucSearch.Clear(); 
            OpenUCDashboard();

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ucSearch.Clear();
            OpenUCProfile();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ucProfile.Clear(sender, e);
            OpenUCSearch();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (client.info == null)
            {
                OpenUCLogin();
            }
            else
            {
                HandleLogoutResponse();
            }
        }

        #endregion
    }
}
