using System.Drawing;

namespace Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerPhiThuyen = new System.Windows.Forms.Timer(this.components);
            this.timerGun = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxPhiThuyen = new System.Windows.Forms.PictureBox();
            this.timerExplode = new System.Windows.Forms.Timer(this.components);
            this.lbScore = new System.Windows.Forms.Label();
            this.timerLevel = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhiThuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerPhiThuyen
            // 
            this.timerPhiThuyen.Enabled = true;
            this.timerPhiThuyen.Interval = 1;
            this.timerPhiThuyen.Tick += new System.EventHandler(this.timerPhiThuyen_Tick);
            // 
            // timerGun
            // 
            this.timerGun.Enabled = true;
            this.timerGun.Interval = 500;
            this.timerGun.Tick += new System.EventHandler(this.timerGun_Tick);
            // 
            // pictureBoxPhiThuyen
            // 
            this.pictureBoxPhiThuyen.Image = global::Game.Properties.Resources.PhiThuyen1;
            this.pictureBoxPhiThuyen.Location = new System.Drawing.Point(271, 505);
            this.pictureBoxPhiThuyen.Name = "pictureBoxPhiThuyen";
            this.pictureBoxPhiThuyen.Size = new System.Drawing.Size(50, 60);
            this.pictureBoxPhiThuyen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhiThuyen.TabIndex = 0;
            this.pictureBoxPhiThuyen.TabStop = false;
            // 
            // timerExplode
            // 
            this.timerExplode.Enabled = true;
            this.timerExplode.Interval = 1000;
            this.timerExplode.Tick += new System.EventHandler(this.timerExplode_Tick);
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.Transparent;
            this.lbScore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbScore.Location = new System.Drawing.Point(389, 36);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(79, 30);
            this.lbScore.TabIndex = 1;
            this.lbScore.Text = "Score: ";
            // 
            // timerLevel
            // 
            this.timerLevel.Enabled = true;
            this.timerLevel.Interval = 30000;
            this.timerLevel.Tick += new System.EventHandler(this.timerLevel_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.bg_space_seamless;
            this.ClientSize = new System.Drawing.Size(550, 633);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.pictureBoxPhiThuyen);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhiThuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxPhiThuyen;
        private System.Windows.Forms.Timer timerPhiThuyen;
        private System.Windows.Forms.Timer timerGun;
        private System.Windows.Forms.Timer timerExplode;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Timer timerLevel;
    }
}

