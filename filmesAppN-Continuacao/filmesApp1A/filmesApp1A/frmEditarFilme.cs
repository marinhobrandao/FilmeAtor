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
    public partial class frmEditarFilme : Form
    {
        Filme filme;
        Contexto db;
        public frmEditarFilme(Filme filme)
        {
            InitializeComponent();

            this.filme = filme;
            this.db = new Contexto();

            txtNome.Text = filme.Nome;

            List<Pais> paises = this.db.Pais.ToList();
            cbxNacionalidade.DataSource = paises;

            cbxNacionalidade.SelectedIndex =
                cbxNacionalidade.FindStringExact(filme.Nacionalidade.Nome);

            dgvFilmes.DataSource = filme.Atores;

            txtAnoLanc.Mask = "0000";
            txtAnoLanc.Text = filme.AnoLancamento.ToString();
            txtAnoLanc.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtAnoLanc.ValidatingType = typeof(int);
            txtAnoLanc.TypeValidationCompleted += maskedTextBox1_TypeValidationCompleted;
        }


        private void btSalvarF_Click(object sender, EventArgs e)
        {
            filme.Nome = txtNome.Text;
            filme.Nacionalidade = this.db.Pais
                .Where(p => p.Nome == cbxNacionalidade.SelectedItem.ToString())
                .First();

            int anoLancamento;
            if (int.TryParse(txtAnoLanc.Text, out anoLancamento))
            {
                filme.AnoLancamento = anoLancamento;
            }
            else
            {
                MessageBox.Show("Por favor, insira um ano de lançamento válido.");
                return;
            }

            this.db.Filme.Update(filme);
            this.db.SaveChanges();

            MessageBox.Show("Sucesso!");
            this.Close ();
        }


        private void maskedTextBox1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Por favor, insira um ano válido.");
            }
        }

        private void frmEditarFilme_Load(object sender, EventArgs e)
        {

        }

    }
}
