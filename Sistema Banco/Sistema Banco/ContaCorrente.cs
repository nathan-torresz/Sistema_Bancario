using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Banco
{
    class ContaCorrente : Conta
    {
        private float _limiteChequeEspecial;
        private float _jurosChequeEspecial;
        public float LimiteChequeEspecial { get => _limiteChequeEspecial; private set => _limiteChequeEspecial = value; }
        public float JurosChequeEspecial { get => _jurosChequeEspecial; private set => _jurosChequeEspecial = value; }
        public ContaCorrente(int numAgencia, int numConta, string cpfCliente, float saldo, 
            bool isClienteEspecial) : base(numAgencia, numConta, cpfCliente, saldo)
        {
            if (!isClienteEspecial)
            {
                this.LimiteChequeEspecial = 100f;
                this.JurosChequeEspecial = 0.01f;
            }
            else
            {
                this.LimiteChequeEspecial = 1000f;
                this.JurosChequeEspecial = 0.005f;
            }
        }

        public float CobrarJuros(int dias)
        {
            if (this.Saldo < 0)
            {
                float valor = Math.Abs(this.Saldo);
                valor *= this.JurosChequeEspecial * dias;
                this.Saldo -= this.JurosChequeEspecial * dias;
                return valor;
            }
            return 0;
        }
    }
}
