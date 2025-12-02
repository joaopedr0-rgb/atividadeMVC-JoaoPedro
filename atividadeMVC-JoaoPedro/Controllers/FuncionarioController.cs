using System;
using System.Collections.Generic;
using System.Text;

namespace atividadeMVC_JoaoPedro.Controllers
{
    internal class FuncionarioController
    {
        List<string> listaFuncionarios = new List<string>();
        public void cadastrarFuncionario(string nomeFuncionario, string email, int matricula)
        {
            if(string.IsNullOrEmpty(nomeFuncionario) || string.IsNullOrEmpty(email) || matricula == null)
            {
                return;
            }
            listaFuncionarios.Add(nomeFuncionario);
        }
        public List<string> listarFuncionario()
        {
            return listaFuncionarios;
        }
    }
}
