using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArenaSoccer
{
    
    public partial class ArenaSoccer : Form
    {

        Player playerOne;
        Player playerTwo;
        Ball ball;
    
        

        public ArenaSoccer()
        {
            InitializeComponent();
            playerOne = new Player();
            playerTwo = new Player();
            ball = new Ball();

            gameOverLbl.Visible = false;
            blueWinsLbl.Visible = false;
            redWinsLbl.Visible = false;
          
    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            ballOvalShape.Left += ball.speedofBallLeft;
            ballOvalShape.Top += ball.speedofBallTop;
          

            HandleBallFalling();

            HandleBallIntoWallCollisions();

            HandlePlayerOneBallCollisions();

            HandlePlayerTwoBallCollisions();

            MovePlayerOne();

            MovePlayerTwo();

            AddPointToPlayersScore();

            CheckScoresForWinner();

            ResetPlayersAndBallLocation();
       
        }

        public void HandleBallFalling()
        {
            if (ball.ballBeingKicked == true) // falling for after ball is hit
            {
                ballOvalShape.Top -= ball.gravityOfBall;
                ball.gravityOfBall -= 1;
            }
            if (ballOvalShape.Top + ballOvalShape.Height >= screen.Height)
            {
                ballOvalShape.Top = screen.Height - ballOvalShape.Height; //stop falling at bottom

            }
            else
            {
                ballOvalShape.Top += 1; //falling
            }
        }

        public void HandleBallIntoWallCollisions()
        {
            if (ballOvalShape.Left <= screen.Left)
            {
                ball.speedofBallLeft = -ball.speedofBallLeft;
            }
            if (ballOvalShape.Right >= screen.Right)
            {
                ball.speedofBallLeft = -ball.speedofBallLeft;
            }
            if (ballOvalShape.Top >= ceiling.Bottom)
            {
                ball.speedofBallTop = -ball.speedofBallTop;
            }
            if (ballOvalShape.Top <= ceiling.Bottom)
            {
                ball.speedofBallTop = -ball.speedofBallTop;
            }
            if (ballOvalShape.Bottom <= wallForGoal2.Bottom && ballOvalShape.Left <= wallForGoal2.Right)
            {
                ball.speedofBallLeft = -ball.speedofBallLeft;
            }
            if (ballOvalShape.Bottom <= wallForGoal1.Bottom && ballOvalShape.Right >= wallForGoal1.Left)
            {
                ball.speedofBallLeft = -ball.speedofBallLeft;
            }
        }

        public void HandlePlayerOneBallCollisions()
        {
            if (player1PictureBox.Left <= ballOvalShape.Right && player1PictureBox.Left > ballOvalShape.Left && player1PictureBox.Top > ballOvalShape.Top && player1PictureBox.Bottom <= ballOvalShape.Bottom)
            {
                ball.speedofBallLeft = 3;
                ball.speedofBallTop = 3;
                ball.speedofBallLeft = -ball.speedofBallLeft;
                ball.speedofBallTop = -ball.speedofBallTop;
                ball.ballBeingKicked = true;
                ball.gravityOfBall = ball.forceOfKick;
            }
            if (player1PictureBox.Right >= ballOvalShape.Left && player1PictureBox.Right < ballOvalShape.Right && player1PictureBox.Top > ballOvalShape.Top && player1PictureBox.Bottom <= ballOvalShape.Bottom)
            {
                ball.speedofBallLeft = -ball.speedofBallLeft;
                ball.speedofBallTop = -ball.speedofBallTop;
                ball.speedofBallLeft = 3;
                ball.speedofBallTop = 3;
                ball.ballBeingKicked = true;
                ball.gravityOfBall = ball.forceOfKick;
            }
        }

        public void HandlePlayerTwoBallCollisions()
        {
            if (player2Picturebox.Left <= ballOvalShape.Right && player2Picturebox.Left > ballOvalShape.Left && player2Picturebox.Top > ballOvalShape.Top && player2Picturebox.Bottom <= ballOvalShape.Bottom)
            {

                ball.speedofBallLeft = 3;
                ball.speedofBallTop = 3;
                ball.speedofBallLeft = -ball.speedofBallLeft;
                ball.speedofBallTop = -ball.speedofBallTop;
                ball.ballBeingKicked = true;
                ball.gravityOfBall = ball.forceOfKick;
            }
            if (player2Picturebox.Right >= ballOvalShape.Left && player2Picturebox.Right < ballOvalShape.Right && player2Picturebox.Top > ballOvalShape.Top && player2Picturebox.Bottom <= ballOvalShape.Bottom)
            {

                ball.speedofBallLeft = -ball.speedofBallLeft;
                ball.speedofBallTop = -ball.speedofBallTop;
                ball.speedofBallLeft = 3;
                ball.speedofBallTop = 3;
                ball.ballBeingKicked = true;
                ball.gravityOfBall = ball.forceOfKick;
            }
        }
        public void MovePlayerOne()
        {
            if (playerOne.moveRight == true)
            {
                player1PictureBox.Left += playerOne.Pace;
            }

            if (playerOne.moveLeft == true)
            {
                player1PictureBox.Left -= playerOne.Pace;
            }
       
            if (playerOne.jump == true) // falling for after player jumps
            {
                player1PictureBox.Top -= playerOne.gravityOfPlayer;
                playerOne.gravityOfPlayer -= 1;
            }

            if (player1PictureBox.Top + player1PictureBox.Height >= screen.Height)
            {
                player1PictureBox.Top = screen.Height - player1PictureBox.Height; //stop falling at bottom
                playerOne.jump = false;
            }
            else
            {
                player1PictureBox.Top += 4; //falling
            }

            //Can't go off screen
            if (player1PictureBox.Left <= screen.Left)
            {
                playerOne.moveLeft = false;
            }
            if (player1PictureBox.Right >= screen.Right)
            {
                playerOne.moveRight = false;
            }
      
        }
    
        public void MovePlayerTwo()
        {
            if (playerTwo.moveRight == true)
            {
                player2Picturebox.Left += playerTwo.Pace;
            }

            if (playerTwo.moveLeft == true)
            {
                player2Picturebox.Left -= playerTwo.Pace;
            }

            if (playerTwo.jump == true) // falling for after player jumps
            {
                player2Picturebox.Top -= playerTwo.gravityOfPlayer;
                playerTwo.gravityOfPlayer -= 1;
            }

            if (player2Picturebox.Top + player2Picturebox.Height >= screen.Height)
            {
                player2Picturebox.Top = screen.Height - player2Picturebox.Height; //stop falling at bottom
                playerTwo.jump = false;
            }
            else
            {
                player2Picturebox.Top += 4; //falling
            }

            //Can't go off screen
            if (player2Picturebox.Left <= screen.Left)
            {
                playerTwo.moveLeft = false;
            }
            if (player2Picturebox.Right >= screen.Right)
            {
                playerTwo.moveRight = false;
            }
        }

        private void HandleKeypressActions(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F1)
            {
                RestartGame();
            }
            HandlePlayerOneKeyPresses(sender, e);
            HandlePlayerTwoKeyPresses(sender, e);
        }

        private void HandleKeyReleaseActions(object sender, KeyEventArgs e)
        {
            HandlePlayerOneKeyReleases(sender, e);
     
            HandlePlayerTwoKeyReleases(sender, e);
        }

        public void AddPointToPlayersScore()
        {
            if (ballOvalShape.Left > goal1.Left && ballOvalShape.Top > goal1.Top)
            {
                playerTwo.scoreForPlayerTwo += 1;
                player2ScoreLbl.Text = playerTwo.scoreForPlayerTwo.ToString();
            }

            if (ballOvalShape.Right < goal2.Right && ballOvalShape.Top > goal2.Top)
            {
                playerOne.scoreForPlayerOne += 1;
                player1ScoreLbl.Text = playerOne.scoreForPlayerOne.ToString();
            }
        }

        public void CheckScoresForWinner()
        {
            if (playerOne.scoreForPlayerOne == 3 || playerTwo.scoreForPlayerTwo == 3)
            {
                timer1.Enabled = false;
                gameOverLbl.Visible = true;
                if (playerOne.scoreForPlayerOne == 3)
                {
                    redWinsLbl.Visible = true;
                }
                else
                {
                    blueWinsLbl.Visible = true;
                }
            }
          
        }

        public void ResetPlayersAndBallLocation()
        {
            if (ballOvalShape.Left > goal1.Left && ballOvalShape.Top > goal1.Top)
            {
                player2Picturebox.Left = 200;
                player1PictureBox.Left = 750;
                System.Threading.Thread.Sleep(3000);        
                ballOvalShape.Left = 500;

            }

            if (ballOvalShape.Right < goal2.Right && ballOvalShape.Top > goal2.Top)
            {
                player2Picturebox.Left = 200;
                player1PictureBox.Left = 750;
                System.Threading.Thread.Sleep(3000);
                ballOvalShape.Left = 500;
            }

            
        }

        private void HandlePlayerOneKeyPresses(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                playerOne.moveRight = true;
            }

            if (e.KeyCode == Keys.Left)
            {
                playerOne.moveLeft = true;
            }
            if (playerOne.jump != true)
            {
                if (e.KeyCode == Keys.Up)
                {
                    playerOne.jump = true;
                    playerOne.gravityOfPlayer = playerOne.forceOfJump;
                }
            }
        }

        private void HandlePlayerTwoKeyPresses(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                playerTwo.moveRight = true;
            }

            if (e.KeyCode == Keys.A)
            {
                playerTwo.moveLeft = true;
            }


            if (playerTwo.jump != true)
            {
                if (e.KeyCode == Keys.W)
                {
                    playerTwo.jump = true;
                    playerTwo.gravityOfPlayer = playerTwo.forceOfJump;
                }
            }
        }

        private void HandlePlayerOneKeyReleases(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                playerOne.moveRight = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                playerOne.moveLeft = false;
            }
        }

        private void HandlePlayerTwoKeyReleases(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                playerTwo.moveRight = false;
            }

            if (e.KeyCode == Keys.A)
            {
                playerTwo.moveLeft = false;
            }
        }
  
        public void RestartGame()
        {
            playerOne.scoreForPlayerOne = 0;
            playerTwo.scoreForPlayerTwo = 0;
            player1ScoreLbl.Text = "0";
            player2ScoreLbl.Text = "0";
            timer1.Enabled = true;
            gameOverLbl.Visible = false;
            blueWinsLbl.Visible = false;
            redWinsLbl.Visible = false;
        }
    }
}
