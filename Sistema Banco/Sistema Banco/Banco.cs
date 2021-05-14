using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Banco
{
    class Banco
    {
        private string _nome;
        private List<Agencia> _agencia;
        private List<Cliente> _clientes;

        public string Nome { get => _nome; private set => _nome = value; }
        public List<Agencia> Agencia { get => _agencia; private set => _agencia = value; }
        public List<Cliente> Clientes { get => _clientes; private set => _clientes = value; }

        public Banco(string nome)
        {
            Nome = nome;
            Agencia = new List<Agencia>();
            Clientes = new List<Cliente>();
        }

        public bool AddAgencia(Agencia a)
        {
            foreach(Agencia x in this.Agencia)
            {
                if (x.Num == a.Num) return false;
            }
            Agencia.Add(a);
            return true;
        }
        public bool RemoverAgencia(Agencia a)
        {
            return Agencia.Remove(a);
        }
        public bool IsCliente(Cliente c)
        {
            return Clientes.Contains(c);

        }

        public bool IsClienteEspecial(string cpf)
        {
            foreach(Cliente c in this.Clientes)
            {
                if (c.Cpf.Equals(cpf))
                {
                    if (c is ClienteEspecial) return true;
                    return false;
                }
            }
            throw new Exception("Cliente não encontrado!");
        }
    }
}
