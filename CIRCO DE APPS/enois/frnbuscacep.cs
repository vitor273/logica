using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enois
{
    public partial class frnbuscacep : Form
    {
        public frnbuscacep()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://viacep.com.br/ws/" + txtCep.Text + "/json");
            request.AllowAutoRedirect = false;
            HttpWebResponse checaServidor = (HttpWebResponse)request.GetResponse();
            if (checaServidor.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Servidor indesponivel", "Erro HTTP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (Stream webstream = checaServidor.GetResponseStream())
            {
                if (webstream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webstream))
                    {
                        string response = responseReader.ReadToEnd();
                        response = Regex.Replace(response, "[{},]", string.Empty);
                        response = response.Replace("\"", "");
                        string[] substrings = response.Split('\n');
                        int cont = 0;
                        foreach (string substring in substrings)
                        {
                            if (cont == 1)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                if (valor[0] == "erro")
                                {
                                    MessageBox.Show("CEP nao encontrado!!");
                                    txtCep.Text = string.Empty;
                                    txtCep.Focus();
                                    return;
                                }
                            }
                            if (cont == 2)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblEndereco.Text = valor[1];

                            }
                            if (cont == 3)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblComplemento.Text = valor[1];
                            }
                            if (cont == 5)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblBairro.Text = valor[1];
                            }
                            if (cont == 6)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblCidade.Text = valor[1];
                            }
                            if (cont == 7)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lbluf.Text = valor[1];
                            }
                            cont++;
                        }
                    }

                }
            }
        }
    }
}
