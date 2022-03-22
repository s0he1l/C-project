using System;
using System.Windows.Forms;

namespace Bird_Chicken
{
    public partial class Form1 : Form
    {
        private const bool T = true;
        private const bool F = false;
        int pipespeed = 8;
        int gravity = 10;
        int score = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            //working Game 
            btnRestart.Enabled = F;
            
            if (gametimer.Enabled == T)
            {
                
                btnRestart.Visible = F;
                FlappyBird.Top += gravity;
                PipeBottom.Left -= pipespeed;
                PipeTop.Left -= pipespeed;
                scoreText.Text = "score: " + score;
                if (PipeBottom.Left < -80)
                {
                    PipeBottom.Left = 800;

                }
                if (PipeTop.Left < -90)
                {
                    PipeTop.Left = 950;
                    score++;
                }
                if (FlappyBird.Bounds.IntersectsWith(PipeBottom.Bounds) ||
                    FlappyBird.Bounds.IntersectsWith(PipeTop.Bounds) ||
                    FlappyBird.Bounds.IntersectsWith(Ground.Bounds) || FlappyBird.Top < -25
                    )
                {
                    EndGame();
                }
                if (score >= 5)
                {
                    pipespeed = 15;
                }

            }

        }
        private void GameKeyisdown(object sender, KeyEventArgs e)
        {
            //working keys
            if ((e.KeyCode == Keys.Space) || (e.KeyCode == Keys.Up))
            {
                gravity = -12;
            }
        }
        private void GameKeyisup(object sender, KeyEventArgs e)
        {
            //working keys
            if ((e.KeyCode == Keys.Space) || (e.KeyCode == Keys.Down))
            {
                gravity = 12;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void EndGame()
        {

            gametimer.Enabled = F;
            scoreText.Text += "    Game over!!!";
            btnRestart.Visible = T;
           
            btnRestart.Enabled = T;

        }

        private void secore_Click(object sender, EventArgs e)
        {

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {

            if (gametimer.Enabled != T)
            {
                //MessageBox.Show("Test");
                pipespeed = 8;
                gravity = 10;
                score = 0;
                FlappyBird.Top = 235;
                FlappyBird.Left = 304;
                PipeTop.Top = -25;
                PipeTop.Left = 747;
                PipeBottom.Top = 400;
                PipeBottom.Left = 1000;
                gametimer.Enabled = T;
            }
            }
    }


}
