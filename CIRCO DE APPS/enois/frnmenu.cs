namespace enois
{
    public partial class frnmenu : Form
    {
        public frnmenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bpxSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pbxCep_Click(object sender, EventArgs e)
        {
            frnbuscacep frnbuscacep = new frnbuscacep();
            frnbuscacep.Show();
        }
    }
}