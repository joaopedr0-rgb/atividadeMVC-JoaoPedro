using atividadeMVC_JoaoPedro.Controllers;
using System.Data;

namespace atividadeMVC_JoaoPedro.view
{
    public partial class Form2 : Form
    {

        DataTable TabelaFuncionario = new DataTable();

        FuncionarioController controller_funcionario = new FuncionarioController();
        public Form2()
        {
            InitializeComponent();
            ConfigureGrid2();
        }
        public void ConfigureGrid2()
        {
            TabelaFuncionario.Columns.Add("Nome");
            TabelaFuncionario.Columns.Add("Email");
            TabelaFuncionario.Columns.Add("Matricula");

            dataGridView1.DataSource = TabelaFuncionario;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = Color.FromArgb(60, 60, 60);

            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.EnableHeadersVisualStyles = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameFuncionario = txtName.Text;
            string email = txtEmail.Text;
            int matricula = Convert.ToInt32(txtMatricula.Text);

            if (string.IsNullOrEmpty(nameFuncionario))
            {
                MessageBox.Show("Informe o nome do funcionario:");
                return;
            }
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Informe o Email:");
                return;
            }
            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                MessageBox.Show("Informe a matrícula:");
                return;
            }
            try
            {
                controller_funcionario.cadastrarFuncionario(nameFuncionario, email, matricula);
                MessageBox.Show($"Demanda: {nameFuncionario}, Email: {email}, matrícula: {matricula}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar");
            }
            TabelaFuncionario.Rows.Clear();
            var listagem = controller_funcionario.listarFuncionario();
            foreach (var item in listagem)
            {
                TabelaFuncionario.Rows.Add(item.nomeFuncionario, item.email, item.matricula);
            }


        }
    }
}

