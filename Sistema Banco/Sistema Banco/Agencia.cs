using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Banco
{
    class Agencia
    {
        private string _nome;
        private int _num;
        private List<Conta> _contas;

        public string Nome { get => _nome; private set => _nome = value; }
        public int Num
        {
            get => _num;
            private set
            {
                if (value > 0) _num = value;
                else throw new SystemException("O numero da agência deve ser maior que 0!");
            }
        }
        internal List<Conta> Contas { get => _contas; private set => _contas = value; }

        public Agencia(string nome, int num)
        {
            Nome = nome;
            Num = num;
            this.Contas = new List<Conta>();
        }
        public bool AddConta(Conta c)
        {
            if (c.NumAgencia != this.Num) return false;
            foreach(Conta x in Contas)
            {
                if (x.NumConta == c.NumConta) return false;
            }
            this.Contas.Add(c);
            return true;
        }
        public bool RemoverConta(Conta c)
        {
            return this.Contas.Remove(c);
        }
    }
}
