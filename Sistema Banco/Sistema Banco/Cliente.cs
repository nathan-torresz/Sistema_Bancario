using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Banco
{
    class Cliente
    {
        private string _nome;
        private string _cpf;

        public string Nome { get => _nome; private set => _nome = value; }
        public string Cpf { get => _cpf; private set => _cpf = value; }

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
        public bool Sacar(Conta c)
        {

        }
    }
}
