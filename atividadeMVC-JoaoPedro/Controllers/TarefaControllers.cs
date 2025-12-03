using atividadeMVC_JoaoPedro.Model;
using Newtonsoft.Json;

namespace atividadeMVC_JoaoPedro.Controllers
{
    internal class TarefaControllers
    {
        [JsonProperty("Tarefas")]
        List<TarefaModel> listaTarefaModel = new List<TarefaModel>();

        public void cadastrarTarfea(string nomeTarefa, string data, string status)
        {
            if (string.IsNullOrEmpty(nomeTarefa) || string.IsNullOrEmpty(data) || string.IsNullOrEmpty(status))
            {
                return;
            }
            TarefaModel tarefas = new TarefaModel(nomeTarefa, data, status);
            var meuJson = JsonConvert.SerializeObject(listaTarefaModel);
            var ObjetoTarefa = JsonConvert.DeserializeObject<List<TarefaModel>>(meuJson);
            listaTarefaModel.Add(tarefas);
        }
        public List<TarefaModel> listarTarefa()
        {
            return listaTarefaModel;
        }

    }
}
