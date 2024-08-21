namespace filmesApp1A
{
    partial class frmNovoAtor
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
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            cbxNacionalidade = new ComboBox();
            btCadastrarF = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 59);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 100);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 1;
            label2.Text = "Nacionalidade:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(173, 51);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(121, 23);
            txtNome.TabIndex = 2;
            // 
            // cbxNacionalidade
            // 
            cbxNacionalidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNacionalidade.FormattingEnabled = true;
            cbxNacionalidade.Location = new Point(173, 97);
            cbxNacionalidade.Name = "cbxNacionalidade";
            cbxNacionalidade.Size = new Size(121, 23);
            cbxNacionalidade.TabIndex = 3;
            // 
            // btCadastrarF
            // 
            btCadastrarF.Location = new Point(158, 148);
            btCadastrarF.Name = "btCadastrarF";
            btCadastrarF.Size = new Size(75, 23);
            btCadastrarF.TabIndex = 4;
            btCadastrarF.Text = "Cadastrar";
            btCadastrarF.UseVisualStyleBackColor = true;
            btCadastrarF.Click += btCadastrar_Click;
            // 
            // frmNovoAtor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 207);
            Controls.Add(btCadastrarF);
            Controls.Add(cbxNacionalidade);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "frmNovoAtor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Ator";
            Load += frmNovoAtor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private ComboBox cbxNacionalidade;
        private Button btCadastrarF;
    }
}