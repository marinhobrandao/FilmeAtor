namespace filmesApp1A
{
    partial class frmInserirAtores
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
            dgvAtores = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nacionalidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            atorBindingSource = new BindingSource(components);
            cbxAtor = new ComboBox();
            adcAtor = new Button();
            RmvAtor = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAtores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvAtores
            // 
            dgvAtores.AutoGenerateColumns = false;
            dgvAtores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtores.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, nacionalidadeDataGridViewTextBoxColumn });
            dgvAtores.DataSource = atorBindingSource;
            dgvAtores.Location = new Point(24, 184);
            dgvAtores.Name = "dgvAtores";
            dgvAtores.ReadOnly = true;
            dgvAtores.Size = new Size(524, 245);
            dgvAtores.TabIndex = 0;
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
            // cbxAtor
            // 
            cbxAtor.FormattingEnabled = true;
            cbxAtor.Location = new Point(180, 77);
            cbxAtor.Name = "cbxAtor";
            cbxAtor.Size = new Size(121, 23);
            cbxAtor.TabIndex = 1;
            // 
            // adcAtor
            // 
            adcAtor.Location = new Point(127, 128);
            adcAtor.Name = "adcAtor";
            adcAtor.Size = new Size(94, 23);
            adcAtor.TabIndex = 2;
            adcAtor.Text = "Adicionar ator";
            adcAtor.UseVisualStyleBackColor = true;
            adcAtor.Click += adcAtor_Click;
            // 
            // RmvAtor
            // 
            RmvAtor.Location = new Point(242, 128);
            RmvAtor.Name = "RmvAtor";
            RmvAtor.Size = new Size(103, 23);
            RmvAtor.TabIndex = 3;
            RmvAtor.Text = "Remover ator";
            RmvAtor.UseVisualStyleBackColor = true;
            RmvAtor.Click += RmvAtor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 80);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 5;
            label1.Text = "Selecionar ator:";
            // 
            // frmInserirAtores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 450);
            Controls.Add(label1);
            Controls.Add(RmvAtor);
            Controls.Add(adcAtor);
            Controls.Add(cbxAtor);
            Controls.Add(dgvAtores);
            Name = "frmInserirAtores";
            Text = "frmInserirAtores";
            Load += frmInserirAtores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAtores).EndInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAtores;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private BindingSource atorBindingSource;
        private ComboBox cbxAtor;
        private Button adcAtor;
        private Button RmvAtor;
        private Label label1;
    }
}