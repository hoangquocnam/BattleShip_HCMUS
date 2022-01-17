using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleshipClient
{
    class MapCell : Button
    {
        public int X { get; set; }
        public int Y { get; set; }
        public MapCell(int x, int y) : base()
        {
            SetStyle(ControlStyles.Selectable, false); // hide highlight when selected
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = Color.DarkGray;
            Margin = new Padding(0);
            BackColor = Color.White;
            X = x;
            Y = y;
            Width = DrawMap.CELL_WIDTH;
            Height = DrawMap.CELL_HEIGHT;
            Name = $"{Convert.ToString(x)}-{Convert.ToString(y)}";
        }

    }
    public class DrawMap
    {
        public static int CELL_WIDTH = 19;
        public static int CELL_HEIGHT = 19;
        public static int COLUMNS = 20;
        public static int ROWS = 20;

        public static void PolyX(Panel pnl)
        {
            Label old = new Label() { Width = 19, Height = 10, Location = new Point(-5, -2) };
            for (int i = 1; i <= 20; i++)
            {
                Label lbl = new Label() { Width = 19, Height = 10, Location = new Point(old.Location.X + 19) };
                lbl.Font = new Font("Consolas", 7);
                lbl.TextAlign = ContentAlignment.TopCenter;
                lbl.Text = Convert.ToString(i);
                pnl.Controls.Add(lbl);
                old = lbl;
            }

        }

        public static void PolyY(Panel pnl)
        {
            Label old = new Label() { Width = 15, Height = 10, Location = new Point(-1, -5) };
            for (int i = 1; i <= 20; i++)
            {
                Label lbl = new Label() { Width = 15, Height = 10, Location = new Point(old.Location.X, old.Location.Y + 19) };
                lbl.Font = new Font("Consolas", 7);
                lbl.TextAlign = ContentAlignment.TopCenter;
                lbl.Text = Convert.ToString(i);
                pnl.Controls.Add(lbl);
                old = lbl;
            }

        }
       
        public static void DrawSubGrid(Panel pnl, StringBuilder [] grids)
        {
            PolyX(pnl);
            PolyY(pnl);
            MapCell old = new MapCell(0, 0) { Width = 0, Location = new Point(14, 10), };
            for (int i = 1; i <= ROWS; i++)
            {
                StringBuilder tokens = grids[i - 1];
                for (int j = 1; j <= COLUMNS; j++)
                {
                    MapCell btn = new MapCell(j, i)
                    {
                        Location = new Point(old.Location.X + old.Width, old.Location.Y),
                    };
                    if (tokens[j - 1] == '1')
                    {
                        btn.BackgroundImage = BattleshipClient.Properties.Resources.battleship;
                    }
                    pnl.Controls.Add(btn);
                    old = btn;
                }
                old = new MapCell(0, 0) { Width = 0, Height = 0, Location = new Point(14, old.Location.Y + CELL_HEIGHT) };

            }
        }

    }

    public class MapChecker
    {
        private static readonly int[,] ShipTypes = new int[,]
        {
            { 1, 1, 3 },
            { 1, 2, 3 },
            { 1, 4, 3 },
            { 2, 5, 2 },
            { 2, 7, 1 }
        };

        public static bool Check(string path)
        {
            List<string> grid = new List<string>(File.ReadAllLines(path));

            // kiểm tra số lượng hàng
            if (grid.Count != 20) return false;

            // kiểm tra số lượng cột và có kí tự nào khác 0 hoặc 1 hay ko
            if (grid.Any(p => p.Length != 20 || p.Any(q => q != '0' && q != '1'))) return false;

            // kiểm tra tổng vị trí tàu có thiếu hoặc dư hay không
            if (grid.Sum(p => p.Count(q => q == '1')) != 55) return false;

            for (int i = 0; i < ShipTypes.GetLength(0); ++i)
            {
                if (!IsContainShips(grid, ShipTypes[i, 0], ShipTypes[i, 1], ShipTypes[i, 2]))
                    return false;
            }

            return true;
        }

        private static bool IsContainShips(List<string> grid, int h, int w, int n)
        {
            for (int i = 0; i < 20; ++i)
            {
                for (int j = 0; j < 20; ++j)
                {
                    if (grid[i][j] == '1')
                    {
                        // check horizontal and vertical
                        if (IsShip(grid, i, j, h, w, true) || IsShip(grid, i, j, h, w, false))
                            --n;
                    }
                }
            }

            return n == 0;
        }

        private static bool IsShip(List<string> grid, int i, int j, int h, int w, bool isHorizontal)
        {
            if (!isHorizontal)
            {
                int tmp = h;
                h = w;
                w = tmp;
            }

            if (i + h > 20
                || j + w > 20
                || (i > 0 && grid[i - 1][j] == '1')
                || (j > 0 && grid[i][j - 1] == '1')
                || (i + h < 20 && grid[i + h][j] == '1')
                || (j + w < 20 && grid[i][j + w] == '1'))
                return false;

            for (int a = 0; a < h; ++a)
            {
                for (int b = 0; b < w; ++b)
                {
                    if (grid[i + a][j + b] == '0')
                        return false;
                }
            }

            return true;
        }
    }
}