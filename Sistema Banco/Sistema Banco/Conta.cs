using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Banco
{
    class Conta
    {
        private int _numAgencia;
        private int _numConta;
        private string _cpfCliente;
        private float _saldo;

        public int NumAgencia { get => _numAgencia;}
        public int NumConta { get => _numConta;}
        public string CpfCliente { get => _cpfCliente;}
        public float Saldo { get => _saldo; protected set => _saldo = value; }

        public Conta(int numAgencia, int numConta, string cpfCliente, float saldo)
        {
            _numAgencia = numAgencia;
            _numConta = numConta;
            _cpfCliente = cpfCliente;
            Saldo = saldo;
        }

        public bool Retirar(float valor)
        {
            if (this.Saldo >= valor && valor >= 0)
            {
                this.Saldo -= valor;
                return true;
            }
            return false;
        }
        public bool Depositar(float valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor;
                return true;
            }
            return false;
        }
    }
}
