using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_CS_WF_3_Game15
{
    public struct COORD
    {
        public int X;
        public int Y;
        public COORD(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    class Game_15
    {
        int[,] _gameField = new int[4, 4]
        {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9,10,11,12},
            {13,14,15,0}
        };

        int zeroX = 3;
        int zeroY = 3;

        Random rand;

        public int this[int x, int y]
        {
            get => _gameField[x, y];
        }
        public Game_15() {
            rand = new Random();
            InitGame();
        }

        public void InitGame()
        {
            int[] move = new int[4] { -1,-1,-1,-1 };

            for (int i = 0; i < 10; ++i)
            {
                if ((zeroX - 1) >= 0 && zeroX - (zeroX - 1) == 1) { move[0] = this[zeroX - 1, zeroY]; }
                if ((zeroX + 1) < 4  && (zeroX + 1) - zeroX == 1) { move[1] = this[zeroX + 1, zeroY]; }
                if ((zeroY - 1) >= 0 && zeroY - (zeroY - 1) == 1) { move[2] = this[zeroX, zeroY - 1]; }
                if ((zeroY + 1) < 4  && (zeroY + 1) - zeroY == 1) { move[3] = this[zeroX, zeroY + 1]; }
                while(Go(move[rand.Next(4)]));
            }

        }

        public COORD GetCoord(int val)
        {
            for(int i=0; i<4; ++i)
            {
                for(int j = 0; j < 4; ++j)
                {
                    if (_gameField[j,i] == val)
                        return new COORD(j, i);
                }
            }
            return new COORD(-1, -1);
        }
        public COORD GetZeroCoord()
        {
            return new COORD(zeroX, zeroY);
        }


        public bool Go(int value)
        {
            COORD valueCoord = GetCoord(value);
            if(Math.Abs(valueCoord.X - zeroX) + Math.Abs(valueCoord.Y - zeroY) != 1)
            {
                return false;
            }
            _gameField[zeroX, zeroY] = value;
            _gameField[zeroX = valueCoord.X, zeroY = valueCoord.Y] = 0;
            return true;
        }

        public bool isWin()
        {
            for (int i = 0, n = 1; i < 4; ++i)
                for (int j = 0; j < 4; j++, n++)
                    if(_gameField[i,j] != (n<16?n:0) )
                    return false;
            return true;
        }
    }
}
