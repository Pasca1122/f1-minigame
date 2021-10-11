using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Track : Form
    {
        public Track()
        {
            InitializeComponent();
            labelOver.Visible = false;
        }

        private void pictureBox61_Click(object sender, EventArgs e)
        {

        }
        Random r = new Random();
        int y, x;
        private void enemy(int speed)
        {
            if (enemy1.Top >= 1200)
            {
                x = r.Next(125,382);
                enemy1.Location = new Point(x, 0);
            }
            else
                enemy1.Top += speed;
            if (enemy2.Top >= 1200)
            {
                y = r.Next(125, 382);
                enemy2.Location = new Point(y, 0);
            }
            else
                enemy2.Top += speed;



        }

        int gamespeedCar = 15;
        int gamespeedEnemy = 0;
        private void Track_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if(playerCar.Left >125)
                    playerCar.Left += -gamespeedCar;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (playerCar.Left <390 )
                    playerCar.Left += gamespeedCar;
            }
            if(e.KeyCode==Keys.Up)
            {
                if (gamespeedEnemy < 7)
                {
                    gamespeedEnemy++;
                    gamespeedCar++;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeedEnemy > 0)
                { 
                    gamespeedEnemy--;
                    gamespeedCar++;
                }
            }
        }

        private void gameover()
        {
            if(playerCar.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                labelOver.Visible = true;
            }
            if (playerCar.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                labelOver.Visible = true;
            }
        }

        private void Track_Load(object sender, EventArgs e)
        {
            
            playerCar.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            enemy(gamespeedEnemy) ;
            gameover();
        }
    }
}
