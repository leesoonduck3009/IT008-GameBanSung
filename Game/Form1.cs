using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        int Score = 0;
        List<ThienThach> thienthach = new List<ThienThach>();
        List<Bullet> gun = new List<Bullet>();
        List<Explode> bombs = new List<Explode>();
        Random random = new Random();
        bool gameover = false;
        int PosX;
        int PosY;
        public Form1()
        {
            InitializeComponent();
            timerPhiThuyen.Start();
            timer1.Start();
            // timer2.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            foreach (ThienThach thien in thienthach)
            {
                thien.Draw(e.Graphics);
            }
            /*foreach (ThienThach c in circles)
            {
                c.Draw(e.Graphics);
            }*/
            foreach (Bullet bullet in gun)
            {
                bullet.Draw(e.Graphics);
            }
            foreach (Explode bomb in bombs)
            {
                bomb.Draw(e.Graphics);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < thienthach.Count; i++)
            {
                if (thienthach[i].Y < this.ClientSize.Height)
                {
                    thienthach[i].Y = thienthach[i].Y + 5;
                }
                if (thienthach[i].Y > this.ClientSize.Height)
                {
                    thienthach.RemoveAt(i);
                    i--;
                }

            }
            for (int i = 0; i < gun.Count; i++)
            {
                if (gun[i].Y > 0)
                    gun[i].Y = (gun[i].Y - 8);
                if (gun[i].Y <= 15)
                {
                    gun.RemoveAt(i);
                    i--;
                }
            }



            Refresh();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void timerPhiThuyen_Tick(object sender, EventArgs e)
        {
            this.lbScore.Text = "Score: " + Score.ToString();
           
            this.pictureBoxPhiThuyen.BackColor = Color.Transparent;
            PosX = pictureBoxPhiThuyen.Location.X ;
            PosY = pictureBoxPhiThuyen.Location.Y;
            pictureBoxPhiThuyen.Location = new Point(PosX, PosY);
            if (pictureBoxPhiThuyen.Location.X < 30)
            {
                PosX = 30;
            }
            if (pictureBoxPhiThuyen.Location.Y > this.ClientSize.Height)
            {
                PosY = this.ClientSize.Height - 30;
            }
            if (thienthach.Count < 5)
            {
                int FirstPos = random.Next(25, this.ClientSize.Width - 50);
                for (int i = 0; i < thienthach.Count; i++)
                {
                    if (FirstPos >= thienthach[i].X && FirstPos <= thienthach[i].X + 54)
                    {
                        FirstPos = random.Next(25, this.ClientSize.Width - 50);
                        i = 0;
                    }
                }
                thienthach.Add(new ThienThach(FirstPos, 25));
            }
            if (CheckVaCham())
            {
                pictureBoxPhiThuyen.Enabled = false;
                timerPhiThuyen.Stop();
                timer1.Stop();
                timerGun.Stop();
                MessageBox.Show("Game over", "thong bao");
            }

            int xImage = 0;
            int yImage = 0;
            List<int> shot = CheckShot();
            if (shot[0] != -1)
            {

                gun.RemoveAt(shot[0]);
                Score += 10;
            }

            if (shot[1] != -1)
            {

                xImage = thienthach[shot[1]].X;
                yImage = thienthach[shot[1]].Y;
                thienthach.RemoveAt(shot[1]);
                Explode explode = new Explode(xImage, yImage);
                bombs.Add(explode);
            }
            Refresh();
        }
        void CreateBullet()
        {
            gun.Add(new Bullet(PosX + 25, PosY + 35));
        }
        private void timerGun_Tick(object sender, EventArgs e)
        {
            flag = 1;
         //   gun.Add(new Bullet(PosX + 25, PosY + 35));

        }
        
        private bool CheckVaCham()
        {
            /*Point checkPoint;
            for()*/
            int x1PT, x2PT, y1PT, y2PT;
            int x1TT, x2TT, y1TT, y2TT;
            
                x1PT = pictureBoxPhiThuyen.Location.X;
                x2PT = pictureBoxPhiThuyen.Location.X + pictureBoxPhiThuyen.Width;
                y1PT = pictureBoxPhiThuyen.Location.Y;
                y2PT = pictureBoxPhiThuyen.Location.Y + pictureBoxPhiThuyen.Height;
                for (int j = 0; j < thienthach.Count; j++)
                {
                    x1TT = thienthach[j].X;
                    x2TT = thienthach[j].X + thienthach[j].HinhTT.Width;
                    y1TT = thienthach[j].Y;
                    y2TT = thienthach[j].Y + thienthach[j].HinhTT.Height;
                    if (x1PT < x2TT && x1TT < x2PT && y1PT < y2TT && y1TT < y2PT)
                        return true;
                }
            
            return false;
        }
        private List<int> CheckShot()
        {
            /*Point checkPoint;
            for()*/
            
            float x1gun, x2gun, y1gun, y2gun;
            float x1TT, x2TT, y1TT, y2TT;
            for (int i = 0; i < gun.Count; i++)
            {
                x1gun = gun[i].X;
                x2gun = gun[i].X + gun[i].Bul.Width;
                y1gun = gun[i].Y;
                y2gun = gun[i].Y + 20;
                for (int j = 0; j < thienthach.Count; j++)
                {
                    x1TT = thienthach[j].X;
                    x2TT = thienthach[j].X + thienthach[j].HinhTT.Width;
                    y1TT = thienthach[j].Y;
                    y2TT = thienthach[j].Y + thienthach[j].HinhTT.Height;
                    if (x1gun < x2TT && x1TT < x2gun && y1gun < y2TT && y1TT < y2gun)
                        return new List<int> { i, j };
                }
            }
            return new List<int> { -1, -1 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timerExplode_Tick(object sender, EventArgs e)
        {
            bombs.Clear();
        }
        int flag = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right)
            {
                if (pictureBoxPhiThuyen.Location.X < this.ClientSize.Width - 95)
                    pictureBoxPhiThuyen.Location = new Point(20+ pictureBoxPhiThuyen.Location.X, pictureBoxPhiThuyen.Location.Y);
            }
            else if (e.KeyData == Keys.Left)
            {
                if (pictureBoxPhiThuyen.Location.X > 5)
                    pictureBoxPhiThuyen.Location = new Point( pictureBoxPhiThuyen.Location.X-20, pictureBoxPhiThuyen.Location.Y);
            }
            else if (e.KeyData == Keys.Up)
            {
                if (pictureBoxPhiThuyen.Location.Y > 0)
                    pictureBoxPhiThuyen.Location = new Point(pictureBoxPhiThuyen.Location.X, pictureBoxPhiThuyen.Location.Y - 20);
            }
            else if (e.KeyData == Keys.Down)
            {
                if (pictureBoxPhiThuyen.Location.Y < this.ClientSize.Height - 84)
                    pictureBoxPhiThuyen.Location = new Point(pictureBoxPhiThuyen.Location.X, pictureBoxPhiThuyen.Location.Y+20);
            }
            else if (e.KeyData == Keys.Space)
            {
                if (flag == 1)
                {
                    CreateBullet();
                    flag = 0;
                }
            }
        }
    }
   
 
    
}
