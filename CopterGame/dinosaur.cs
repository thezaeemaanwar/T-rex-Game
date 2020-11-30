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
    public partial class dinosaur : UserControl
    {
        private bool isAlive;
        public dinosaur()
        {
            InitializeComponent();
            isAlive = true;
        }

        private void dinosaur_Load(object sender, EventArgs e)
        {

        }
        public bool Alive()
        {
            return this.isAlive;
        }
        public void Kill()
        {
            this.isAlive = false;
            pictureBox1.Image = Properties.Resources.dead;
        }
        public void New()
        {
            this.isAlive = true;
            pictureBox1.Image = Properties.Resources.running;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
