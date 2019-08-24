using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCADARD
{
    public partial class dashboard1 : UserControl
    {
        public dashboard1()
        {
            InitializeComponent();
        }

        private void dashboard1_Paint(object sender, PaintEventArgs e)
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
    }
}
