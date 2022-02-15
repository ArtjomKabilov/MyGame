using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    public partial class Form1 : Form
    {
        Rectangle Circle = new Rectangle(50, 430, 20, 20);
        bool CircleClicked = false;
        int CircleX = 0;
        int CircleY = 0;
        public Form1()
        {
            InitializeComponent();
            Start();
        }
        private void Start()
        {
            Point point;
            point = Circle.Location;
            point.Offset(Circle.Width / 2, Circle.Height / 2);
            Cursor.Position = PointToScreen(point);
        }
        private void paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, Circle);
            
        }

        private void move(object sender, MouseEventArgs e)
        {
            if (CircleClicked)
            {
                Circle.X = e.X - CircleX;
                Circle.Y = e.Y - CircleY;
            }
            
            pictureBox1.Invalidate();
            /*if ((pictureBox4.Location.X < Circle.X + Circle.Width) && (pictureBox4.Location.X > Circle.X))
            {
                if ((pictureBox4.Location.Y < Circle.Y + Circle.Height) && (pictureBox4.Location.Y > Circle.Y))
                {
                    MessageBox.Show("Ты проиграл, нельзя касаться чёрных полос", "Сообщение");
                }
            }*/
        }

        private void Down(object sender, MouseEventArgs e)
        {
            if ((e.X < Circle.X + Circle.Width) && (e.X > Circle.X))
            {
                if ((e.Y < Circle.Y + Circle.Height) && (e.Y > Circle.Y))
                {
                    CircleClicked = true;

                    CircleX = e.X - Circle.X;
                    CircleY = e.Y - Circle.Y;
                }
            }
        }

        private void up(object sender, MouseEventArgs e)
        {
            CircleClicked = false;
        }

        private void enter(object sender, EventArgs e)
        {
            MessageBox.Show("Ты проиграл, нельзя касаться чёрных полос", "Сообщение");
            this.Close();
        }
    }
}
