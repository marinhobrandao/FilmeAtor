namespace filmesApp1A
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            atorBindingSource = new BindingSource(components);
            btAtores = new Button();
            btFilmes = new Button();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // atorBindingSource
            // 
            atorBindingSource.DataSource = typeof(Models.Ator);
            // 
            // btAtores
            // 
            btAtores.Location = new Point(73, 32);
            btAtores.Name = "btAtores";
            btAtores.Size = new Size(121, 23);
            btAtores.TabIndex = 0;
            btAtores.Text = "Gerenciar atores";
            btAtores.UseVisualStyleBackColor = true;
            btAtores.Click += btAtores_Click;
            // 
            // btFilmes
            // 
            btFilmes.Location = new Point(73, 73);
            btFilmes.Name = "btFilmes";
            btFilmes.Size = new Size(121, 23);
            btFilmes.TabIndex = 1;
            btFilmes.Text = "Gerenciar filmes";
            btFilmes.UseVisualStyleBackColor = true;
            btFilmes.Click += btFilmes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 133);
            Controls.Add(btFilmes);
            Controls.Add(btAtores);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource atorBindingSource;
        private Button btAtores;
        private Button btFilmes;
    }
}
