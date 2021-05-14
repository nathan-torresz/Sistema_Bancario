using System;

namespace Sistema_Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco b = new Banco("Santander");
            Agencia a1 = new Agencia("Agencia Santana", 555);
            Agencia a2 = new Agencia("Agencia Santamerica", 809);

            Cliente c1 = new Cliente("Nathan", "001");
            Cliente c2 = new Cliente("Antenor", "002");
            ClienteEspecial ce1 = new ClienteEspecial("Carol", "003");

            b.AddAgencia(a1);
            b.AddAgencia(a2);
            b.Clientes.Add(c1);
            b.Clientes.Add(c2);
            b.Clientes.Add(ce1);

            ContaCorrente ct1 = new ContaCorrente(214, 5555, "001", 100f, b.IsClienteEspecial("001"));
            ContaPoupanca cp1 = new ContaPoupanca(315,8891, "002", 1000f, 0.01f);
            ContaCorrente ct2 = new ContaCorrente(214, 5555, "003", 100f, b.IsClienteEspecial("003"));

            a1.AddConta(ct1);
            a2.AddConta(cp1);

        }
    }
}
