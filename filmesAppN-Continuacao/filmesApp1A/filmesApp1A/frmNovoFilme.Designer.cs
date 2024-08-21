namespace filmesApp1A
{
    partial class frmNovoFilme
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
            btCadastrarF = new Button();
            txtNome = new TextBox();
            label1 = new Label();
            label3 = new Label();
            cbxNacionalidade = new ComboBox();
            label2 = new Label();
            txtAnoLanc = new MaskedTextBox();
            SuspendLayout();
            // 
            // btCadastrarF
            // 
            btCadastrarF.Location = new Point(176, 151);
            btCadastrarF.Name = "btCadastrarF";
            btCadastrarF.Size = new Size(75, 23);
            btCadastrarF.TabIndex = 9;
            btCadastrarF.Text = "Cadastrar";
            btCadastrarF.UseVisualStyleBackColor = true;
            btCadastrarF.Click += btCadastrarF_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(191, 54);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(121, 23);
            txtNome.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 62);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 117);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 10;
            label3.Text = "Ano de lançamento:";
            // 
            // cbxNacionalidade
            // 
            cbxNacionalidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNacionalidade.FormattingEnabled = true;
            cbxNacionalidade.Location = new Point(191, 83);
            cbxNacionalidade.Name = "cbxNacionalidade";
            cbxNacionalidade.Size = new Size(121, 23);
            cbxNacionalidade.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 86);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 12;
            label2.Text = "Nacionalidade:";
            // 
            // txtAnoLanc
            // 
            txtAnoLanc.Location = new Point(191, 114);
            txtAnoLanc.Name = "txtAnoLanc";
            txtAnoLanc.Size = new Size(121, 23);
            txtAnoLanc.TabIndex = 15;
            // 
            // frmNovoFilme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 229);
            Controls.Add(txtAnoLanc);
            Controls.Add(cbxNacionalidade);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(btCadastrarF);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "frmNovoFilme";
            Text = "frmNovoFilme";
            Load += frmNovoFilme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCadastrarF;
        private TextBox txtNome;
        private Label label1;
        private Label label3;
        private ComboBox cbxNacionalidade;
        private Label label2;
        private MaskedTextBox txtAnoLanc;
    }
}