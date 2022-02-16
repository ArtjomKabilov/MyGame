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
            if ((pictureBox3.Location.X < Circle.X + Circle.Width) && (pictureBox3.Location.X > Circle.X))
            {
                if ((pictureBox3.Location.Y < Circle.Y + Circle.Height) && (pictureBox3.Location.Y > Circle.Y))
                {
                    pictureBox11.Hide();
                    pictureBox3.Hide();
                }
            }
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
            
            var answer = MessageBox.Show(
                "Ты проиграл, нельзя касаться чёрных полос, хочешь повторить",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (answer == DialogResult.Yes)
            {
                Form1 fp = new Form1();
                fp.Show();
                fp.WindowState = FormWindowState.Minimized;
                fp.WindowState = FormWindowState.Normal;
                this.Hide();

            }
            else
            {
                this.Close();

            }
            
        }

        private void Click(object sender, MouseEventArgs e)
        {
            pictureBox11.Hide();
            pictureBox3.Hide();
        }

        private void win(object sender, EventArgs e)
        {
            Form2 op = new Form2();
            op.Show();
            op.WindowState = FormWindowState.Minimized;
            op.WindowState = FormWindowState.Normal;
            this.Hide();
        }

        private void door(object sender, EventArgs e)
        {
            Point pointt;
            pointt = pictureBox33.Location;
            pointt.Offset(pictureBox33.Width / 2, pictureBox33.Height / 2);
            Cursor.Position = PointToScreen(pointt);
        }
    }
}
