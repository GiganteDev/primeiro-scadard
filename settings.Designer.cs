namespace SCADARD
{
    partial class settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBoxPort = new System.Windows.Forms.ComboBox();
            this.cbBoxBaud = new System.Windows.Forms.ComboBox();
            this.cbBoxData = new System.Windows.Forms.ComboBox();
            this.cbBoxStop = new System.Windows.Forms.ComboBox();
            this.cbBoxParity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCon = new System.Windows.Forms.Button();
            this.btnDesc = new System.Windows.Forms.Button();
            this.txtBoxRec = new System.Windows.Forms.TextBox();
            this.txtBoxEnviar = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.txtStatus = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 160);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serial Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(684, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Terminal";
            // 
            // cbBoxPort
            // 
            this.cbBoxPort.BackColor = System.Drawing.Color.White;
            this.cbBoxPort.FormattingEnabled = true;
            this.cbBoxPort.Location = new System.Drawing.Point(210, 245);
            this.cbBoxPort.Name = "cbBoxPort";
            this.cbBoxPort.Size = new System.Drawing.Size(121, 29);
            this.cbBoxPort.TabIndex = 4;
            // 
            // cbBoxBaud
            // 
            this.cbBoxBaud.BackColor = System.Drawing.Color.White;
            this.cbBoxBaud.FormattingEnabled = true;
            this.cbBoxBaud.Location = new System.Drawing.Point(210, 300);
            this.cbBoxBaud.Name = "cbBoxBaud";
            this.cbBoxBaud.Size = new System.Drawing.Size(121, 29);
            this.cbBoxBaud.TabIndex = 5;
            // 
            // cbBoxData
            // 
            this.cbBoxData.BackColor = System.Drawing.Color.White;
            this.cbBoxData.FormattingEnabled = true;
            this.cbBoxData.Location = new System.Drawing.Point(210, 355);
            this.cbBoxData.Name = "cbBoxData";
            this.cbBoxData.Size = new System.Drawing.Size(121, 29);
            this.cbBoxData.TabIndex = 6;
            // 
            // cbBoxStop
            // 
            this.cbBoxStop.BackColor = System.Drawing.Color.White;
            this.cbBoxStop.FormattingEnabled = true;
            this.cbBoxStop.Location = new System.Drawing.Point(210, 410);
            this.cbBoxStop.Name = "cbBoxStop";
            this.cbBoxStop.Size = new System.Drawing.Size(121, 29);
            this.cbBoxStop.TabIndex = 7;
            // 
            // cbBoxParity
            // 
            this.cbBoxParity.BackColor = System.Drawing.Color.White;
            this.cbBoxParity.FormattingEnabled = true;
            this.cbBoxParity.Location = new System.Drawing.Point(210, 465);
            this.cbBoxParity.Name = "cbBoxParity";
            this.cbBoxParity.Size = new System.Drawing.Size(121, 29);
            this.cbBoxParity.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "COM Port :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Baud Rate :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data Bits :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Stop Bits :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(141, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Parity :";
            // 
            // btnCon
            // 
            this.btnCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnCon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(77)))), ((int)(((byte)(143)))));
            this.btnCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCon.Location = new System.Drawing.Point(366, 245);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(183, 29);
            this.btnCon.TabIndex = 14;
            this.btnCon.Text = "Conectar";
            this.btnCon.UseVisualStyleBackColor = false;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // btnDesc
            // 
            this.btnDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnDesc.Enabled = false;
            this.btnDesc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(77)))), ((int)(((byte)(143)))));
            this.btnDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesc.Location = new System.Drawing.Point(366, 300);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(183, 29);
            this.btnDesc.TabIndex = 15;
            this.btnDesc.Text = "Desconectar";
            this.btnDesc.UseVisualStyleBackColor = false;
            this.btnDesc.Click += new System.EventHandler(this.btnDesc_Click);
            // 
            // txtBoxRec
            // 
            this.txtBoxRec.Location = new System.Drawing.Point(580, 224);
            this.txtBoxRec.Multiline = true;
            this.txtBoxRec.Name = "txtBoxRec";
            this.txtBoxRec.ReadOnly = true;
            this.txtBoxRec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxRec.Size = new System.Drawing.Size(284, 321);
            this.txtBoxRec.TabIndex = 17;
            // 
            // txtBoxEnviar
            // 
            this.txtBoxEnviar.Location = new System.Drawing.Point(366, 412);
            this.txtBoxEnviar.Name = "txtBoxEnviar";
            this.txtBoxEnviar.Size = new System.Drawing.Size(183, 27);
            this.txtBoxEnviar.TabIndex = 18;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(77)))), ((int)(((byte)(143)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Location = new System.Drawing.Point(366, 460);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(183, 29);
            this.btnEnviar.TabIndex = 19;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.Red;
            this.pnlStatus.Controls.Add(this.txtStatus);
            this.pnlStatus.Location = new System.Drawing.Point(366, 355);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(182, 28);
            this.pnlStatus.TabIndex = 20;
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(40, 2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(102, 23);
            this.txtStatus.TabIndex = 0;
            this.txtStatus.Text = "Open Port";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 21;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtBoxEnviar);
            this.Controls.Add(this.txtBoxRec);
            this.Controls.Add(this.btnDesc);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbBoxParity);
            this.Controls.Add(this.cbBoxStop);
            this.Controls.Add(this.cbBoxData);
            this.Controls.Add(this.cbBoxBaud);
            this.Controls.Add(this.cbBoxPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "settings";
            this.Size = new System.Drawing.Size(877, 562);
            this.Load += new System.EventHandler(this.settings_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.settings_Paint);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBoxPort;
        private System.Windows.Forms.ComboBox cbBoxBaud;
        private System.Windows.Forms.ComboBox cbBoxData;
        private System.Windows.Forms.ComboBox cbBoxStop;
        private System.Windows.Forms.ComboBox cbBoxParity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.TextBox txtBoxRec;
        private System.Windows.Forms.TextBox txtBoxEnviar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label txtStatus;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
