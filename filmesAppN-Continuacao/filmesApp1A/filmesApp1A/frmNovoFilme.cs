using filmesApp1A.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filmesApp1A
{
    public partial class frmNovoFilme : Form
    {
        Contexto db;
        public frmNovoFilme()
        {
            InitializeComponent();
            this.db = new Contexto();

            List<Pais> paises = this.db.Pais.ToList();
            cbxNacionalidade.DataSource = paises;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAnoLanc.Mask = "0000";
            txtAnoLanc.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtAnoLanc.ValidatingType = typeof(int);
            txtAnoLanc.TypeValidationCompleted += maskedTextBox1_TypeValidationCompleted;
        }

        private void maskedTextBox1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Por favor, insira um ano válido.");
            }
        }

        private void btCadastrarF_Click(object sender, EventArgs e)
        {
            Filme novo = new Filme();
            novo.Nome = txtNome.Text;

            Pais p = this.db.Pais
                .Where(
                pais => pais.Nome == cbxNacionalidade.SelectedItem.ToString()
                ).First();

            novo.Nacionalidade = p;

            int anoLancamento;
            if (int.TryParse(txtAnoLanc.Text, out anoLancamento))
            {
                int anoMinimo = 1900;
                int anoMaximo = DateTime.Now.Year;

                if (anoLancamento >= anoMinimo && anoLancamento <= anoMaximo)
                {
                    novo.AnoLancamento = anoLancamento;
                }

                else
                {
                    MessageBox.Show($"Por favor, insira um ano de lançamento entre {anoMinimo} e {anoMaximo}.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um ano de lançamento válido.");
                return;
            }


            this.db.Filme.Add(novo);
            this.db.SaveChanges();

            MessageBox.Show("Sucesso!");
            this.Close();
        }

        private void frmNovoFilme_Load(object sender, EventArgs e)
        {

        }
    }
}
