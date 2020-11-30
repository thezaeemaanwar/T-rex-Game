using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace CopterGame
{
    public partial class DinosaurGame : Form
    {
        // Timers
        Timer tmrUp = new Timer();
        Timer tmrDown = new Timer();
        Timer tmrAlive = new Timer();
        Timer tmrGameLogic = new Timer();

        // jump of dino
        int move;
        // speed of obstacle
        int obstacleSpeed;
        //score of player
        int score;

        // New dinosaur and obstacles
        dinosaur dinosaur = new dinosaur();
        Obstacles obstacles = new Obstacles();
        
        public DinosaurGame(string username)
        {
            InitializeComponent();
            StartGame();
            userName.Text = username;
        }
        private void StartGame()
        {
            score = 0;
            gameOverLabel.Visible = label1.Visible = false;
            move = 12;
            obstacleSpeed = 5;
            dScore.Text = "Score: 0";
            
            // Add the dinosaur
            dinosaur.New();
            dinosaur.Location = new Point(153, 300);
            this.Controls.Add(dinosaur);

            //Make sure the dinosaur doesn't float behind the obstacles
            dinosaur.BringToFront();

            dinosaur.MouseDown += DinosaurGame_MouseDown;
            dinosaur.MouseUp += DinosaurGame_MouseUp;
            obstacles.MouseUp += DinosaurGame_MouseUp;
            obstacles.MouseDown += DinosaurGame_MouseDown;

            //Setup events fot timer
            tmrUp.Tick += TmrUP_Tick;
            tmrDown.Tick += TmrDown_Tick;
            tmrAlive.Tick += TmrAlive_Tick;
            tmrGameLogic.Tick += TmrGameLogic_Tick;

            //Determine gravity speed
            tmrDown.Interval = 20;
            tmrUp.Interval = 10;

            //Initial location 
            obstacles.Location = new Point(1200, 300);
            obstacles.BringToFront();
            this.Controls.Add(obstacles);

            tmrGameLogic.Interval = 20;
            tmrGameLogic.Start();
        }
        private void EndGame()
        {
            // the Game is stopped
            tmrGameLogic.Stop();
            // Loser Label shown
            gameOverLabel.Visible = label1.Visible = true;
            dinosaur.Kill();
            // write the score to file
            using(StreamWriter sw = File.AppendText("DinoGame.txt"))
            {
                sw.WriteLine(score);
            }
        }
        private void TmrGameLogic_Tick(object sender, EventArgs e)
        {
            obstacles.Location = new Point(obstacles.Location.X - obstacleSpeed, obstacles.Location.Y);
            
            if (obstacles.CheckCollision(dinosaur))
            {
                //Kill the dinosaur, because we collided with environment
                EndGame();
            }
            if (obstacles.Location.X == 150 )
            {
                score += 5;
                dScore.Text = "Score: " + score;
                // Increment the speed every 50 score
                if (score % 50 == 0)
                {
                    obstacleSpeed += 2;
                }
            }
            //check if the obstacle is off the screen, then reset it
            if (obstacles.Location.X < -150)
            {
                obstacles.Location = new Point(1200, 300);
            }
        }
        private void TmrAlive_Tick(object sender, EventArgs e)
        {
            if (dinosaur.Alive() == false)
            {
                tmrUp.Stop();
                tmrDown.Stop();
                tmrGameLogic.Stop();
            }
        }
        private void TmrDown_Tick(object sender, EventArgs e)
        {
            if (dinosaur.Location == new Point (dinosaur.Location.X, 300))
            {
                // Prevent dinosaur from going down
            }
            else
            {
                dinosaur.Location = new Point(dinosaur.Location.X, dinosaur.Location.Y + move);
            }
        }
        private void TmrUP_Tick(object sender, EventArgs e)
        {
            if (dinosaur.Top < 100)
            {
                // a limit for dinosaur to jump
                tmrDown.Start();
                tmrUp.Stop();
            }
            else
            {
                dinosaur.Location = new Point(dinosaur.Location.X, dinosaur.Location.Y - move);
            }
        }
        private void DinosaurGame_MouseUp(object sender, MouseEventArgs e)
        {
            //if player is alive, move it dowm
            if (dinosaur.Alive())
            {
                tmrUp.Stop();
                tmrDown.Start();
            }
        }
        private void DinosaurGame_MouseDown(object sender, MouseEventArgs e)
        {
            // Move dino above for jump
            if (dinosaur.Alive())
            {
                tmrUp.Start();
                tmrDown.Stop();   
            }
            
        }
        private void label1_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        
    }
}
