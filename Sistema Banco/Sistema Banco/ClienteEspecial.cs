using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Banco
{
    class ClienteEspecial : Cliente
    {
        public ClienteEspecial(string nome, string cpf) : base(nome, cpf)
        {
        }
    }
}
