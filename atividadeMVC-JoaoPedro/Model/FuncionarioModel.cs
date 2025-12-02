using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace atividadeMVC_JoaoPedro.Model
{
    internal class FuncionarioModel
    {
        public string nomeFuncionario { get; set; }
        public string email { get; set; }
        public int matricula { get; set; }

        public FuncionarioModel(string nome, string email,int matricula )
        {
            this.nomeFuncionario = nome;
            this.email = email;
            this.matricula = matricula;
        }
    }
}
