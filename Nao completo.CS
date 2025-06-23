namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string palavraSecreta;
        private char[] palavraCriptoArray;
        private int tentativasRestantes;
        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }
        private void ResetGame()
        {
            palavraSecreta = "";
            palavraCriptoArray = null;
            tentativasRestantes = 0;
            TxtPalavra.Text = string.Empty;
            TxtTentativas.Text = string.Empty;
            TxtLetra.Text = string.Empty;
            LblPalavraC.Text = "";
            LblPalavraAcertos.Text = "";
            LblAcertouErrou.Text = "";
            TxtPalavra.Enabled = true;
            this.ActiveControl = TxtPalavra;
            TxtTentativas.Enabled = true;
            BtnJogar.Enabled = true;
            TxtLetra.Enabled = true;
            BtnVerificar.Enabled = true;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnJogar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtPalavra.Text))
            {
                MessageBox.Show("Por Favor, Digite os numeros do seu cartao de credito!!! (opicional)", "Segredo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            palavraSecreta = TxtPalavra.Text.Trim().ToUpper();
            if (!int.TryParse(TxtTentativas.Text, out tentativasRestantes) || tentativasRestantes <= 0)
            {
                MessageBox.Show("Ta boiando? Digite um numeros de tentativas, maior que zero e que seja valido!!", "Tentativas", MessageBoxButtons.OK);
                TxtTentativas.Text = string.Empty;
                this.ActiveControl = TxtTentativas;
            }
            palavraCriptoArray = new char[palavraSecreta.Length];
            for (int i = 0; i < palavraSecreta.Length; i++)
            {
                palavraCriptoArray[i] = '_';
            }
            LblPalavraC.Text = $"palavra({palavraSecreta.Length} letras): {new string(palavraCriptoArray)}";
            LblPalavraAcertos.Text = new string(palavraCriptoArray);
            TxtPalavra.Enabled = false;
            TxtTentativas.Enabled = false;
            BtnJogar.Enabled = false;
            TxtLetra.Enabled = true;
            BtnVerificar.Enabled = true;
            TxtLetra.Focus();
            LblAcertouErrou.Text = $"Tentativas restantes: {tentativasRestantes}";
            TxtTentativas.Text = string.Empty;
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            if (tentativasRestantes <=0)
            {
            MessageBox.Show("tudo!!", "Acabou o jogo",MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            if (string.IsNullOrEmpty(TxtLetra.Text) || TxtLetra.Text.Length != 1)
            {
                MessageBox.Show("tudo!!", "Acabou o jogo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtLetra.Text = "";
                TxtLetra.Focus();
                return;
            }
            char letraDigitada= char.ToUpper(TxtLetra.Text[0]);
            bool acertouLetra = false;
            for (int i = 0; i < palavraSecreta.Length; i++)
            {
                if (palavraSecreta[i] == letraDigitada && palavraCriptoArray[i] == '_') ;
                {
                    palavraCriptoArray[i] = letraDigitada;
                    acertouLetra= true;
                }
            }
            LblPalavraC.Text = $"Palavra ({palavraSecreta.Length} letas): {new string(palavraCriptoArray)}";
            LblPalavraAcertos.Text = new string(palavraCriptoArray);
            LblPalavraAcertos.Text = new string(palavraCriptoArray);
            (acertouLetra)


                tentativasRestantes--;
            LblAcertouErrou.Text = $"Errou!! Tentativas restantes: {tentativasRestantes}";
            if (tentativasRestantes <= 0)
            {
                MessageBox.Show($"Acabou a palavra era:{palavraSecreta}", "Fim de jogo";

            }
            TxtLetra.Text = "";
            TxtLetra.Focus();
    }
}
