namespace CopterGame
{
    partial class DinosaurGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.userName = new System.Windows.Forms.Label();
            this.dScore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.Color.Black;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.White;
            this.userName.Location = new System.Drawing.Point(16, 18);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(57, 25);
            this.userName.TabIndex = 0;
            this.userName.Text = "User";
            // 
            // dScore
            // 
            this.dScore.AutoSize = true;
            this.dScore.BackColor = System.Drawing.Color.Black;
            this.dScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dScore.ForeColor = System.Drawing.Color.White;
            this.dScore.Location = new System.Drawing.Point(673, 20);
            this.dScore.Name = "dScore";
            this.dScore.Size = new System.Drawing.Size(92, 25);
            this.dScore.TabIndex = 1;
            this.dScore.Text = "Score: 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-12, 357);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(913, 93);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.BackColor = System.Drawing.Color.Black;
            this.gameOverLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameOverLabel.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.White;
            this.gameOverLabel.Location = new System.Drawing.Point(207, 146);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Padding = new System.Windows.Forms.Padding(40);
            this.gameOverLabel.Size = new System.Drawing.Size(372, 130);
            this.gameOverLabel.TabIndex = 3;
            this.gameOverLabel.Text = "GAME OVER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 257);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(165, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "click to restart";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DinosaurGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CopterGame.Properties.Resources.small_stars;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dScore);
            this.Controls.Add(this.userName);
            this.DoubleBuffered = true;
            this.Name = "DinosaurGame";
            this.Text = "DinosaurGame";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DinosaurGame_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DinosaurGame_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label dScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label label1;
    }
}