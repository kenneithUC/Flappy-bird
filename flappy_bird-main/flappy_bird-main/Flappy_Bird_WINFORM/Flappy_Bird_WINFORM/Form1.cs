using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_WINFORM
{
    public partial class Form1 : Form
    {
        int ObstacleSpeed = 5;
        int gravity = 5;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
            GameTimer.Start();
        }

        private void SkyTimer(object sender, EventArgs e)
        {
            flappybird.Top += gravity;
            gravity = 5;
            TopPipe.Left -= ObstacleSpeed;
            DownPipe.Left -= ObstacleSpeed;
            TopPipe2.Left -= ObstacleSpeed;
            DownPipe2.Left -= ObstacleSpeed;

            Random rnd = new Random();
            int randomizer = rnd.Next(-40, 40);
            int randomizer2 = rnd.Next(-40, 40);

            ScorePoint.Text = score.ToString();

            if(DownPipe.Location.Y > 360)
            {
                randomizer = rnd.Next(0, 40);
            }
            else if(DownPipe.Location.Y < 120)
            {
                randomizer = rnd.Next(-40, 0);
            }

            if(DownPipe2.Location.Y > 360)
            {
                randomizer2 = rnd.Next(0, 40);
            }
            else if(DownPipe2.Location.Y < 120)
            {
                randomizer2 = rnd.Next(-40, 0);
            }

            if (DownPipe.Left < -50)
            {
                DownPipe.Top += randomizer;
                DownPipe.Left = 550;
                score++;
            }

            if (TopPipe.Left < -50)
            {
                TopPipe.Top += randomizer;
                TopPipe.Left = 550;
            }

            if (DownPipe2.Left < -50)
            {
                DownPipe2.Top += randomizer2;
                DownPipe2.Left = 550;
                score++;
                if (score % 10 == 0)
                {
                    if (score > 40)
                    {
                        GameTimer.Interval -= 3;
                    }
                    else
                    {
                        GameTimer.Interval -= 5;
                    }
                }
            }

            if (TopPipe2.Left < -50)
            {
                TopPipe2.Top += randomizer2;
                TopPipe2.Left = 550;
            }

            if (flappybird.Bounds.IntersectsWith(DownPipe.Bounds) || flappybird.Bounds.IntersectsWith(TopPipe.Bounds) || flappybird.Bounds.IntersectsWith(DownPipe2.Bounds) || flappybird.Bounds.IntersectsWith(TopPipe2.Bounds) || flappybird.Bounds.IntersectsWith(ground.Bounds) || flappybird.Top < -25)
            {
                gameOver();
            }
        }


        private void gameKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -50;
            }
        }

        private void gameOver()
        {
            GameTimer.Stop();
        }
    }
}
