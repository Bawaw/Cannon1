using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cannon1
{
    public partial class Form1 : Form
    {
        const int SCREENWIDTH = 640;
        const int SCREENHEIGHT = 480;

        const int PPOJECTILESPEED = 12;
        const int BASETARGETSPEED = 8;
        const float COLLISIONDISTANCE = 20.0f;
        const int STARTINGLIVES = 3;
        const int LIVESTYLEWIDTH = 16;
        const int DIFFICULTY = 3;

        int targetVelocityX;
        int targetVelocityY;

        bool GameRun = false;
        int lives;
        int level;

        Random random; 

        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new Size(SCREENWIDTH, SCREENHEIGHT);
            random = new Random();

        }
        #region event

        private void Form1_Load(object sender, EventArgs e)
        {
            Player.Load("player.png");
            Projectile.Load("projectile.png");
            Enemy.Load("target.png");
            LivesDisplay.Load("lives.png");
            TitleScreen.Load("title_screen.png");
            TitleScreen.Left = 0;
            TitleScreen.Top = 0;
            TitleScreen.Width = SCREENWIDTH;
            TitleScreen.Height = SCREENHEIGHT;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Player.Left = e.X - (Player.Width/2);
            Player.Top = SCREENHEIGHT - Player.Height;
        }

        private void GameUpdate_Tick(object sender, EventArgs e)
        {
            Projectile.Top -= PPOJECTILESPEED;

            Enemy.Top += targetVelocityY;
            Enemy.Left += targetVelocityX;

            checkGroundCollision();
            checkAirCollison();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (GameRun)
            {
                fireProjectile();
            }
            else 
            {
                beginGame();
            }
        }
        #endregion

        #region Methods

        private void beginGame()
        {
            GameRun = true;
            lives = STARTINGLIVES;
            level = 1;

            displayLives();
            resetProjectile();
            resetTarget();

            TitleScreen.Hide();
            Cursor.Hide();
        }
        private void endGame()
        {
            GameRun = false;
            TitleScreen.Show();
            Cursor.Show();
        }
        private void killPlayer()
        {
            resetTarget();

            lives--;
            displayLives();

            if (lives == 0)
            {
                endGame();
            }
        
        }

        private void killTarget()
        {
            level++;
            resetTarget();
            resetProjectile();
            
        }

        private void displayLives()
        {
            LivesDisplay.Width = lives * LIVESTYLEWIDTH;
        }

        private void fireProjectile()
        {
            if (Projectile.Bottom < 0)
            {
                Projectile.Left = Player.Left + Player.Width / 2 - Projectile.Width / 2;
                Projectile.Top = Player.Top;  
            }
        }

        private void resetProjectile()
        {
            Projectile.Top = -Projectile.Height;
        }

        private void resetTarget()
        {
            targetVelocityX =  random.Next(2,6);
            targetVelocityY = BASETARGETSPEED + level/ DIFFICULTY;
            if (random.Next(2) == 0)
            {
                targetVelocityX *= -1;
            }

            Enemy.Top = -Enemy.Height;
            Enemy.Left = SCREENWIDTH / 2 - Enemy.Width / 2;
        }

        #endregion

        #region collision methods

        private void checkGroundCollision()
        {
            if (Enemy.Bottom > SCREENHEIGHT)
            {
                killPlayer();
            }
        }
        private void checkAirCollison()
        {
            Point projectileCenter = GetCenter(Projectile);
            Point targetCenter = GetCenter(Enemy);
            if (distance(projectileCenter, targetCenter) < COLLISIONDISTANCE) 
            {
                killTarget();
            }
        }

        #endregion 

        #region utilitie methods

        private Point GetCenter(Control C)
        {
            return new Point(C.Left + C.Width/2, C.Top + C.Height /2);
        }

        private float distance (Point pointA, Point pointB)
        {
            int a = pointA.X - pointB.X, 
                b = pointA.Y - pointB.Y;

            float c = (float)Math.Sqrt((a * a) + (b * b));

            return c;
        }

        #endregion 

       
    }
}
