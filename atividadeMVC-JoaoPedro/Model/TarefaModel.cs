using System;
using System.Collections.Generic;
using System.Text;

namespace atividadeMVC_JoaoPedro.Model
{
    internal class TarefaModel
    {
        public string nomeTarefa{ get; set; }
        public string status { get; set; }
        public string data { get; set; }

        public TarefaModel(string nomeTarefa, string status, string data)
        {
            this.nomeTarefa = nomeTarefa;
            this.status = status;
            this.data = data;
        }

    }
}
