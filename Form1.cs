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
            dpAno.Format = DateTimePickerFormat.Custom;
            dpAno.CustomFormat = "yyyy";
            dpAno.ShowUpDown = true;

            lblNome0.Text = "";
            lblNome1.Text = "";
            lblNome2.Text = "";
            lblNome3.Text = "";
            lblNome4.Text = "";
            lblNome5.Text = "";
            lblNome6.Text = "";
            lblNome7.Text = "";
            lblNome8.Text = "";
            lblNome9.Text = "";
            lblNome10.Text = "";
            lblNome11.Text = "";
            lblNome12.Text = "";
            lblNome13.Text = "";
            lblNome14.Text = "";
            lblNome15.Text = "";
            lblNome16.Text = "";
            lblNome17.Text = "";
            lblNome18.Text = "";
            lblNome19.Text = "";
            lblNome20.Text = "";
            lblNome21.Text = "";
            lblNome22.Text = "";
            lblNome23.Text = "";
            lblNome24.Text = "";
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
                    new string[] { Environment.NewLine, ";" },
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

                        foreach (Label nomeusuario in nomesQR)
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
            string[] nomes = txtDados.Text.Split(
                new string[] { Environment.NewLine, ";" },
                   StringSplitOptions.None);

            string user = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
            if (Environment.OSVersion.Version.Major >= 6)
            {
                user = Directory.GetParent(user).ToString();
            }

            string path = @user + "\\" + "Pictures" + "\\" + "QRCodes" + "\\" + cboCurso.Text + "\\" + dpAno.Text + " - " + cbSemestre.Text;

            //string path = @"C:" + "\\" + cboCurso.Text + "\\" +  dpAno.Text + " - " + cbSemestre.Text;

            int posicaoContadora = 0;
            foreach (var nome in nomes)
            {

                using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"JPG Image(*.jpg) | *.jpg | BMP Image(*.bmp) | *.bmp| PNG Image(*.png) | *.png" })
                {

                    var nomePicturebox = "pbQR" + posicaoContadora;

                    var nomeLabel = "lblNome" + posicaoContadora;

                    var nomesQR = panel1.Controls.Find(nomeLabel, true);

                    var imgsQR = panel1.Controls.Find(nomePicturebox, true);

                    //if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    //{
                    bool DiretorioExiste = Directory.Exists(path);

                    if (!DiretorioExiste)
                    {
                        DirectoryInfo di = Directory.CreateDirectory(path);



                        foreach (PictureBox imgQR in imgsQR)
                        {
                            if (imgQR.Image != null)
                            {
                                imgQR.Image.Save(path + @"\" + nome + ".png");
                            }

                        }

                        MessageBox.Show("QRCodes do curso de " + cboCurso.Text + " \nsalvos na pasta \n" + path + "\n com sucesso!");
                    }
                    else
                    {
                        foreach (PictureBox imgQR in imgsQR)
                        {
                            if (imgQR.Image != null)
                            {
                                imgQR.Image.Save(path + @"\" + nome + ".png");
                            }
                        }
                        MessageBox.Show("QRCodes salvos na pasta \n" + path + "\n com sucesso!");
                    }
                }
                posicaoContadora++;
            }
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

        private void lblNome0_Click(object sender, EventArgs e)
        {

        }

        private void lblNome1_Click(object sender, EventArgs e)
        {

        }

        private void lblNome2_Click(object sender, EventArgs e)
        {

        }

        private void lblNome3_Click(object sender, EventArgs e)
        {

        }

        private void lblNome4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string user = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
            if (Environment.OSVersion.Version.Major >= 6)
            {
                user = Directory.GetParent(user).ToString();
            }

            string path = @user + "\\" + "Pictures" + "\\" + "QRCodes" + "\\" + cboCurso.Text + "\\" + dpAno.Text + " - " + cbSemestre.Text;
            MessageBox.Show(path);
        }
    }


}

