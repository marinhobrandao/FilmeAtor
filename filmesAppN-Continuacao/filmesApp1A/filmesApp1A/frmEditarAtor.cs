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
    public partial class frmEditarAtor : Form
    {
        Ator ator;
        Contexto db;

        public frmEditarAtor(Ator ator)
        {
            InitializeComponent();

            this.ator = ator;
            this.db = new Contexto();

            txtNome.Text = ator.Nome;

            List<Pais> paises = this.db.Pais.ToList();
            cbxNacionalidade.DataSource = paises;

            cbxNacionalidade.SelectedIndex =
                cbxNacionalidade.FindStringExact(ator.Nacionalidade.Nome);

            dgvFilmes.DataSource = ator.Filmes;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            ator.Nome = txtNome.Text;
            ator.Nacionalidade = this.db.Pais
                .Where(p => p.Nome == cbxNacionalidade.SelectedItem.ToString())
                .First();

            this.db.Ator.Update(ator);
            this.db.SaveChanges();

            MessageBox.Show("Sucesso!");
            this.Close();
        }

        private void frmEditarAtor_Load(object sender, EventArgs e)
        {

        }
    }
}
