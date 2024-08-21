using filmesApp1A.Models;

namespace filmesApp1A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAtores_Click(object sender, EventArgs e)
        {
            frmAtores f = new frmAtores(this);
            f.Show();
            this.Hide();
        }

        private void btFilmes_Click(object sender, EventArgs e)
        {
            frmFilmes f = new frmFilmes(this);
            f.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
