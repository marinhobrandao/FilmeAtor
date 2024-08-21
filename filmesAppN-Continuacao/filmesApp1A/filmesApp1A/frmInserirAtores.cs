using filmesApp1A.Models;
using Microsoft.EntityFrameworkCore;
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

    public partial class frmInserirAtores : Form
    {
        Contexto db;
        Filme filme;
        Ator ator;
        public frmInserirAtores(Filme filme)
        {
            InitializeComponent();
            this.db = new Contexto();
            this.filme = filme;
            LoadData();

        }

        private void LoadData()
        {
            List<Ator> atores = this.db.Ator.ToList();
            cbxAtor.DataSource = atores;
            cbxAtor.DisplayMember = "Nome";
            cbxAtor.ValueMember = "Id";

            dgvAtores.DataSource = filme.Atores.ToList();
        }

        private void RmvAtor_Click(object sender, EventArgs e)
        {

            if (dgvAtores.SelectedRows.Count > 0)
            {
                var atorSelecionado = (Ator)dgvAtores.SelectedRows[0].DataBoundItem;

                if (atorSelecionado != null)
                {
                    var atorParaRemover = filme.Atores.FirstOrDefault(a => a.Id == atorSelecionado.Id);

                    if (atorParaRemover != null)
                    {
                        filme.Atores.Remove(atorParaRemover);
                        db.Entry(filme).State = EntityState.Modified;
                        db.SaveChanges();

                        AtualizarDataGridView(); 
                    }
                    else
                    {
                        MessageBox.Show("Ator não encontrado na lista.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um ator para remover.");
            }
        }

        private void adcAtor_Click(object sender, EventArgs e)
        {
            var atorId = (int)cbxAtor.SelectedValue;
            var atorSelecionado = db.Ator.Find(atorId);

            if (atorSelecionado != null && !filme.Atores.Contains(atorSelecionado))
            {
                filme.Atores.Add(atorSelecionado);
                db.Entry(filme).State = EntityState.Modified;
                db.SaveChanges();

                AtualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Ator já está no elenco ou não encontrado.");
            }
        }

        private void frmInserirAtores_Load(object sender, EventArgs e)
        {

        }

        private void AtualizarDataGridView()
        {
            dgvAtores.DataSource = null;
            dgvAtores.DataSource = filme.Atores.ToList();
        }
    }

}