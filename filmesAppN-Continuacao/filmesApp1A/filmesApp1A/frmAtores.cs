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
    public partial class frmAtores : Form
    {
        Form anterior;
        Contexto db;
        Ator selecionado;

        public frmAtores(Form anterior)
        {
            InitializeComponent();
            this.anterior = anterior;

            this.db = new Contexto();
            this.db.Database.EnsureCreated();

            Recarregar("");
        }

        public void Recarregar(string buscar)
        {
            List<Ator> atores = this.db.Ator
                    .Where(a => a.Nome.ToUpper().Contains(buscar.ToUpper()))
                    .ToList();
            dgvAtores.DataSource = atores;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            frmNovoAtor f = new frmNovoAtor();
            f.ShowDialog();
            Recarregar(txtBuscar.Text);
        }

        private void dgvAtores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvAtores.SelectedCells[0].RowIndex;
            int id = (int)dgvAtores.Rows[linha].Cells[0].Value;

            selecionado = this.db.Ator.Where(a => a.Id == id).First();

            btEditar.Enabled = true;
            btRemover.Enabled = true;
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Deseja mesmo remover o ator " + selecionado.Nome + "?",
                "Confirmação", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                this.db.Ator.Remove(selecionado);
                this.db.SaveChanges();
                MessageBox.Show("Sucesso!");

                Recarregar(txtBuscar.Text);

                btEditar.Enabled = false;
                btRemover.Enabled = false;
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Recarregar(txtBuscar.Text);
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            frmEditarAtor f = new frmEditarAtor(selecionado);
            f.ShowDialog();
            Recarregar(txtBuscar.Text);
        }

        private void frmAtores_Load(object sender, EventArgs e)
        {

        }

        private void dgvAtores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
