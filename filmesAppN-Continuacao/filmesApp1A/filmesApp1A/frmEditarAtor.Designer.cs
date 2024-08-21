namespace filmesApp1A
{
    partial class frmEditarAtor
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            cbxNacionalidade = new ComboBox();
            btSalvar = new Button();
            dgvFilmes = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anoLancamentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nacionalidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            filmeBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 34);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 68);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 1;
            label2.Text = "Nacionalidade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 172);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Filmes:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(207, 31);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(145, 23);
            txtNome.TabIndex = 3;
            // 
            // cbxNacionalidade
            // 
            cbxNacionalidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNacionalidade.FormattingEnabled = true;
            cbxNacionalidade.Location = new Point(208, 67);
            cbxNacionalidade.Name = "cbxNacionalidade";
            cbxNacionalidade.Size = new Size(144, 23);
            cbxNacionalidade.TabIndex = 4;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(189, 112);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 5;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // dgvFilmes
            // 
            dgvFilmes.AutoGenerateColumns = false;
            dgvFilmes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilmes.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, anoLancamentoDataGridViewTextBoxColumn, nacionalidadeDataGridViewTextBoxColumn });
            dgvFilmes.DataSource = filmeBindingSource;
            dgvFilmes.Location = new Point(12, 198);
            dgvFilmes.Name = "dgvFilmes";
            dgvFilmes.ReadOnly = true;
            dgvFilmes.Size = new Size(464, 228);
            dgvFilmes.TabIndex = 6;
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
            // frmEditarAtor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 450);
            Controls.Add(dgvFilmes);
            Controls.Add(btSalvar);
            Controls.Add(cbxNacionalidade);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "frmEditarAtor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Ator";
            Load += frmEditarAtor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private ComboBox cbxNacionalidade;
        private Button btSalvar;
        private DataGridView dgvFilmes;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anoLancamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private BindingSource filmeBindingSource;
    }
}