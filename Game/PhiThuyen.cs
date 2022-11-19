using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Bullet
    {
        int x;
        int y;
        Pen bul = new Pen(Color.FromArgb(220, 198, 99));

        public Bullet(int x, int y)
        {
            this.x = x;
            this.y = y;
            bul.Width = 5;
            //  this.hinhbullet = Properties.Resources.rsz_1rsz_1phithuyen;

        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public Pen Bul { get => bul; set => bul = value; }

        //public Image Hinhbullet { get => hinhbullet; set => hinhbullet = value; }

        // public PictureBox Thienthach { get => thienthach; set => thienthach = value; }

        public void Draw(Graphics g)
        {

            g.DrawLine(bul, new Point(x, y), new Point(X, Y + 20));
        }
    }
}
