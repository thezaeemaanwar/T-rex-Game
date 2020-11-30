namespace CopterGame
{
    partial class Menu
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
            this.CopterGameButton = new System.Windows.Forms.Button();
            this.TrexGameButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.copterScore = new System.Windows.Forms.Label();
            this.dinoScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CopterGameButton
            // 
            this.CopterGameButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CopterGameButton.FlatAppearance.BorderSize = 0;
            this.CopterGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CopterGameButton.Font = new System.Drawing.Font("Lobster 1.4", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopterGameButton.ForeColor = System.Drawing.Color.White;
            this.CopterGameButton.Location = new System.Drawing.Point(161, 286);
            this.CopterGameButton.Name = "CopterGameButton";
            this.CopterGameButton.Size = new System.Drawing.Size(145, 48);
            this.CopterGameButton.TabIndex = 2;
            this.CopterGameButton.Text = "Play";
            this.CopterGameButton.UseVisualStyleBackColor = false;
            this.CopterGameButton.Click += new System.EventHandler(this.CopterGameButton_Click);
            // 
            // TrexGameButton
            // 
            this.TrexGameButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TrexGameButton.FlatAppearance.BorderSize = 0;
            this.TrexGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TrexGameButton.Font = new System.Drawing.Font("Lobster 1.4", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrexGameButton.ForeColor = System.Drawing.Color.White;
            this.TrexGameButton.Location = new System.Drawing.Point(493, 286);
            this.TrexGameButton.Name = "TrexGameButton";
            this.TrexGameButton.Size = new System.Drawing.Size(145, 48);
            this.TrexGameButton.TabIndex = 3;
            this.TrexGameButton.Text = "Play";
            this.TrexGameButton.UseVisualStyleBackColor = false;
            this.TrexGameButton.Click += new System.EventHandler(this.TrexGameButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CopterGame.Properties.Resources.dead;
            this.pictureBox2.Location = new System.Drawing.Point(551, 207);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CopterGame.Properties.Resources.planeFlying;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(146, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Your Name :";
            // 
            // nameField
            // 
            this.nameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameField.Location = new System.Drawing.Point(363, 94);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(275, 35);
            this.nameField.TabIndex = 5;
            this.nameField.TextChanged += new System.EventHandler(this.nameField_TextChanged);
            // 
            // copterScore
            // 
            this.copterScore.AutoSize = true;
            this.copterScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copterScore.Location = new System.Drawing.Point(157, 361);
            this.copterScore.Name = "copterScore";
            this.copterScore.Size = new System.Drawing.Size(165, 24);
            this.copterScore.TabIndex = 7;
            this.copterScore.Text = "Highest Score: 0";
            // 
            // dinoScore
            // 
            this.dinoScore.AutoSize = true;
            this.dinoScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinoScore.Location = new System.Drawing.Point(489, 361);
            this.dinoScore.Name = "dinoScore";
            this.dinoScore.Size = new System.Drawing.Size(165, 24);
            this.dinoScore.TabIndex = 8;
            this.dinoScore.Text = "Highest Score: 0";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dinoScore);
            this.Controls.Add(this.copterScore);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrexGameButton);
            this.Controls.Add(this.CopterGameButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button CopterGameButton;
        private System.Windows.Forms.Button TrexGameButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label copterScore;
        private System.Windows.Forms.Label dinoScore;
    }
}