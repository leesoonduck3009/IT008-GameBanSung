using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Explode
    {
        Image bomb = Properties.Resources.explode;
        int x;
        int y;

        public Explode(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Image Bomb { get => bomb; set => bomb = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public void Draw(Graphics g)
        {
            g.DrawImage(Bomb, x, y);
        }
    }
}
