using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCADARD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath graf = new GraphicsPath();
            graf.AddRectangle(new Rectangle(1, 1, this.Width, this.Height));

            // Canto superior esquerdo
            graf.AddRectangle(new Rectangle(1, 1, 25, 25));
            graf.AddPie(1, 1, 50, 50, 180, 90);

            // Canto superior direito
            graf.AddRectangle(new Rectangle(this.Width - 24, 1, 24, 26));
            graf.AddPie(this.Width - 48, 1, 48, 52, 270 ,90);

            // Canto inferior esquedro
            graf.AddRectangle(new Rectangle(1, this.Height - 20, 20, 20));
            graf.AddPie(1, this.Height - 40, 40, 40, 90, 90);

            // Canto inferior direito
            graf.AddRectangle(new Rectangle(this.Width - 24, this.Height - 26, 26, 26));
            graf.AddPie(this.Width - 48, this.Height - 52, 48, 52, 0, 90);

            graf.SetMarkers();
            this.Region = new Region(graf);
        }
        private bool mover;
        private int cx, cy;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                cx = e.X;
                cy = e.Y;
                mover = true;
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                mover = false;
            }
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath grafe = new GraphicsPath();
            grafe.AddRectangle(new Rectangle(1, 1, button1.Width, button1.Height));

            // Canto superior esquerdo
            grafe.AddRectangle(new Rectangle(1, 1, 5, 5));
            grafe.AddPie(1, 1, 10, 10, 180, 90);

            // Canto superior direito
            grafe.AddRectangle(new Rectangle(button1.Width - 6, 1, 6, 7));
            grafe.AddPie(button1.Width - 12, 1, 12, 14, 270, 90);

            // Canto inferior esquedro
            grafe.AddRectangle(new Rectangle(1, button1.Height - 5, 5, 5));
            grafe.AddPie(1, button1.Height - 10, 10, 10, 90, 90);

            // Canto inferior direito
            grafe.AddRectangle(new Rectangle(button1.Width - 7, button1.Height - 7, 7, 7));
            grafe.AddPie(button1.Width - 14, button1.Height - 14, 14, 14, 0, 90);

            grafe.SetMarkers();
            button1.Region = new Region(grafe);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            button1.BackColor = button1.FlatAppearance.MouseOverBackColor;
            button2.BackColor = panel2.BackColor;
            button3.BackColor = panel2.BackColor;
            button4.BackColor = panel2.BackColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = panel2.BackColor;
            button2.BackColor = button1.FlatAppearance.MouseOverBackColor;
            button3.BackColor = panel2.BackColor;
            button4.BackColor = panel2.BackColor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = panel2.BackColor;
            button2.BackColor = panel2.BackColor;
            button3.BackColor = button1.FlatAppearance.MouseOverBackColor;
            button4.BackColor = panel2.BackColor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = panel2.BackColor;
            button2.BackColor = panel2.BackColor;
            button3.BackColor = panel2.BackColor;
            button4.BackColor = button1.FlatAppearance.MouseOverBackColor;
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath grafe = new GraphicsPath();
            grafe.AddRectangle(new Rectangle(1, 1, button2.Width, button2.Height));

            // Canto superior esquerdo
            grafe.AddRectangle(new Rectangle(1, 1, 5, 5));
            grafe.AddPie(1, 1, 10, 10, 180, 90);

            // Canto superior direito
            grafe.AddRectangle(new Rectangle(button2.Width - 6, 1, 6, 7));
            grafe.AddPie(button1.Width - 12, 1, 12, 14, 270, 90);

            // Canto inferior esquedro
            grafe.AddRectangle(new Rectangle(1, button2.Height - 5, 5, 5));
            grafe.AddPie(1, button1.Height - 10, 10, 10, 90, 90);

            // Canto inferior direito
            grafe.AddRectangle(new Rectangle(button2.Width - 7, button2.Height - 7, 7, 7));
            grafe.AddPie(button2.Width - 14, button2.Height - 14, 14, 14, 0, 90);

            grafe.SetMarkers();
            button2.Region = new Region(grafe);
        }

        private void button3_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath grafe = new GraphicsPath();
            grafe.AddRectangle(new Rectangle(1, 1, button2.Width, button2.Height));

            // Canto superior esquerdo
            grafe.AddRectangle(new Rectangle(1, 1, 5, 5));
            grafe.AddPie(1, 1, 10, 10, 180, 90);

            // Canto superior direito
            grafe.AddRectangle(new Rectangle(button2.Width - 6, 1, 6, 7));
            grafe.AddPie(button1.Width - 12, 1, 12, 14, 270, 90);

            // Canto inferior esquedro
            grafe.AddRectangle(new Rectangle(1, button2.Height - 5, 5, 5));
            grafe.AddPie(1, button1.Height - 10, 10, 10, 90, 90);

            // Canto inferior direito
            grafe.AddRectangle(new Rectangle(button2.Width - 7, button2.Height - 7, 7, 7));
            grafe.AddPie(button2.Width - 14, button2.Height - 14, 14, 14, 0, 90);

            grafe.SetMarkers();
            button3.Region = new Region(grafe);
        }

        private void button4_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath grafe = new GraphicsPath();
            grafe.AddRectangle(new Rectangle(1, 1, button2.Width, button2.Height));

            // Canto superior esquerdo
            grafe.AddRectangle(new Rectangle(1, 1, 5, 5));
            grafe.AddPie(1, 1, 10, 10, 180, 90);

            // Canto superior direito
            grafe.AddRectangle(new Rectangle(button2.Width - 6, 1, 6, 7));
            grafe.AddPie(button1.Width - 12, 1, 12, 14, 270, 90);

            // Canto inferior esquedro
            grafe.AddRectangle(new Rectangle(1, button2.Height - 5, 5, 5));
            grafe.AddPie(1, button1.Height - 10, 10, 10, 90, 90);

            // Canto inferior direito
            grafe.AddRectangle(new Rectangle(button2.Width - 7, button2.Height - 7, 7, 7));
            grafe.AddPie(button2.Width - 14, button2.Height - 14, 14, 14, 0, 90);

            grafe.SetMarkers();
            button4.Region = new Region(grafe);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = button1.FlatAppearance.MouseOverBackColor;
        }

        private void dashboard11_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath grafe = new GraphicsPath();
            grafe.AddRectangle(new Rectangle(1, 1, pictureBox1.Width, pictureBox1.Height));

            // Canto inferior direito
            grafe.AddRectangle(new Rectangle(panel3.Width - 24, panel3.Height - 26, 26, 26));
            grafe.AddPie(panel3.Width - 48, pictureBox1.Height - 52, 48, 52, 0, 90);

            grafe.SetMarkers();
            panel3.Region = new Region(grafe);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                this.Left += e.X - (cx - (panel2.Left - panel2.Location.X));
                this.Top += e.Y - (cy - (panel2.Top - panel2.Location.Y));
            }
        }
    }
}
