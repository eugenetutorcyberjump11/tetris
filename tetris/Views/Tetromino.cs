using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Avalonia.Media;
using Avalonia; 

namespace tetris.Views
{
    public enum TetromimoType { I, O, T, S, Z, J, L }

    public class Tetromino
    {
        public TetromimoType Type { get; private set; }
        public int X { get; set; }
        public int Y { get; set; }
        public List<Point> Blocks { get; private set; } = new List<Point>();
        public IBrush Color { get; private set; } = Brushes.Transparent;

        public Tetromino(TetromimoType type, int x, int y)
        {
            Type = type;
            X = x;
            Y = y;
            InitializeBlocks();
        }

        private void InitializeBlocks()
        {
            Blocks = new List<Point>();
            switch (Type)
            {
                case TetromimoType.I:
                    Blocks.Add(new Point(0, 0));
                    Blocks.Add(new Point(1, 0));
                    Blocks.Add(new Point(2, 0));
                    Blocks.Add(new Point(3, 0));
                    Color = Brushes.Cyan;
                    break;
                case TetromimoType.O:
                    Blocks.Add(new Point(0, 0));
                    Blocks.Add(new Point(1, 0));
                    Blocks.Add(new Point(0, 1));
                    Blocks.Add(new Point(1, 1));
                    Color = Brushes.Yellow;
                    break;
                case TetromimoType.T:
                    Blocks.Add(new Point(1, 0));
                    Blocks.Add(new Point(1, 1));
                    Blocks.Add(new Point(0, 1));
                    Blocks.Add(new Point(2, 1));
                    Color = Brushes.Purple;
                    break;
                case TetromimoType.S:
                    Blocks.Add(new Point(0, 0));
                    Blocks.Add(new Point(1, 0));
                    Blocks.Add(new Point(1, 1));
                    Blocks.Add(new Point(2, 1));
                    Color = Brushes.Green;
                    break;
                case TetromimoType.Z:
                    Blocks.Add(new Point(0, 1));
                    Blocks.Add(new Point(1, 1));
                    Blocks.Add(new Point(1, 0));
                    Blocks.Add(new Point(2, 0));
                    Color = Brushes.Red;
                    break;
                case TetromimoType.J:
                    Blocks.Add(new Point(0, 0));
                    Blocks.Add(new Point(1, 0));
                    Blocks.Add(new Point(1, 1));
                    Blocks.Add(new Point(1, 2));
                    Color = Brushes.Blue;
                    break;
                case TetromimoType.L:
                    Blocks.Add(new Point(2, 0));
                    Blocks.Add(new Point(1, 0));
                    Blocks.Add(new Point(1, 1));
                    Blocks.Add(new Point(1, 2));
                    Color = Brushes.Orange;
                    break;
            }
        }

        public void Rotate(){
            for (int i = 0; i < Blocks.Count; i++)
            {
                double x = Blocks[i].X;
                Blocks[i] = new Point(Blocks[i].Y, -x);
            }
        }
    }
}
