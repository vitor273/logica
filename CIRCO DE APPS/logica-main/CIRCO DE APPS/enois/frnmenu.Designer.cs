namespace enois
{
    partial class frnmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frnmenu));
            label1 = new Label();
            pbxCalculadora = new PictureBox();
            pbxCep = new PictureBox();
            pictureBox3 = new PictureBox();
            pbxCpf = new PictureBox();
            bpxDestino = new PictureBox();
            pbxClima = new PictureBox();
            bpxSair = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxCalculadora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxCep).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxCpf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bpxDestino).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxClima).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bpxSair).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(60, 205);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "CALCULADORA";
            // 
            // pbxCalculadora
            // 
            pbxCalculadora.Image = (Image)resources.GetObject("pbxCalculadora.Image");
            pbxCalculadora.Location = new Point(29, 50);
            pbxCalculadora.Name = "pbxCalculadora";
            pbxCalculadora.Size = new Size(152, 138);
            pbxCalculadora.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxCalculadora.TabIndex = 1;
            pbxCalculadora.TabStop = false;
            // 
            // pbxCep
            // 
            pbxCep.Image = Properties.Resources.cep;
            pbxCep.Location = new Point(214, 50);
            pbxCep.Name = "pbxCep";
            pbxCep.Size = new Size(163, 138);
            pbxCep.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxCep.TabIndex = 2;
            pbxCep.TabStop = false;
            pbxCep.Click += pbxCep_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.moeda_logo_icon_design_da_chama_125199043_removebg_preview;
            pictureBox3.Location = new Point(112, 255);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(152, 135);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pbxCpf
            // 
            pbxCpf.Image = Properties.Resources.cpf;
            pbxCpf.Location = new Point(617, 50);
            pbxCpf.Name = "pbxCpf";
            pbxCpf.Size = new Size(155, 138);
            pbxCpf.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxCpf.TabIndex = 4;
            pbxCpf.TabStop = false;
            // 
            // bpxDestino
            // 
            bpxDestino.Image = Properties.Resources.carro;
            bpxDestino.Location = new Point(315, 255);
            bpxDestino.Name = "bpxDestino";
            bpxDestino.Size = new Size(160, 135);
            bpxDestino.SizeMode = PictureBoxSizeMode.Zoom;
            bpxDestino.TabIndex = 5;
            bpxDestino.TabStop = false;
            // 
            // pbxClima
            // 
            pbxClima.Image = Properties.Resources.app_de_clima;
            pbxClima.Location = new Point(415, 50);
            pbxClima.Name = "pbxClima";
            pbxClima.Size = new Size(151, 138);
            pbxClima.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxClima.TabIndex = 6;
            pbxClima.TabStop = false;
            // 
            // bpxSair
            // 
            bpxSair.Image = Properties.Resources.saida_de_emergencia;
            bpxSair.Location = new Point(529, 255);
            bpxSair.Name = "bpxSair";
            bpxSair.Size = new Size(152, 135);
            bpxSair.SizeMode = PictureBoxSizeMode.Zoom;
            bpxSair.TabIndex = 7;
            bpxSair.TabStop = false;
            bpxSair.Click += bpxSair_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(281, 205);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 8;
            label2.Text = "CEP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(467, 205);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 9;
            label3.Text = "CLIMA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(688, 205);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 10;
            label4.Text = "CPF";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(573, 408);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 11;
            label5.Text = "IR EM BORA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(370, 408);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 12;
            label6.Text = "DESTINO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(138, 408);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 13;
            label7.Text = "CARA OU COROA";
            // 
            // frnmenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(bpxSair);
            Controls.Add(pbxClima);
            Controls.Add(bpxDestino);
            Controls.Add(pbxCpf);
            Controls.Add(pictureBox3);
            Controls.Add(pbxCep);
            Controls.Add(pbxCalculadora);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frnmenu";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbxCalculadora).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxCep).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxCpf).EndInit();
            ((System.ComponentModel.ISupportInitialize)bpxDestino).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxClima).EndInit();
            ((System.ComponentModel.ISupportInitialize)bpxSair).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbxCalculadora;
        private PictureBox pbxCep;
        private PictureBox pictureBox3;
        private PictureBox pbxCpf;
        private PictureBox bpxDestino;
        private PictureBox pbxClima;
        private PictureBox bpxSair;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}