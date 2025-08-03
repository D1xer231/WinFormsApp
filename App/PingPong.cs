using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class PingPong : Form
    {
        private int _speedVer = 5, _speedHor = 5, _platformSpeed = 15;


        private int _score = 0;

        public PingPong()
        {
            InitializeComponent();
            //Cursor.Hide();
        }

        private void PingPong_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
                this.Close();
            else if((e.KeyCode == Keys.A || e.KeyCode == Keys.Left) && Platform.Left > GamePanel.Left) // Check if platform is not at the left edge
                Platform.Left -= _platformSpeed; // Move platform left
            else if ((e.KeyCode == Keys.D || e.KeyCode == Keys.Right) && Platform.Right < GamePanel.Right) // Check if platform is not at the right edge
                Platform.Left += _platformSpeed; // Move platform right
            else if (e.KeyCode == Keys.R && !timer.Enabled)
            {
                Random random = new Random();
                GameBall.Top = random.Next(20, 300);// Randomize the vertical position of the ball
                GameBall.Left = random.Next(20, 500);// Randomize the horizontal position of the ball
                _score = 0;
                LoseLabel.Visible = false; // Hide the "You Lose" label
                Rlabel.Visible = false; // Hide the "Press R to restart" label
                ResultLB.Text = "Score: 0";
                timer.Enabled = true; // Restart the timer
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            GameBall.Left -= _speedHor;
            GameBall.Top -= _speedVer;

            if (GameBall.Top <= GamePanel.Top) // Check if the ball hits the "top edge"
                _speedVer *= -1; // Reverse vertical speed when hitting the "top edge"
            if (GameBall.Bottom >= GamePanel.Bottom)
            {
                timer.Enabled = false; // Stop the timer when the ball hits the "bottom edge"
                LoseLabel.Visible = true; // Show the "You Lose" label
                Rlabel.Visible = true; // Show the "Press R to restart" label

            }
            if (GameBall.Right >= GamePanel.Right)
                _speedHor *= -1; // Reverse horizontal speed when hitting the "right" edge
            if (GameBall.Left <= GamePanel.Left)
                _speedHor *= -1; // Reverse horizontal speed when hitting the "left" edge

            if(GameBall.Bottom >= Platform.Top &&
                GameBall.Left >= Platform.Left && GameBall.Right <= Platform.Right)
            {
                _speedVer *= -1;
                _score++;
                ResultLB.Text = $"Score: {_score}";
                //Random random = new Random();
                //GamePanel.BackColor = Color.FromArgb(random.Next(150, 255), random.Next(150, 255), random.Next(150, 255));// Change background color randomly
            }
        }
    }
}
