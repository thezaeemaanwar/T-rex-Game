using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopterGame
{
    public partial class CopterGame : Form
    {
        Timer tmrUP = new Timer();
        Timer tmrDown = new Timer();
        Timer tmrAlive = new Timer();
        Timer tmrGameLogic = new Timer();


        Copter copter = new Copter();
        //Something to keep track of, getting a point
        bool point = false;
        //The amount we will move
        public int move = 2;

        //pipes we can access
        Pipes pipes = new Pipes();
       
        public CopterGame(string username)
        {
            InitializeComponent();
            this.userName.Text = username;
            StartGame();
        }

        private void StartGame()
        {
            copter.New();
            restartLabel.Visible = gameOverLabel.Visible = false;
            //Add the actual helicopter to the form
            copter.Location = new Point(250, 150);
            this.Controls.Add(copter);

            //Make sure the copter doesn't float behind the pipes
            copter.BringToFront();
            copter.MouseDown += Form1_MouseDown;
            copter.MouseUp += Form1_MouseUp;
            pipes1.MouseUp += Form1_MouseUp;
            pipes1.MouseDown += Form1_MouseDown;

            //Setup events fot timer
            tmrUP.Tick += TmrUP_Tick;
            tmrDown.Tick += TmrDown_Tick;
            tmrAlive.Tick += TmrAlive_Tick;
            tmrGameLogic.Tick += TmrGameLogic_Tick;

            //Determine gravity speed
            tmrDown.Interval = 10;
            tmrUP.Interval = 10;

            //Initial
            pipes1.Location = new Point(1700, -50);
            this.Controls.Add(pipes1);

            tmrGameLogic.Interval = 20;
            tmrGameLogic.Start();
        }
        private void TmrGameLogic_Tick(object sender, EventArgs e)
        {
            pipes1.Location = new Point(pipes1.Location.X - 5, pipes1.Location.Y);
           
            if (pipes1.CheckCollision(copter)|| copter.Bounds.IntersectsWith(ground.Bounds))
            {
                //Kill the copter, because we collided with environment
                copter.Kill();
                tmrGameLogic.Stop();
                tmrDown.Stop();
                gameOverLabel.Visible = restartLabel.Visible = true;
            }

            //check if the first pipe is off the screen, then reset it
            if (pipes1.Location.X < -150)
            {
                pipes1.Location = new Point(700, -50);
            }
        }

        private void TmrAlive_Tick(object sender, EventArgs e)
        {
            if(copter.Alive() == false)
            {
                tmrUP.Stop();
                tmrDown.Stop();
                tmrGameLogic.Stop();
            }
        }

        private void TmrDown_Tick(object sender, EventArgs e)
        {
            copter.Location = new Point(copter.Location.X, copter.Location.Y + move);
        }

        private void TmrUP_Tick(object sender, EventArgs e)
        {
            copter.Location = new Point(copter.Location.X, copter.Location.Y - move);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //if player is alive, move it up
            if(copter.Alive())
            {
                //TODO: move the copter
                tmrDown.Start();
                tmrUP.Stop();
            }
            else
            {
                tmrDown.Stop();
                tmrUP.Stop();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(copter.Alive())
            {
                //Todo: move the copter
                tmrUP.Start();
                tmrDown.Stop();
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pipes1_Load(object sender, EventArgs e)
        {

        }

        private void restartLabel_Click(object sender, EventArgs e)
        {
            StartGame();
        }
    }
}
