using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReplaceText_De_Para
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            ofd.ShowDialog();

            if (botao.Name == "btnDePara")
                txtDePara.Text = ofd.FileName;
            if (botao.Name == "btnSelecionarArquivo")
                txtArquivo.Text = ofd.FileName;
        }

        private void btnIniciarReplace_Click(object sender, EventArgs e)
        {


            string textoAntigo, textoNovo = string.Empty;


            textoAntigo = File.ReadAllText(txtArquivo.Text);

            string[] arrDePara= File.ReadAllLines(txtDePara.Text);

            foreach (string s in arrDePara)
            {
                if (!string.IsNullOrEmpty(s) && s.Contains("="))
                    textoAntigo = textoAntigo.Replace(De(s), Para(s));

            }
            File.WriteAllText(txtArquivo.Text, textoAntigo);

            MessageBox.Show("Terminou");
        }
        private string De(string text)
        {
            return text.Substring(0, text.LastIndexOf('='));

        }
        private string Para(string text)
        {
            return text.Substring(text.LastIndexOf('=')+1);

        }

    }
}
