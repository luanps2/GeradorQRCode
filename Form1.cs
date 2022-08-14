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
            Limpar();
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

                string[] nomes = txtDados.Text.Split(
                    new string[] { Environment.NewLine, ";"},
                       StringSplitOptions.None);

                var pictureBoxList = new List<PictureBox>();

                int posicaoContadora = 0;

                

                //var largura = (Convert.ToInt32(panel1.Size.Width.ToString()) / 5) - 5;
                //var altura = (Convert.ToInt32(panel1.Size.Height.ToString()) / 4) - 5;

                foreach (var nome in nomes)
                {
                    Image imagemQRCode;

                    imagemQRCode = qrCodecEncoder.Encode(nome + " - " + cboCurso.Text);


                    var nomePicturebox = "pbQR" + posicaoContadora;
                    var nomeLabel = "lblNome" + posicaoContadora;


                    var imgsQR = panel1.Controls.Find(nomePicturebox, true);
                    var nomesQR = panel1.Controls.Find(nomeLabel, true);

                    

                    if (imgsQR.Length > 0)
                    {
                        foreach (PictureBox imgQR in imgsQR)
                        {
                            imgQR.Image = imagemQRCode;
                        }

                        foreach (Label nomeQR in nomesQR)
                        {
                            nomeQR.Text = nome;
                        }

                        foreach (Label nomeusuario in nomesusuarios)
                        {
                            nomeusuario.Text = nome;
                        }
                      
                        
                    }

                    //PictureBox pictureBox = new PictureBox
                    //{
                    //    Name = "pbQR",
                    //    Size = new Size(100, 100),
                    //    Image = imagemQRCode,
                    //    SizeMode = PictureBoxSizeMode.CenterImage
                    //};

                    //pictureBox.Visible = true;
                    //pictureBox.Show();


                    //panel1.Controls.Add(pictureBox);
                    posicaoContadora++;
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
            Limpar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] linhas = txtDados.Text.Split(
                     new string[] { Environment.NewLine },
                        StringSplitOptions.None);

            MessageBox.Show(linhas.First());
        }


        public void Limpar()
        {
            int posicaoContadora = 0;

            string[] nomes = txtDados.Text.Split(
                 new string[] { Environment.NewLine, ";" },
                    StringSplitOptions.None);

            foreach (var nome in nomes)
            {



                var nomePicturebox = "pbQR" + posicaoContadora;
                var nomeLabel = "lblNome" + posicaoContadora;


                var imgsQR = panel1.Controls.Find(nomePicturebox, true);
                var nomesQR = panel1.Controls.Find(nomeLabel, true);


                if (imgsQR.Length > 0)
                {
                    foreach (PictureBox imgQR in imgsQR)
                    {
                        imgQR.Image = null;
                    }


                    foreach (Label nomeQR in nomesQR)
                    {
                        nomeQR.Text = "";
                    }

                }

                //PictureBox pictureBox = new PictureBox
                //{
                //    Name = "pbQR",
                //    Size = new Size(100, 100),
                //    Image = imagemQRCode,
                //    SizeMode = PictureBoxSizeMode.CenterImage
                //};

                //pictureBox.Visible = true;
                //pictureBox.Show();


                //panel1.Controls.Add(pictureBox);
                posicaoContadora++;
            }
            txtDados.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}

