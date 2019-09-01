namespace SCADARD
{
    partial class dash
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlLed1 = new System.Windows.Forms.Panel();
            this.pnlLed2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 160);
            this.panel1.TabIndex = 1;
            // 
            // pnlLed1
            // 
            this.pnlLed1.BackColor = System.Drawing.Color.Maroon;
            this.pnlLed1.Location = new System.Drawing.Point(61, 262);
            this.pnlLed1.Name = "pnlLed1";
            this.pnlLed1.Size = new System.Drawing.Size(200, 100);
            this.pnlLed1.TabIndex = 2;
            this.pnlLed1.Click += new System.EventHandler(this.pnlLed1_Click);
            this.pnlLed1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLed1_Paint);
            // 
            // pnlLed2
            // 
            this.pnlLed2.BackColor = System.Drawing.Color.Maroon;
            this.pnlLed2.Location = new System.Drawing.Point(277, 262);
            this.pnlLed2.Name = "pnlLed2";
            this.pnlLed2.Size = new System.Drawing.Size(200, 100);
            this.pnlLed2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(558, 267);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 95);
            this.textBox1.TabIndex = 4;
            // 
            // dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pnlLed2);
            this.Controls.Add(this.pnlLed1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "dash";
            this.Size = new System.Drawing.Size(877, 562);
            this.Load += new System.EventHandler(this.dash_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.dash_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlLed1;
        private System.Windows.Forms.Panel pnlLed2;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}
