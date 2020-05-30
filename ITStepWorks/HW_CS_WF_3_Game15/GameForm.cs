using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_CS_WF_3_Game15
{
    public partial class GameForm : Form
    {
        Game_15 _game = new Game_15();
        int _btnPadding = 20;
        int _btnMargin = 10;
        int _btnSize = 100;
        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            for(int i=0; i<4; ++i)
            {
                for (int j = 0; j < 4; j++)
                {
                    int val = _game[j, i];
                    if(val == 0) { continue; }

                    new Button
                    {
                        Text = $"{val}",
                        Tag = val,
                        Parent = this,
                        Size = new Size(_btnSize, _btnSize),
                        Location = new Point
                        {
                            X = _btnPadding + (_btnMargin + _btnSize) * j,
                            Y = _btnPadding + (_btnMargin + _btnSize) * i
                        }
                    }.Click += Button15_Click;
                }
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int val = (int)btn.Tag;
            if (_game.Go(val))
            {
                COORD coord = _game.GetCoord(val);
                btn.Location = new Point(
                    _btnPadding + (_btnMargin + _btnSize) * coord.X,
                    _btnPadding + (_btnMargin + _btnSize) * coord.Y);
                if (_game.isWin())
                {
                    MessageBox.Show("You are Win!!!");
                }
            }
            
        }
    }
}
