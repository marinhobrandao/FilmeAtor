namespace filmesApp1A
{
    partial class frmFilmes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtBuscarF = new TextBox();
            btBuscarF = new Button();
            dgvFilmes = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anoLancamentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nacionalidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            filmeBindingSource = new BindingSource(components);
            btCadastrarF = new Button();
            btEditarF = new Button();
            btRemoverF = new Button();
            btGerenciarF = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtBuscarF
            // 
            txtBuscarF.Location = new Point(35, 58);
            txtBuscarF.Name = "txtBuscarF";
            txtBuscarF.Size = new Size(607, 23);
            txtBuscarF.TabIndex = 2;
            // 
            // btBuscarF
            // 
            btBuscarF.Location = new Point(651, 58);
            btBuscarF.Name = "btBuscarF";
            btBuscarF.Size = new Size(84, 23);
            btBuscarF.TabIndex = 3;
            btBuscarF.Text = "Buscar";
            btBuscarF.UseVisualStyleBackColor = true;
            btBuscarF.Click += btBuscarF_Click_1;
            // 
            // dgvFilmes
            // 
            dgvFilmes.AutoGenerateColumns = false;
            dgvFilmes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilmes.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, anoLancamentoDataGridViewTextBoxColumn, nacionalidadeDataGridViewTextBoxColumn });
            dgvFilmes.DataSource = filmeBindingSource;
            dgvFilmes.Location = new Point(35, 108);
            dgvFilmes.Name = "dgvFilmes";
            dgvFilmes.ReadOnly = true;
            dgvFilmes.Size = new Size(700, 262);
            dgvFilmes.TabIndex = 4;
            dgvFilmes.CellContentClick += dgvFilmes_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anoLancamentoDataGridViewTextBoxColumn
            // 
            anoLancamentoDataGridViewTextBoxColumn.DataPropertyName = "AnoLancamento";
            anoLancamentoDataGridViewTextBoxColumn.HeaderText = "AnoLancamento";
            anoLancamentoDataGridViewTextBoxColumn.Name = "anoLancamentoDataGridViewTextBoxColumn";
            anoLancamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nacionalidadeDataGridViewTextBoxColumn
            // 
            nacionalidadeDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.HeaderText = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.Name = "nacionalidadeDataGridViewTextBoxColumn";
            nacionalidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmeBindingSource
            // 
            filmeBindingSource.DataSource = typeof(Models.Filme);
            // 
            // btCadastrarF
            // 
            btCadastrarF.Location = new Point(35, 415);
            btCadastrarF.Name = "btCadastrarF";
            btCadastrarF.Size = new Size(142, 23);
            btCadastrarF.TabIndex = 5;
            btCadastrarF.Text = "Cadastrar Filme";
            btCadastrarF.UseVisualStyleBackColor = true;
            btCadastrarF.Click += btCadastrar_Click;
            // 
            // btEditarF
            // 
            btEditarF.Enabled = false;
            btEditarF.Location = new Point(491, 415);
            btEditarF.Name = "btEditarF";
            btEditarF.Size = new Size(89, 23);
            btEditarF.TabIndex = 6;
            btEditarF.Text = "Editar Filme";
            btEditarF.UseVisualStyleBackColor = true;
            btEditarF.Click += btEditarF_Click;
            // 
            // btRemoverF
            // 
            btRemoverF.Enabled = false;
            btRemoverF.Location = new Point(619, 415);
            btRemoverF.Name = "btRemoverF";
            btRemoverF.Size = new Size(100, 23);
            btRemoverF.TabIndex = 7;
            btRemoverF.Text = "Remover Filme";
            btRemoverF.UseVisualStyleBackColor = true;
            btRemoverF.Click += btRemoverF_Click;
            // 
            // btGerenciarF
            // 
            btGerenciarF.Enabled = false;
            btGerenciarF.Location = new Point(360, 415);
            btGerenciarF.Name = "btGerenciarF";
            btGerenciarF.Size = new Size(108, 23);
            btGerenciarF.TabIndex = 8;
            btGerenciarF.Text = "Gerenciar Elenco";
            btGerenciarF.UseVisualStyleBackColor = true;
            btGerenciarF.Click += btGerenciarF_Click;
            // 
            // frmFilmes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btGerenciarF);
            Controls.Add(btRemoverF);
            Controls.Add(btEditarF);
            Controls.Add(btCadastrarF);
            Controls.Add(dgvFilmes);
            Controls.Add(btBuscarF);
            Controls.Add(txtBuscarF);
            Name = "frmFilmes";
            Text = "frmFilmes";
            Load += frmFilmes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscarF;
        private Button btBuscarF;
        private DataGridView dgvFilmes;
        private Button btCadastrarF;
        private Button btEditarF;
        private Button btRemoverF;
        private Button btGerenciarF;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anoLancamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private BindingSource filmeBindingSource;
    }
}