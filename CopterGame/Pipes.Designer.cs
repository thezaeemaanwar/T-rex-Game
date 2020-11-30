namespace CopterGame
{
    partial class Pipes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBot = new System.Windows.Forms.PictureBox();
            this.picTop = new System.Windows.Forms.PictureBox();
            this.picPoint = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // picBot
            // 
            this.picBot.BackColor = System.Drawing.Color.Black;
            this.picBot.Location = new System.Drawing.Point(0, 485);
            this.picBot.Name = "picBot";
            this.picBot.Size = new System.Drawing.Size(54, 512);
            this.picBot.TabIndex = 0;
            this.picBot.TabStop = false;
            this.picBot.Click += new System.EventHandler(this.picBot_Click);
            // 
            // picTop
            // 
            this.picTop.BackColor = System.Drawing.Color.Black;
            this.picTop.Location = new System.Drawing.Point(0, -16);
            this.picTop.Name = "picTop";
            this.picTop.Size = new System.Drawing.Size(54, 293);
            this.picTop.TabIndex = 1;
            this.picTop.TabStop = false;
            // 
            // picPoint
            // 
            this.picPoint.BackColor = System.Drawing.Color.Black;
            this.picPoint.Location = new System.Drawing.Point(51, 247);
            this.picPoint.Name = "picPoint";
            this.picPoint.Size = new System.Drawing.Size(54, 293);
            this.picPoint.TabIndex = 3;
            this.picPoint.TabStop = false;
            this.picPoint.Visible = false;
            // 
            // Pipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.picPoint);
            this.Controls.Add(this.picTop);
            this.Controls.Add(this.picBot);
            this.Name = "Pipes";
            this.Size = new System.Drawing.Size(108, 1179);
            this.Load += new System.EventHandler(this.Pipes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPoint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBot;
        private System.Windows.Forms.PictureBox picTop;
        private System.Windows.Forms.PictureBox picPoint;
    }
}
