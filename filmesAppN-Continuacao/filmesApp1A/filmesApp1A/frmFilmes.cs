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
    public partial class frmFilmes : Form
    {
        Form anterior;
        Contexto db;
        Filme selecionado;
        public frmFilmes(Form anterior)
        {
            InitializeComponent();
            this.anterior = anterior;

            this.db = new Contexto();
            this.db.Database.EnsureCreated();

            Recarregar("");
        }

        public void Recarregar(string buscar)
        {
            List<Filme> filmes = this.db.Filme
                    .Where(a => a.Nome.ToUpper().Contains(buscar.ToUpper()))
                    .ToList();
            dgvFilmes.DataSource = filmes;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            frmNovoFilme f = new frmNovoFilme();
            f.ShowDialog();
            Recarregar(txtBuscarF.Text);
        }
        private void dgvFilmes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvFilmes.SelectedCells[0].RowIndex;
            int id = (int)dgvFilmes.Rows[linha].Cells[0].Value;

            selecionado = this.db.Filme.Where(a => a.Id == id).First();

            btEditarF.Enabled = true;
            btRemoverF.Enabled = true;
            btGerenciarF.Enabled = true;
        }


        private void btBuscarF_Click(object sender, EventArgs e)
        {
            Recarregar(txtBuscarF.Text);
        }


        private void btEditarF_Click(object sender, EventArgs e)
        {
            frmEditarFilme f = new frmEditarFilme(selecionado);
            f.ShowDialog();
            Recarregar(txtBuscarF.Text);
        }


        private void btRemoverF_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
            "Deseja mesmo remover o filme " + selecionado.Nome + "?",
            "Confirmação", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                this.db.Filme.Remove(selecionado);
                this.db.SaveChanges();
                MessageBox.Show("Sucesso!");

                Recarregar(txtBuscarF.Text);

                btEditarF.Enabled = false;
                btRemoverF.Enabled = false;
                btGerenciarF.Enabled = false;
            }
        }

        private void btGerenciarF_Click(object sender, EventArgs e)
        {
            frmInserirAtores frm = new frmInserirAtores(selecionado);
            frm.Show();
            this.Hide();

        }

        private void btBuscarF_Click_1(object sender, EventArgs e)
        {
            Recarregar(txtBuscarF.Text);
        }

        private void frmFilmes_Load(object sender, EventArgs e)
        {

        }
    }
}
