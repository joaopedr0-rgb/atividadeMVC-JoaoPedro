using atividadeMVC_JoaoPedro.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace atividadeMVC_JoaoPedro.Controllers
{
    internal class TarefaControllers
    {
        List<TarefaModel> listaTarefaModel = new List<TarefaModel>();

        public void cadastrarTarfea(string nomeTarefa, string data, string status)
        {
            if(string.IsNullOrEmpty(nomeTarefa) || string.IsNullOrEmpty(data) || string.IsNullOrEmpty(status))
            {
                return;
            }
            TarefaModel tarefas = new TarefaModel(nomeTarefa, data, status);
            listaTarefaModel.Add(tarefas);
        }
        public List<TarefaModel> listarTarefa()
        {
            return listaTarefaModel;
        }
        
    }
}
