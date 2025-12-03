namespace atividadeMVC_JoaoPedro.Model
{
    public class FuncionarioModel
    {

        public string nomeFuncionario { get; set; }


        public string email { get; set; }

        public int matricula { get; set; }

        public FuncionarioModel(string nome, string email, int matricula)
        {
            this.nomeFuncionario = nome;
            this.email = email;
            this.matricula = matricula;
        }
    }
}
