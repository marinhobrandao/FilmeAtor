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
    public partial class frmNovoAtor : Form
    {
        Contexto db;
        public frmNovoAtor()
        {
            InitializeComponent();

            this.db = new Contexto();

            List<Pais> paises = this.db.Pais.ToList();
            cbxNacionalidade.DataSource = paises;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Ator novo = new Ator();
            novo.Nome = txtNome.Text;

            Pais p = this.db.Pais
                .Where(
                pais => pais.Nome == cbxNacionalidade.SelectedItem.ToString()
                ).First();

            novo.Nacionalidade = p;

            this.db.Ator.Add(novo);
            this.db.SaveChanges();

            MessageBox.Show("Sucesso!");
            this.Close();
        }

        private void frmNovoAtor_Load(object sender, EventArgs e)
        {

        }
    }
}
