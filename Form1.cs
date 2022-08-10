using MessagingToolkit.QRCode.Codec;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeradorQRCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                QRCodeEncoder qrCodecEncoder = new QRCodeEncoder();
                qrCodecEncoder.QRCodeBackgroundColor = System.Drawing.Color.White;
                qrCodecEncoder.QRCodeForegroundColor = System.Drawing.Color.Black;
                qrCodecEncoder.CharacterSet = "UTF-8";
                qrCodecEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                qrCodecEncoder.QRCodeScale = 2;
                qrCodecEncoder.QRCodeVersion = 0;
                qrCodecEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q;


                Image imagemQRCode;
                //string a ser Gerada
                String dados = txtDados.Text + "-" + comboBox1.Text;
                imagemQRCode = qrCodecEncoder.Encode(dados);
                pbQR1.Image = imagemQRCode;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtDados.Text = "";
        }
    }
}