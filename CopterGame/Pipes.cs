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
    public partial class Pipes : UserControl
    {
        public Pipes()
        {
            InitializeComponent();
        }

        public bool CheckCollision(Copter c)
        {
            //Collide with pipes
            if (this.Bounds.IntersectsWith(c.Bounds))
            {
                return true;
            }
            return false;
        }

        public bool CheckPoint(Copter c)
        {
            if (c.Bounds.IntersectsWith(picPoint.Bounds))
                return true;
            else
                return false;
        }

        private void Pipes_Load(object sender, EventArgs e)
        {

        }

        private void picBot_Click(object sender, EventArgs e)
        {

        }
    }
}
