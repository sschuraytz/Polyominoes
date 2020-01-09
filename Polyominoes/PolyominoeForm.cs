using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polyominoes
{
    public partial class PolyominoeForm : Form
    {
        Board board;

        public PolyominoeForm()
        {
            InitializeComponent();
            board = new Board((int)nudSize.Value);
            FillBoard(pnlBoard);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = board.Occupied[0, 0].ToString();
        }

        private void nudSize_ValueChanged(object sender, EventArgs e)
        {
            // TODO resize the board
        }

        private void FillBoard(Panel pnl)
        {
            int size = (int)nudSize.Value;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Panel mini = new Panel();

                    mini.Height = mini.Width = 50;
                    mini.Location = new Point(row * mini.Width, col * mini.Height);
                    mini.BackColor = Color.BlueViolet;
                    mini.BorderStyle = BorderStyle.Fixed3D;
                    pnl.Controls.Add(mini);
                }
            }
        }
    }
}
