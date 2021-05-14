using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Banco
{
    class AgenciaFisica: Agencia
    {
        private string _endereco;
        public string Endereco { get => _endereco; private set => _endereco = value; }

        public AgenciaFisica(string nome, int num, string endereco): base(nome, num)
        {
            Endereco = endereco;
        }
    }
}
