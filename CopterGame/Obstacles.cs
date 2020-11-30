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
    public partial class Obstacles : UserControl
    {
        public Obstacles()
        {
            InitializeComponent();
        }

        public bool CheckCollision(dinosaur dino)
        {
            if (dino.Bounds.IntersectsWith(this.Bounds))
            {
                return true;
            }
            return false;
        }
        private void Obstacles_Load(object sender, EventArgs e)
        {

        }
    }
}
