namespace enois
{
    partial class frnbuscacep
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbluf = new Label();
            label1 = new Label();
            btnPesquisar = new Button();
            txtCep = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnFechar = new Button();
            lblCidade = new Label();
            lblBairro = new Label();
            lblComplemento = new Label();
            lblEndereco = new Label();
            SuspendLayout();
            // 
            // lbluf
            // 
            lbluf.AutoSize = true;
            lbluf.ForeColor = Color.Lime;
            lbluf.Location = new Point(192, 396);
            lbluf.Name = "lbluf";
            lbluf.Size = new Size(0, 15);
            lbluf.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "DIGITE UM CEP";
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.Navy;
            btnPesquisar.ForeColor = Color.Lime;
            btnPesquisar.Location = new Point(279, 38);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(141, 46);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "PESQUISAR";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(12, 51);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(227, 23);
            txtCep.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(12, 227);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "ENDEREÇO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(12, 357);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "CIDADE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(12, 266);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 5;
            label4.Text = "COMPLEMENTO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Lime;
            label5.Location = new Point(12, 396);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 6;
            label5.Text = "UF:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Lime;
            label6.Location = new Point(12, 309);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 7;
            label6.Text = "BAIRRO:";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Red;
            btnFechar.ForeColor = Color.Lime;
            btnFechar.Location = new Point(279, 101);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(141, 49);
            btnFechar.TabIndex = 9;
            btnFechar.Text = "FECHAR";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.ForeColor = Color.Lime;
            lblCidade.Location = new Point(192, 357);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(0, 15);
            lblCidade.TabIndex = 10;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.ForeColor = Color.Lime;
            lblBairro.Location = new Point(192, 309);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(0, 15);
            lblBairro.TabIndex = 11;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.ForeColor = Color.Lime;
            lblComplemento.Location = new Point(192, 266);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(0, 15);
            lblComplemento.TabIndex = 12;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.ForeColor = Color.Lime;
            lblEndereco.Location = new Point(192, 227);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(0, 15);
            lblEndereco.TabIndex = 13;
            // 
            // frnbuscacep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(432, 442);
            Controls.Add(lblEndereco);
            Controls.Add(lblComplemento);
            Controls.Add(lblBairro);
            Controls.Add(lblCidade);
            Controls.Add(btnFechar);
            Controls.Add(lbluf);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCep);
            Controls.Add(btnPesquisar);
            Controls.Add(label1);
            Name = "frnbuscacep";
            Text = "frnbuscacep";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPesquisar;
        private TextBox txtCep;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnFechar;
        private Label lblCidade;
        private Label lblBairro;
        private Label lblComplemento;
        private Label lblEndereco;
        private Label lbluf;
    }
}