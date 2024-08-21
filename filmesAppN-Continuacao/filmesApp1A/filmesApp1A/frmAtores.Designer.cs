namespace filmesApp1A
{
    partial class frmAtores
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
            btBuscar = new Button();
            txtBuscar = new TextBox();
            dgvAtores = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nacionalidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            atorBindingSource = new BindingSource(components);
            btCadastrar = new Button();
            btEditar = new Button();
            btRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAtores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(628, 30);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(84, 23);
            btBuscar.TabIndex = 0;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 30);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(607, 23);
            txtBuscar.TabIndex = 1;
            // 
            // dgvAtores
            // 
            dgvAtores.AutoGenerateColumns = false;
            dgvAtores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtores.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, nacionalidadeDataGridViewTextBoxColumn });
            dgvAtores.DataSource = atorBindingSource;
            dgvAtores.Location = new Point(12, 73);
            dgvAtores.Name = "dgvAtores";
            dgvAtores.ReadOnly = true;
            dgvAtores.Size = new Size(700, 262);
            dgvAtores.TabIndex = 2;
            dgvAtores.CellClick += dgvAtores_CellClick;
            dgvAtores.CellContentClick += dgvAtores_CellContentClick;
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
            // btCadastrar
            // 
            btCadastrar.Location = new Point(12, 349);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(142, 23);
            btCadastrar.TabIndex = 3;
            btCadastrar.Text = "Cadastrar Ator";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // btEditar
            // 
            btEditar.Enabled = false;
            btEditar.Location = new Point(531, 350);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(75, 23);
            btEditar.TabIndex = 4;
            btEditar.Text = "Editar Ator";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // btRemover
            // 
            btRemover.Enabled = false;
            btRemover.Location = new Point(612, 350);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(100, 23);
            btRemover.TabIndex = 5;
            btRemover.Text = "Remover Ator";
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Click += btRemover_Click;
            // 
            // frmAtores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 384);
            Controls.Add(btRemover);
            Controls.Add(btEditar);
            Controls.Add(btCadastrar);
            Controls.Add(dgvAtores);
            Controls.Add(txtBuscar);
            Controls.Add(btBuscar);
            MaximizeBox = false;
            Name = "frmAtores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atores";
            Load += frmAtores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAtores).EndInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btBuscar;
        private TextBox txtBuscar;
        private DataGridView dgvAtores;
        private Button btCadastrar;
        private Button btEditar;
        private Button btRemover;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private BindingSource atorBindingSource;
    }
}