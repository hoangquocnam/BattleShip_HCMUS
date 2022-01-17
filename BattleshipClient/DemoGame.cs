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
    public partial class DemoGame : Form
    {
        public DemoGame(string p1, string p2)
        {
            InitializeComponent();
            txtPlayer1.Text = p1;
            txtPlayer2.Text = p2;
        }

        
    }
}
