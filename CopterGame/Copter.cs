using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopterGame
{
    public partial class Copter : UserControl,IPlayer
    {
        private int score = 0;
        private bool alive = true;

        public Copter()
        {
            InitializeComponent();
        }

        public bool Alive()
        {
            return this.alive;
        }

        public void New()
        {
            alive = true;
            this.BackgroundImage = Properties.Resources.planeFlying;
        }

        public void GainPoint()
        {
            score++;
        }

        public int GetScore()
        {
            return this.score;
        }

        public void Kill()
        {
            alive = false;
            this.BackgroundImage = Properties.Resources.planeCrashed;
        }

        public bool TopScore()
        {
            throw new NotImplementedException();
        }

        private void Copter_Load(object sender, EventArgs e)
        {

        }
    }
}
