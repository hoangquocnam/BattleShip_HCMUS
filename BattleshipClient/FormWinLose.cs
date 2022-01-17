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
    public partial class FormWinLose : Form
    {
        public string RoomID;
        public FormWinLose(bool isWin, string roomID, string rival)
        {
            InitializeComponent();
            RoomID = roomID;
            string res;
            if (isWin)
            {
                this.BackColor = Color.Gold;
                lblRole.Text = "Winner";
                lblRole.ForeColor = Color.Salmon;
                res = "Congratulations! You won this battle.";
                pc.Image = BattleshipClient.Properties.Resources.winner;
         
            }
            else
            {
                this.BackColor = Color.Salmon;
                lblRole.Text = "Loser";
                lblRole.ForeColor = Color.Yellow;
                res = "Oops! Good luck for next time.";
                pc.Image = BattleshipClient.Properties.Resources.loser;
            }
            lblRes.Text = $"{res}{Environment.NewLine}{Environment.NewLine}Do you want to have another round with {rival} ?";
            CountDown();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            timer.Stop();
            FormMain.Instance.SendRequest($"game\0{RoomID}\0continue\01");
            Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            timer.Stop();
            FormMain.Instance.SendRequest($"game\0{RoomID}\0continue\00");
            Close();
        }

        private Timer timer = new Timer();

        private int counter;

        private void CountDown()
        {
            counter = 10;
            timer.Dispose();
            timer = new Timer();
            timer.Tick += new EventHandler(Time_Tick);
            timer.Interval = 1000; // 1 second
            timer.Start();
            lblCountDown.Text = $"{counter.ToString()}s";
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                btnNo_Click(sender, e);
            }
            lblCountDown.Text = $"{counter.ToString()}s";
        }
    }
}
