using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class ThienThach
    {
        int x;
        int y;
        Image hinhTT;

        public ThienThach(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.hinhTT = Properties.Resources.rsz_1rsz_pngwingcom;

        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public Image HinhTT { get => hinhTT; set => hinhTT = value; }

        // public PictureBox Thienthach { get => thienthach; set => thienthach = value; }

        public void Draw(Graphics g)
        {

            g.DrawImage(this.hinhTT, new Point(x, y));
        }
    }
}
