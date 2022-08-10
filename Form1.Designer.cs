namespace GeradorQRCode
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGerar = new System.Windows.Forms.Button();
            this.txtDados = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbQR20 = new System.Windows.Forms.PictureBox();
            this.pbQR15 = new System.Windows.Forms.PictureBox();
            this.pbQR19 = new System.Windows.Forms.PictureBox();
            this.pbQR14 = new System.Windows.Forms.PictureBox();
            this.pbQR10 = new System.Windows.Forms.PictureBox();
            this.pbQR9 = new System.Windows.Forms.PictureBox();
            this.pbQR18 = new System.Windows.Forms.PictureBox();
            this.pbQR13 = new System.Windows.Forms.PictureBox();
            this.pbQR5 = new System.Windows.Forms.PictureBox();
            this.pbQR8 = new System.Windows.Forms.PictureBox();
            this.pbQR17 = new System.Windows.Forms.PictureBox();
            this.pbQR12 = new System.Windows.Forms.PictureBox();
            this.pbQR4 = new System.Windows.Forms.PictureBox();
            this.pbQR7 = new System.Windows.Forms.PictureBox();
            this.pbQR16 = new System.Windows.Forms.PictureBox();
            this.pbQR11 = new System.Windows.Forms.PictureBox();
            this.pbQR3 = new System.Windows.Forms.PictureBox();
            this.pbQR6 = new System.Windows.Forms.PictureBox();
            this.pbQR2 = new System.Windows.Forms.PictureBox();
            this.pbQR1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.Color.Green;
            this.btnGerar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGerar.ForeColor = System.Drawing.Color.White;
            this.btnGerar.Location = new System.Drawing.Point(6, 457);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(128, 53);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDados
            // 
            this.txtDados.Location = new System.Drawing.Point(12, 86);
            this.txtDados.Multiline = true;
            this.txtDados.Name = "txtDados";
            this.txtDados.Size = new System.Drawing.Size(249, 295);
            this.txtDados.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Aux. Administrativo",
            "Cabelereiro",
            "Cozinha Industrial",
            "Eletricista Instalador Predial",
            "Estamparia",
            "Informática Avançada",
            "Inglês Instermediário",
            "Panificação",
            "Programador Web",
            "Promotor de Vendas",
            "Teatro",
            "CJ"});
            this.comboBox1.Location = new System.Drawing.Point(12, 416);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(209, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(703, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sistema Gerador QRCode - Fundação Lar de São bento Casa Dom Macário";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbQR20);
            this.panel1.Controls.Add(this.pbQR15);
            this.panel1.Controls.Add(this.pbQR19);
            this.panel1.Controls.Add(this.pbQR14);
            this.panel1.Controls.Add(this.pbQR10);
            this.panel1.Controls.Add(this.pbQR9);
            this.panel1.Controls.Add(this.pbQR18);
            this.panel1.Controls.Add(this.pbQR13);
            this.panel1.Controls.Add(this.pbQR5);
            this.panel1.Controls.Add(this.pbQR8);
            this.panel1.Controls.Add(this.pbQR17);
            this.panel1.Controls.Add(this.pbQR12);
            this.panel1.Controls.Add(this.pbQR4);
            this.panel1.Controls.Add(this.pbQR7);
            this.panel1.Controls.Add(this.pbQR16);
            this.panel1.Controls.Add(this.pbQR11);
            this.panel1.Controls.Add(this.pbQR3);
            this.panel1.Controls.Add(this.pbQR6);
            this.panel1.Controls.Add(this.pbQR2);
            this.panel1.Controls.Add(this.pbQR1);
            this.panel1.Location = new System.Drawing.Point(273, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 554);
            this.panel1.TabIndex = 5;
            // 
            // pbQR20
            // 
            this.pbQR20.Location = new System.Drawing.Point(724, 420);
            this.pbQR20.Name = "pbQR20";
            this.pbQR20.Size = new System.Drawing.Size(100, 100);
            this.pbQR20.TabIndex = 3;
            this.pbQR20.TabStop = false;
            // 
            // pbQR15
            // 
            this.pbQR15.Location = new System.Drawing.Point(724, 287);
            this.pbQR15.Name = "pbQR15";
            this.pbQR15.Size = new System.Drawing.Size(100, 100);
            this.pbQR15.TabIndex = 3;
            this.pbQR15.TabStop = false;
            // 
            // pbQR19
            // 
            this.pbQR19.Location = new System.Drawing.Point(551, 420);
            this.pbQR19.Name = "pbQR19";
            this.pbQR19.Size = new System.Drawing.Size(100, 100);
            this.pbQR19.TabIndex = 3;
            this.pbQR19.TabStop = false;
            // 
            // pbQR14
            // 
            this.pbQR14.Location = new System.Drawing.Point(551, 287);
            this.pbQR14.Name = "pbQR14";
            this.pbQR14.Size = new System.Drawing.Size(100, 100);
            this.pbQR14.TabIndex = 3;
            this.pbQR14.TabStop = false;
            // 
            // pbQR10
            // 
            this.pbQR10.Location = new System.Drawing.Point(724, 154);
            this.pbQR10.Name = "pbQR10";
            this.pbQR10.Size = new System.Drawing.Size(100, 100);
            this.pbQR10.TabIndex = 3;
            this.pbQR10.TabStop = false;
            // 
            // pbQR9
            // 
            this.pbQR9.Location = new System.Drawing.Point(551, 154);
            this.pbQR9.Name = "pbQR9";
            this.pbQR9.Size = new System.Drawing.Size(100, 100);
            this.pbQR9.TabIndex = 3;
            this.pbQR9.TabStop = false;
            // 
            // pbQR18
            // 
            this.pbQR18.Location = new System.Drawing.Point(374, 420);
            this.pbQR18.Name = "pbQR18";
            this.pbQR18.Size = new System.Drawing.Size(100, 100);
            this.pbQR18.TabIndex = 3;
            this.pbQR18.TabStop = false;
            // 
            // pbQR13
            // 
            this.pbQR13.Location = new System.Drawing.Point(374, 287);
            this.pbQR13.Name = "pbQR13";
            this.pbQR13.Size = new System.Drawing.Size(100, 100);
            this.pbQR13.TabIndex = 3;
            this.pbQR13.TabStop = false;
            // 
            // pbQR5
            // 
            this.pbQR5.Location = new System.Drawing.Point(724, 20);
            this.pbQR5.Name = "pbQR5";
            this.pbQR5.Size = new System.Drawing.Size(100, 100);
            this.pbQR5.TabIndex = 3;
            this.pbQR5.TabStop = false;
            // 
            // pbQR8
            // 
            this.pbQR8.Location = new System.Drawing.Point(374, 154);
            this.pbQR8.Name = "pbQR8";
            this.pbQR8.Size = new System.Drawing.Size(100, 100);
            this.pbQR8.TabIndex = 3;
            this.pbQR8.TabStop = false;
            // 
            // pbQR17
            // 
            this.pbQR17.Location = new System.Drawing.Point(184, 420);
            this.pbQR17.Name = "pbQR17";
            this.pbQR17.Size = new System.Drawing.Size(100, 100);
            this.pbQR17.TabIndex = 3;
            this.pbQR17.TabStop = false;
            // 
            // pbQR12
            // 
            this.pbQR12.Location = new System.Drawing.Point(184, 287);
            this.pbQR12.Name = "pbQR12";
            this.pbQR12.Size = new System.Drawing.Size(100, 100);
            this.pbQR12.TabIndex = 3;
            this.pbQR12.TabStop = false;
            // 
            // pbQR4
            // 
            this.pbQR4.Location = new System.Drawing.Point(551, 20);
            this.pbQR4.Name = "pbQR4";
            this.pbQR4.Size = new System.Drawing.Size(100, 100);
            this.pbQR4.TabIndex = 3;
            this.pbQR4.TabStop = false;
            // 
            // pbQR7
            // 
            this.pbQR7.Location = new System.Drawing.Point(184, 154);
            this.pbQR7.Name = "pbQR7";
            this.pbQR7.Size = new System.Drawing.Size(100, 100);
            this.pbQR7.TabIndex = 3;
            this.pbQR7.TabStop = false;
            // 
            // pbQR16
            // 
            this.pbQR16.Location = new System.Drawing.Point(26, 420);
            this.pbQR16.Name = "pbQR16";
            this.pbQR16.Size = new System.Drawing.Size(100, 100);
            this.pbQR16.TabIndex = 3;
            this.pbQR16.TabStop = false;
            // 
            // pbQR11
            // 
            this.pbQR11.Location = new System.Drawing.Point(26, 287);
            this.pbQR11.Name = "pbQR11";
            this.pbQR11.Size = new System.Drawing.Size(100, 100);
            this.pbQR11.TabIndex = 3;
            this.pbQR11.TabStop = false;
            // 
            // pbQR3
            // 
            this.pbQR3.Location = new System.Drawing.Point(374, 20);
            this.pbQR3.Name = "pbQR3";
            this.pbQR3.Size = new System.Drawing.Size(100, 100);
            this.pbQR3.TabIndex = 3;
            this.pbQR3.TabStop = false;
            // 
            // pbQR6
            // 
            this.pbQR6.Location = new System.Drawing.Point(26, 154);
            this.pbQR6.Name = "pbQR6";
            this.pbQR6.Size = new System.Drawing.Size(100, 100);
            this.pbQR6.TabIndex = 3;
            this.pbQR6.TabStop = false;
            // 
            // pbQR2
            // 
            this.pbQR2.Location = new System.Drawing.Point(184, 20);
            this.pbQR2.Name = "pbQR2";
            this.pbQR2.Size = new System.Drawing.Size(100, 100);
            this.pbQR2.TabIndex = 3;
            this.pbQR2.TabStop = false;
            // 
            // pbQR1
            // 
            this.pbQR1.Location = new System.Drawing.Point(26, 20);
            this.pbQR1.Name = "pbQR1";
            this.pbQR1.Size = new System.Drawing.Size(100, 100);
            this.pbQR1.TabIndex = 3;
            this.pbQR1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(140, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(6, 517);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 56);
            this.button2.TabIndex = 7;
            this.button2.Text = "Salvar Imagens";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Insira os nomes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Selecione o curso:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 629);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtDados);
            this.Controls.Add(this.btnGerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbQR20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGerar;
        private TextBox txtDados;
        private ComboBox comboBox1;
        private Label label1;
        private Panel panel1;
        private PictureBox pbQR20;
        private PictureBox pbQR15;
        private PictureBox pbQR19;
        private PictureBox pbQR14;
        private PictureBox pbQR10;
        private PictureBox pbQR9;
        private PictureBox pbQR18;
        private PictureBox pbQR13;
        private PictureBox pbQR5;
        private PictureBox pbQR8;
        private PictureBox pbQR17;
        private PictureBox pbQR12;
        private PictureBox pbQR4;
        private PictureBox pbQR7;
        private PictureBox pbQR16;
        private PictureBox pbQR11;
        private PictureBox pbQR3;
        private PictureBox pbQR6;
        private PictureBox pbQR2;
        private PictureBox pbQR1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
    }
}