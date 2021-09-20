using System;
using AgenciaBancaria.Dominio;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Endereco endereco = new Endereco("rua aracia", "26478", "Olinda", "Pernambuco");
                Cliente cliente = new Cliente("Gisele", "1633788", "73847", endereco);


                ContaCorrente conta = new ContaCorrente(cliente, 100);

                Console.WriteLine("Conta " + conta.Situacao + ": " + conta.NumeroConta + "-" + conta.DigitoVerificador);

                string senha = "abc4378579";
                conta.Abrir(senha);

                Console.WriteLine("Conta " + conta.Situacao + ": " + conta.NumeroConta + "-" + conta.DigitoVerificador);

                conta.Sacar(10, senha);

                Console.WriteLine("Saldo: " + conta.Saldo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
