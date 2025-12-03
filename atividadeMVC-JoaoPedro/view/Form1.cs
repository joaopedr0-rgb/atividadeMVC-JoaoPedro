using atividadeMVC_JoaoPedro.Controllers;
using System.Data;

namespace atividadeMVC_JoaoPedro
{
    public partial class Form1 : Form
    {
        DataTable tabelaTarefas = new DataTable();

        TarefaControllers tarefaController = new TarefaControllers();
        public Form1()
        {
            InitializeComponent();
            ConfigureGrid();
        }
        private void ConfigureGrid()
        {
            tabelaTarefas.Columns.Add("Tarefa");
            tabelaTarefas.Columns.Add("Data");
            tabelaTarefas.Columns.Add("Status");

            dataGridView1.DataSource = tabelaTarefas;

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
            string Status = status.Text;
            string data = dateTime.Value.ToShortDateString();
            string nomeTarefa = Tarefa.Text;


            if (string.IsNullOrWhiteSpace(nomeTarefa))
            {
                MessageBox.Show("Informe o nome da tarefa.");
                return;
            }
            if (string.IsNullOrWhiteSpace(Status))
            {
                MessageBox.Show("Informe o status da tarefa.");
                return;
            }

            try
            {
                tarefaController.cadastrarTarfea(nomeTarefa, data, Status);
                // Mensagem (corrigindo interpolação)
                MessageBox.Show($"Demanda {nomeTarefa}, com a data {data}. Criada com sucesso.");

            }
            catch (Exception ex)
            {
                // Mensagem (corrigindo interpolação)
                MessageBox.Show($"Error ao cadastrar {ex}");
            }
            tabelaTarefas.Clear();
            var listagem = tarefaController.listarTarefa();

            foreach (var item in listagem)
            {
                tabelaTarefas.Rows.Add(item.nomeTarefa, item.data, item.status);

            }

            // Limpa campos
            Tarefa.Clear();
            status.SelectedIndex = -1;

        }
    }
}
