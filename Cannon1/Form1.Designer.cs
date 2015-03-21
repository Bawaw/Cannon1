namespace Cannon1
{
    partial class Form1
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
            this.Player = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.Projectile = new System.Windows.Forms.PictureBox();
            this.GameUpdate = new System.Windows.Forms.Timer(this.components);
            this.LivesDisplay = new System.Windows.Forms.PictureBox();
            this.TitleScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Projectile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LivesDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Enabled = false;
            this.Player.Location = new System.Drawing.Point(128, 220);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(32, 32);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // Enemy
            // 
            this.Enemy.Enabled = false;
            this.Enemy.Location = new System.Drawing.Point(145, -32);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(32, 32);
            this.Enemy.TabIndex = 1;
            this.Enemy.TabStop = false;
            // 
            // Projectile
            // 
            this.Projectile.Enabled = false;
            this.Projectile.Location = new System.Drawing.Point(165, 12);
            this.Projectile.Name = "Projectile";
            this.Projectile.Size = new System.Drawing.Size(8, 8);
            this.Projectile.TabIndex = 2;
            this.Projectile.TabStop = false;
            // 
            // GameUpdate
            // 
            this.GameUpdate.Enabled = true;
            this.GameUpdate.Interval = 16;
            this.GameUpdate.Tick += new System.EventHandler(this.GameUpdate_Tick);
            // 
            // LivesDisplay
            // 
            this.LivesDisplay.Enabled = false;
            this.LivesDisplay.Location = new System.Drawing.Point(12, 12);
            this.LivesDisplay.Name = "LivesDisplay";
            this.LivesDisplay.Size = new System.Drawing.Size(48, 16);
            this.LivesDisplay.TabIndex = 3;
            this.LivesDisplay.TabStop = false;
            // 
            // TitleScreen
            // 
            this.TitleScreen.Enabled = false;
            this.TitleScreen.Location = new System.Drawing.Point(194, 116);
            this.TitleScreen.Name = "TitleScreen";
            this.TitleScreen.Size = new System.Drawing.Size(32, 32);
            this.TitleScreen.TabIndex = 4;
            this.TitleScreen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.TitleScreen);
            this.Controls.Add(this.LivesDisplay);
            this.Controls.Add(this.Projectile);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.Player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cannon 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Projectile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LivesDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.PictureBox Projectile;
        private System.Windows.Forms.Timer GameUpdate;
        private System.Windows.Forms.PictureBox LivesDisplay;
        private System.Windows.Forms.PictureBox TitleScreen;
    }
}

