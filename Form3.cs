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
    public partial class Form3 : Form
    {
        Rectangle Circle = new Rectangle(50, 15, 20, 20);
        bool CircleClicked = false;
        int CircleX = 0;
        int CircleY = 0;
        public Form3()
        {
            InitializeComponent();
            Start();
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
                Form3 fp = new Form3();
                fp.Show();
                fp.WindowState = FormWindowState.Minimized;
                fp.WindowState = FormWindowState.Normal;
                this.Hide();

            }
            else
            {
                MainMenu mm = new MainMenu();
                mm.Show();
                mm.WindowState = FormWindowState.Minimized;
                mm.WindowState = FormWindowState.Normal;
                this.Hide();

            }
        }

        private void paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, Circle);
        }

        private void door(object sender, EventArgs e)
        {
            Point pointt;
            pointt = pictureBox5.Location;
            pointt.Offset(pictureBox5.Width / 2, pictureBox5.Height / 2);
            Cursor.Position = PointToScreen(pointt);
        }

        private void door2(object sender, EventArgs e)
        {
            Point pointt;
            pointt = pictureBox6.Location;
            pointt.Offset(pictureBox6.Width / 2, pictureBox6.Height / 2);
            Cursor.Position = PointToScreen(pointt);
        }

        private void win(object sender, EventArgs e)
        {
            Form2 op = new Form2();
            op.Show();
            op.WindowState = FormWindowState.Minimized;
            op.WindowState = FormWindowState.Normal;
            this.Hide();
        }



        private void cklck(object sender, EventArgs e)
        {
            label19.Hide();
            pictureBox2.Hide();
        }
        private void Start()
        {
            Point point;
            point = Circle.Location;
            point.Offset(Circle.Width / 2, Circle.Height / 2);
            Cursor.Position = PointToScreen(point);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox11.Hide();
            pictureBox3.Hide();
        }
    }
}
