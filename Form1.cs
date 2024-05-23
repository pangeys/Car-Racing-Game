using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game_
{
    public partial class CarRacing : Form
    {
        System.Media.SoundPlayer music = new System.Media.SoundPlayer();

        int roadSpeed = 15;
        int trafficSpeed = 15;
        int playerSpeed = 12;
        int score;
        int carImage;

        Random rand = new Random();
        Random carPosition = new Random();
        bool goleft;
        bool goright;

        public CarRacing()
        {
            InitializeComponent();
            explosion.Visible = false;
            award.Visible = false;
            music.SoundLocation = "bgMusic.wav";
        }

        private void restartGame(object sender, EventArgs e)
        {
            ResetGame();
            music.Play();   
        }

        private void ResetGame()
        {
            btnStart.Enabled = false;
            explosion.Visible = false;
            award.Visible = false;
            goleft = false;
            goright = false;
            score = 0;
            award.Image = Properties.Resources.bronze;
            roadSpeed = 12;
            trafficSpeed = 15;
            A1.Top = carPosition.Next(200, 500) * -1;
            A1.Left = carPosition.Next(5, 200);
            A2.Top = carPosition.Next(200, 500) * -1;
            A2.Left = carPosition.Next(245, 422);
            gameTimer.Start();

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            if (!btnStart.Enabled) // Check if the game is active
            {
                textScore.Text = "Score: " + score;
                score++;

                if (goleft && player.Left > 10)
                {
                    player.Left -= playerSpeed;
                }
                if (goright && player.Left < 415)
                {
                    player.Left += playerSpeed;
                }

                roadtrack1.Top += roadSpeed;
                roadtrack2.Top += roadSpeed;

                if (roadtrack2.Top > 500)
                {
                    roadtrack2.Top = -500;
                }
                if (roadtrack1.Top > 500)
                {
                    roadtrack1.Top = -500;
                }

                A1.Top += trafficSpeed;
                A2.Top += trafficSpeed;

                if (A1.Top > 530)
                {
                    ChangeACars(A1);
                }

                if (player.Bounds.IntersectsWith(A1.Bounds) ||
                    player.Bounds.IntersectsWith(A2.Bounds))
                {
                    gameOver();
                }

                if (score > 40 && score < 400)
                {
                    award.Image = Properties.Resources.bronze;
                }
                if (score > 400 && score < 1000)
                {
                    award.Image = Properties.Resources.silver;
                    roadSpeed = 20;
                    trafficSpeed = 22;
                }
                if (score > 1000)
                {
                    award.Image = Properties.Resources.gold;
                    roadSpeed = 27;
                    trafficSpeed = 25;
                }
            }
        }
        private void gameOver()
        {
            gameTimer.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-8, 5);
            explosion.BackColor = Color.Transparent;
            award.Visible = true;
            award.BringToFront();
            btnStart.Enabled = true;
            music.Stop();
        }

        private void ChangeACars(PictureBox tempCar)
        {
            carImage = rand.Next(2, 9);
            switch (carImage)
            {
                case 1:
                    tempCar.Image = Properties.Resources.blue1;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.blue2;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.blue3;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.yellow;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.blue1;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.blue2;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.blue3;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.yellow;
                    break;
            }
            tempCar.Top = carPosition.Next(100, 400) * -1;
            if ((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(5, 200);
            }
            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(245, 422);
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void explosion_Click(object sender, EventArgs e)
        {

        }


    }
}
