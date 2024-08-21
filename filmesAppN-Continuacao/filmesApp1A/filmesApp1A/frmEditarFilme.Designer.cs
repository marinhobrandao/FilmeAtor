namespace filmesApp1A
{
    partial class frmEditarFilme
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
            dgvFilmes = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nacionalidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            atorBindingSource = new BindingSource(components);
            btSalvarF = new Button();
            cbxNacionalidade = new ComboBox();
            txtNome = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtAnoLanc = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvFilmes
            // 
            dgvFilmes.AutoGenerateColumns = false;
            dgvFilmes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilmes.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, nacionalidadeDataGridViewTextBoxColumn });
            dgvFilmes.DataSource = atorBindingSource;
            dgvFilmes.Location = new Point(12, 206);
            dgvFilmes.Name = "dgvFilmes";
            dgvFilmes.ReadOnly = true;
            dgvFilmes.Size = new Size(464, 228);
            dgvFilmes.TabIndex = 13;
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
            // nacionalidadeDataGridViewTextBoxColumn
            // 
            nacionalidadeDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.HeaderText = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.Name = "nacionalidadeDataGridViewTextBoxColumn";
            nacionalidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // atorBindingSource
            // 
            atorBindingSource.DataSource = typeof(Models.Ator);
            // 
            // btSalvarF
            // 
            btSalvarF.Location = new Point(179, 152);
            btSalvarF.Name = "btSalvarF";
            btSalvarF.Size = new Size(75, 23);
            btSalvarF.TabIndex = 12;
            btSalvarF.Text = "Salvar";
            btSalvarF.UseVisualStyleBackColor = true;
            btSalvarF.Click += btSalvarF_Click;
            // 
            // cbxNacionalidade
            // 
            cbxNacionalidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNacionalidade.FormattingEnabled = true;
            cbxNacionalidade.Location = new Point(192, 70);
            cbxNacionalidade.Name = "cbxNacionalidade";
            cbxNacionalidade.Size = new Size(144, 23);
            cbxNacionalidade.TabIndex = 11;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(191, 34);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(145, 23);
            txtNome.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 175);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 9;
            label3.Text = "Atores:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 71);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 8;
            label2.Text = "Nacionalidade:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 37);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 112);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 15;
            label4.Text = "Ano de lançamento:";
            // 
            // txtAnoLanc
            // 
            txtAnoLanc.Location = new Point(192, 112);
            txtAnoLanc.Name = "txtAnoLanc";
            txtAnoLanc.Size = new Size(144, 23);
            txtAnoLanc.TabIndex = 16;
            // 
            // frmEditarFilme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 457);
            Controls.Add(txtAnoLanc);
            Controls.Add(label4);
            Controls.Add(dgvFilmes);
            Controls.Add(btSalvarF);
            Controls.Add(cbxNacionalidade);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEditarFilme";
            Text = "frmEditarFilme";
            Load += frmEditarFilme_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).EndInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFilmes;
        private Button btSalvarF;
        private ComboBox cbxNacionalidade;
        private TextBox txtNome;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private BindingSource atorBindingSource;
        private MaskedTextBox txtAnoLanc;
    }
}