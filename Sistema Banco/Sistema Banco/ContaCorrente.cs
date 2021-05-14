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
            float limiteChequeEspecial,
            float jurosChequeEspecial) : base(numAgencia, numConta, cpfCliente, saldo)
        {
            this.LimiteChequeEspecial = limiteChequeEspecial;
            this.JurosChequeEspecial = jurosChequeEspecial;
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
