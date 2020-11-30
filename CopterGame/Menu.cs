using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace CopterGame
{
    public partial class Menu : Form
    {
        // User Name Variable
        public string user = "User";
        public Menu()
        {
            InitializeComponent();
        }

        private void CopterGameButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            user = this.nameField.Text;
            new CopterGame(user).Show();
        }

        private void TrexGameButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            user = this.nameField.Text;
            new DinosaurGame(user).Show();
        }

        private void nameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // Get the scores from text file
            using (StreamReader sr = File.OpenText("DinoGame.txt"))
            {
                List<int> scores = new List<int>() ;
                while (sr.Peek() >= 0)
                {
                    int n = Convert.ToInt32( sr.ReadLine());
                    scores.Add(n);
                }

                // Find max score and write in variables.
                this.dinoScore.Text = "Highest Score: "+ scores.Max<int>();
            }
        }
    }
}
