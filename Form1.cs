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

                string[] linhas = txtDados.Text.Split(
                    new string[] { Environment.NewLine, ";"},
                       StringSplitOptions.None);

                var pictureBoxList = new List<PictureBox>();

                foreach (var i in pictureBoxList)
                {
                    Image imagemQRCode;
                    String dados = linhas[Convert.ToInt32(i)] + " - " + cboCurso.Text;
                    imagemQRCode = qrCodecEncoder.Encode(dados);

                    var nomePicturebox = "pbQR" + i;

                    var controles = this.Controls.Find(nomePicturebox,true);

                    if (controles.Length > 0)
                    {
                        PictureBox pictureBox = (PictureBox)controles[0];
                        pictureBox.Image = imagemQRCode;
                    }
                    
                    
                }

                    
                    //string a ser Gerada

                   


                    

                    

                   
                    

                    

                    

                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          

          
           


            //txtDados.Text = i.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtDados.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] linhas = txtDados.Text.Split(
                     new string[] { Environment.NewLine },
                        StringSplitOptions.None);

            MessageBox.Show(linhas.First());
        }
    }


}

