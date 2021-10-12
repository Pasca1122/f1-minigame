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
        int pos = 20;
        public Track()
        {
            InitializeComponent();
            labelOver.Visible = false;
            enemy1.Visible = false;           
            labelPosition.Text = "P" + pos;
            labelWin.Visible = false;
        }

        private void pictureBox61_Click(object sender, EventArgs e)
        {

        }
        Random r = new Random();
        int x, ok;
        private void enemy(int speed)
        {
            
            if (enemy1.Top >= 700)
            {
                x = r.Next(125,382);
                enemy1.Location = new Point(x, 0);
                ok = 1;
                if (pos == 1)
                {
                    pos--;
                    enemy1.Visible = false;
                }
            }
            else
                enemy1.Top += speed;
            if(enemy1.Top>playerCar.Top && ok == 1)
            {
                pos--;

                labelPosition.Text = "P" + pos;
                ok = 0;
            }
        }

        int gamespeedCar = 15;
        int gamespeedEnemy = 0;
        private void Track_KeyDown(object sender, KeyEventArgs e)
        {
            enemy1.Visible = true;          
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            if (e.KeyCode == Keys.Left)
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
                gamespeedCar = 0;
            }
            
            if (pos == 0)
            {
                timer1.Enabled = false;
                labelWin.Visible = true;
                gamespeedCar = 0;

            }

        }

        private void Track_Load(object sender, EventArgs e)
        {
            
            playerCar.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void enemy1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            enemy(gamespeedEnemy) ;
            gameover();
        }
    }
}
