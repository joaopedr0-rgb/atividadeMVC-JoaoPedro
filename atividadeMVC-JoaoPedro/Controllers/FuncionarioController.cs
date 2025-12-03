using atividadeMVC_JoaoPedro.Model;
using Newtonsoft.Json;

namespace atividadeMVC_JoaoPedro.Controllers
{

    internal class FuncionarioController
    {
        [JsonProperty("Funcionarios")]
        List<FuncionarioModel> listaFuncionarios = new List<FuncionarioModel>();
        public void cadastrarFuncionario(string nomeFuncionario, string email, int matricula)
        {

            if (string.IsNullOrEmpty(nomeFuncionario) || string.IsNullOrEmpty(email) || matricula == null)
            {
                return;
            }

            FuncionarioModel funcionario = new FuncionarioModel(nomeFuncionario, email, matricula);
            var meuJson = JsonConvert.SerializeObject(listaFuncionarios);
            var ObjetoFuncionario = JsonConvert.DeserializeObject<List<FuncionarioModel>>(meuJson);


            listaFuncionarios.Add(funcionario);
        }
        public List<FuncionarioModel> listarFuncionario()
        {

            return listaFuncionarios;
        }
    }
}
