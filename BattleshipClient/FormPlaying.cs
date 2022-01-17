using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Color = System.Drawing.Color;

namespace BattleshipClient
{
    public partial class FormPlaying : Form
    {
        public static StringBuilder[] grids = new StringBuilder[20];

        public FormPlaying(string Username1, string Username2, string roomID)
        {
            InitializeComponent();
            DrawPlayMap(pnlMain);
            txtPlayer1.Text = Username1;
            txtPlayer2.Text = Username2;
            lblRoomID.Text = roomID;
        }

        void GetGrid(string filename)
        {
            string[] temp = System.IO.File.ReadAllLines(filename);
            for (int i = 0; i < 20; i++)
            {
                grids[i] = new StringBuilder();
                grids[i].AppendLine(temp[i]);
            }
        }

        public void Fire_Click(object sender, EventArgs e)
        {
            MapCell btn = sender as MapCell;
            btn.BackgroundImage = BattleshipClient.Properties.Resources.Ammo;
            btn.Enabled = false;
            pnlMain.Enabled = false;
            CountDown(false);
            FormMain.Instance.SendRequest($"game\0{lblRoomID.Text}\0click\0{btn.Y - 1}\0{btn.X - 1}");
        }

        public void Ready(bool isReady)
        {
            if (isReady) pcReady1.Visible = true;
            else pcReady2.Visible = true;
        }

        public void Turn(bool turn)
        {
            CountDown(turn);
        }

        public void Clicked(string X, string Y, string status)
        {
            //X - Y
            Control btn = pnlSub.Controls.Find($"{X}-{Y}", true)[0];
            if (status == "0")
            {
                btn.BackgroundImage = BattleshipClient.Properties.Resources.x;
                Turn(true);
            }
            else
            {
                btn.BackgroundImage = BattleshipClient.Properties.Resources.Click;
                CountDown(false);
            }
        }

        public void Hit(string X, string Y)
        {
            //X - Y
            Control btn = pnlMain.Controls.Find($"{X}-{Y}", true)[0];
            btn.BackgroundImage = BattleshipClient.Properties.Resources.hit;
            Turn(true);
        }

        public void Stop(bool res, string[] tokens)
        {
            timer.Stop();
            ContinueGame(res, tokens);
            this.Hide();
        }

        private void ContinueGame(bool isWin, string[] tokens)
        {
            FormWinLose res = new FormWinLose(isWin, lblRoomID.Text, tokens[2]);
            res.ShowDialog();
        }

        public void EndGame(string[] tokens)
        {
            if (tokens[2] == "1") MessageBox.Show($"{txtPlayer2.Text} has leaved the room", "Battleship", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            this.Dispose();
        }

        #region region countdown
        private Timer timer = new Timer();

        private int counter;
        private void CountDown(bool turn)
        {
            counter = 10;
            timer.Dispose();
            timer = new Timer();
            timer.Tick += new EventHandler(Time_Tick);
            timer.Interval = 1000; // 1 second
            timer.Start();
            pnlMain.Enabled = turn;
            if (turn)
            {
                lblCountDown.BackColor = System.Drawing.Color.CornflowerBlue;
            }
            else lblCountDown.BackColor = System.Drawing.Color.Crimson;
            lblCountDown.Text = counter.ToString();
        }
        private void Time_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timer.Stop();
                pnlMain.Enabled = false;
                CountDown(false);
                FormMain.Instance.SendRequest($"game\0{lblRoomID.Text}\0timeout");
            }
            lblCountDown.Text = counter.ToString();
        }

        #endregion

        #region region button
        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string file_PathGrid = fd.FileName;

                if (!MapChecker.Check(file_PathGrid))
                {
                    MessageBox.Show("Invalid map", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                GetGrid(file_PathGrid);
                DrawMap.DrawSubGrid(pnlSub, grids);
                if (file_PathGrid != "")
                {
                    btnPlay.Enabled = true;
                    btnClear.Enabled = true;
                    btnUploadFile.Enabled = false;
                }
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Be sure to surrender?", "Surrender", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                FormMain.Instance.SendRequest($"game\0{lblRoomID.Text}\0surrender");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pnlSub.Controls.Clear();
            btnPlay.Enabled = false;
            btnClear.Enabled = false;
            btnUploadFile.Enabled = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnClear.Enabled = false;
            btnUploadFile.Enabled = false;
            string request = $"game\0{lblRoomID.Text}\0grid\0{txtPlayer1.Text}";
            for (int i = 0; i < 20; i++)
            {
                request += $"\0{grids[i]}";
            }
            btnPlay.Enabled = false;
            Ready(true);
            FormMain.Instance.SendRequest(request);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text != string.Empty)
            {
                AddLog($"You: {txtMessage.Text}");
                FormMain.Instance.SendRequest($"game\0{lblRoomID.Text}\0chat\0{txtMessage.Text}");
                txtMessage.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTutorial tutorial = new FormTutorial();
            tutorial.Show();
        }

        #endregion

        #region region support

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

        private void DrawPlayMap(Panel pnl)
        {
            DrawMap.PolyX(pnl);
            DrawMap.PolyY(pnl);
            MapCell old = new MapCell(0, 0) { Width = 0, Location = new Point(14, 10), };
            for (int i = 1; i <= DrawMap.ROWS; i++)
            {
                for (int j = 1; j <= DrawMap.COLUMNS; j++)
                {
                    MapCell btn = new MapCell(j, i)
                    {
                        Location = new Point(old.Location.X + old.Width, old.Location.Y),
                    };

                    btn.Click += Fire_Click;
                    pnl.Controls.Add(btn);
                    old = btn;
                }
                old = new MapCell(0, 0) { Width = 0, Height = 0, Location = new Point(14, old.Location.Y + DrawMap.CELL_HEIGHT), };

            }
        }

        #endregion

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


        
    }
}
