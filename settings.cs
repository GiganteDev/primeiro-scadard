using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SCADARD
{
    public partial class settings : UserControl
    {
        
        delegate void funcaoRecepcao();
        public settings()
        {
            InitializeComponent();

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);

        }
        void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            funcaoRecepcao recepcaodelegate = new funcaoRecepcao(RecepcaoSerial);
            Invoke(recepcaodelegate);
        }
        public static String chtxt = null, str = null;
        public static int abc = 0;
        public void RecepcaoSerial()
        {
            System.Threading.Thread.Sleep(5);
            chtxt += serialPort1.ReadExisting();
            txtBoxRec.Text += chtxt;
            str = chtxt;
            chtxt = null;

            if (str.Length >= 8)
            {
                if(str.Substring(0,1).Equals("[")&& str.Substring(1, 1).Equals("L")&& str.Substring(2, 1).Equals("e")&& str.Substring(3, 1).Equals("D")&& str.Substring(4, 1).Equals("1")&& str.Substring(5, 1).Equals("O")&& str.Substring(6, 1).Equals("N")&& str.Substring(7, 1).Equals("]"))
                {
                    MudaCor(1);
                    textBox1.Text = "Acendeu";
                }
                else
                {
                    if (str.Substring(0, 1).Equals("[") && str.Substring(1, 1).Equals("L") && str.Substring(2, 1).Equals("e") && str.Substring(3, 1).Equals("D") && str.Substring(4, 1).Equals("1") && str.Substring(5, 1).Equals("O") && str.Substring(6, 1).Equals("F") && str.Substring(7, 1).Equals("]"))
                    {
                        MudaCor(2);
                        textBox1.Text = "Apagou";
                    }
                    else
                    {
                        if (str.Substring(0, 1).Equals("[") && str.Substring(1, 1).Equals("L") && str.Substring(2, 1).Equals("e") && str.Substring(3, 1).Equals("D") && str.Substring(4, 1).Equals("2") && str.Substring(5, 1).Equals("O") && str.Substring(6, 1).Equals("N") && str.Substring(7, 1).Equals("]"))
                        {
                            MudaCor(3);
                            textBox1.Text = "Acendeu";
                        }
                        else
                        {
                            if (str.Substring(0, 1).Equals("[") && str.Substring(1, 1).Equals("L") && str.Substring(2, 1).Equals("e") && str.Substring(3, 1).Equals("D") && str.Substring(4, 1).Equals("2") && str.Substring(5, 1).Equals("O") && str.Substring(6, 1).Equals("F") && str.Substring(7, 1).Equals("]"))
                            {
                                MudaCor(4);
                                textBox1.Text = "Apagou";
                            }
                        }
                    }
                }
            }



            int conttxt = 0;
            conttxt++;
            if (conttxt > 999)
            {
                txtBoxRec.Text = null;
            }
        }
        public static void MudaCor(int numero)
        {
            NovaClasse.mudeacor = numero;
        }
        private void settings_Paint(object sender, PaintEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void settings_Load(object sender, EventArgs e)
        {
            #region Config_Ports
            String[] valoresPort = SerialPort.GetPortNames();
            for(int i = 0; i < valoresPort.Length; i++)
            {
                cbBoxPort.Items.Add(valoresPort[i]);
            }
            cbBoxPort.Text = "COM1";
            #endregion

            #region Config_Baud
            int[] valoresBaud = { 2400, 4800, 9600, 19200, 57600, 115200 };
            for(int i = 0; i < valoresBaud.Length; i++)
            {
                cbBoxBaud.Items.Add(valoresBaud[i]);
            }
            cbBoxBaud.Text = "9600";
            #endregion

            #region Config_Data
            cbBoxData.Items.Add("7");
            cbBoxData.Items.Add("8");
            cbBoxData.Text = "8";
            #endregion

            #region Config_Stop
            cbBoxStop.Items.Add("None");
            cbBoxStop.Items.Add("One");
            cbBoxStop.Items.Add("Two");
            cbBoxStop.Text = "One";
            #endregion

            #region Config_Parity
            cbBoxParity.Items.Add("NONE");
            cbBoxParity.Items.Add("EVEN");
            cbBoxParity.Items.Add("ODD");
            cbBoxParity.Items.Add("MARK");
            cbBoxParity.Items.Add("SPACE");
            cbBoxParity.Text = "NONE";
            #endregion

        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            else
            {
                serialPort1.PortName = cbBoxPort.Text;
                serialPort1.BaudRate = int.Parse(cbBoxBaud.Text);
                serialPort1.DataBits = int.Parse(cbBoxData.Text);
                serialPort1.StopBits = (StopBits)(cbBoxStop.SelectedIndex);
                serialPort1.Parity = (Parity)(cbBoxParity.SelectedIndex);
            }

            try
            {
                serialPort1.Open();
                cbBoxPort.Enabled = false;
                cbBoxBaud.Enabled = false;
                cbBoxData.Enabled = false;
                cbBoxStop.Enabled = false;
                cbBoxParity.Enabled = false;
                btnCon.Enabled = false;
                btnDesc.Enabled = true;
                txtStatus.Text = "Close Port";
                pnlStatus.BackColor = Color.Green;
            }
            catch
            {
                MessageBox.Show("Erro ao se conectar!");
            }
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                cbBoxPort.Enabled = true;
                cbBoxBaud.Enabled = true;
                cbBoxData.Enabled = true;
                cbBoxStop.Enabled = true;
                cbBoxParity.Enabled = true;
                btnCon.Enabled = true;
                btnDesc.Enabled = false;
                txtStatus.Text = "Open Port";
                pnlStatus.BackColor = Color.Red;
            }
            catch
            {
                MessageBox.Show("Erro ao se conectar!");
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(txtBoxEnviar.Text);
                txtBoxEnviar.Text = null;
            }
            else
            {
                MessageBox.Show("Erro ao se conectar!");
            }
        }
    }
}
