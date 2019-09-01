using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SCADARD
{
    public partial class dash : UserControl
    {
        public dash()
        {
            InitializeComponent();
        }

        private void dash_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath grafi = new GraphicsPath();
            grafi.AddRectangle(new Rectangle(1, 1, this.Width, this.Height));

            // Canto superior esquerdo
            grafi.AddRectangle(new Rectangle(1, 1, 10, 10));
            grafi.AddPie(1, 1, 20, 20, 180, 90);

            // Canto superior direito
            grafi.AddRectangle(new Rectangle(this.Width - 12, 1, 12, 13));
            grafi.AddPie(this.Width - 24, 1, 24, 26, 270, 90);

            // Canto inferior esquedro
            grafi.AddRectangle(new Rectangle(1, this.Height - 10, 10, 10));
            grafi.AddPie(1, this.Height - 20, 20, 20, 90, 90);

            // Canto inferior direito
            grafi.AddRectangle(new Rectangle(this.Width - 12, this.Height - 13, 13, 13));
            grafi.AddPie(this.Width - 24, this.Height - 26, 24, 26, 0, 90);

            grafi.SetMarkers();
            this.Region = new Region(grafi);

        }

        private void pnlLed1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlLed1_Click(object sender, EventArgs e)
        {

        }

        private void dash_Load(object sender, EventArgs e)
        {
            var t = new Thread(new ThreadStart(mudacor));
            t.Start();
        }
        public delegate void MudaPraVermelho();

        public void UpdateUI()
        {
            int op = 0;
            op = NovaClasse.mudeacor;
            if (op == 1)
            {
                pnlLed1.BackColor = Color.Red;
            }
            else
            {
                if (op == 2)
                {
                    pnlLed1.BackColor = Color.Maroon;
                }
                else
                {
                    if (op == 3)
                    {
                        pnlLed2.BackColor = Color.Red;
                    }
                    else
                    {
                        if (op == 4)
                        {
                            pnlLed2.BackColor = Color.Maroon;
                        }
                    }
                }
            }
            
        }
        public void mudacor()
        {
            while (true) {
                Thread.Sleep(0);
                try
                {
                    pnlLed1.Invoke(new MudaPraVermelho(UpdateUI));
                }
                catch
                {
                    break;
                }
            }
        }
    }
}
