namespace CopterGame
{
    partial class CopterGame
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
            this.pipes1 = new Pipes();
            this.userName = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            this.restartLabel = new System.Windows.Forms.Label();
            this.gameOverLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // pipes1
            // 
            this.pipes1.BackColor = System.Drawing.Color.Transparent;
            this.pipes1.Location = new System.Drawing.Point(815, -64);
            this.pipes1.Name = "pipes1";
            this.pipes1.Size = new System.Drawing.Size(150, 728);
            this.pipes1.TabIndex = 0;
            this.pipes1.Load += new System.EventHandler(this.pipes1_Load);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.Color.Black;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.White;
            this.userName.Location = new System.Drawing.Point(12, 9);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(57, 25);
            this.userName.TabIndex = 1;
            this.userName.Text = "User";
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Black;
            this.ground.Location = new System.Drawing.Point(-1, 521);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(966, 50);
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // restartLabel
            // 
            this.restartLabel.AutoSize = true;
            this.restartLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.restartLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartLabel.Location = new System.Drawing.Point(445, 325);
            this.restartLabel.Name = "restartLabel";
            this.restartLabel.Padding = new System.Windows.Forms.Padding(5);
            this.restartLabel.Size = new System.Drawing.Size(165, 31);
            this.restartLabel.TabIndex = 6;
            this.restartLabel.Text = "click to restart";
            this.restartLabel.Click += new System.EventHandler(this.restartLabel_Click);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.BackColor = System.Drawing.Color.Black;
            this.gameOverLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameOverLabel.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.White;
            this.gameOverLabel.Location = new System.Drawing.Point(339, 214);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Padding = new System.Windows.Forms.Padding(40);
            this.gameOverLabel.Size = new System.Drawing.Size(372, 130);
            this.gameOverLabel.TabIndex = 5;
            this.gameOverLabel.Text = "GAME OVER";
            // 
            // CopterGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 571);
            this.Controls.Add(this.restartLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.pipes1);
            this.Name = "CopterGame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Pipes pipes1;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label restartLabel;
        private System.Windows.Forms.Label gameOverLabel;
    }
}

