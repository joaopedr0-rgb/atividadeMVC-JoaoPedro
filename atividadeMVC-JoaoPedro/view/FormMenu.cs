namespace atividadeMVC_JoaoPedro.view
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this is Form1)
            {
                return;
            }
            Form1 FormTarefas = new Form1();
            FormTarefas.Show();
            this.Hide();

        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this is view.Form2)
            {
                return;
            }
            view.Form2 FormTarefas = new Form2();
            FormTarefas.Show();
            this.Hide();
        }
    }
}
