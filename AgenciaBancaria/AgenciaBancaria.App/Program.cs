using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Endereco endereco = new Endereco("Rua 14", "123456789", "Sao vicente", "SP");
                Cliente cliente = new Cliente("Elivelton", "123456", "456789", endereco);

                ContaCorrente conta = new ContaCorrente(cliente, 100);

                Console.WriteLine("Conta" + conta.Situacao + ": " + conta.NumeroConta + "-" +
                    conta.DigitoVerificador);

                string senha = "adc123456789";
                conta.Abrir(senha);

                Console.WriteLine("Conta" + conta.Situacao + ": " + conta.NumeroConta + "-" +
                    conta.DigitoVerificador);

                conta.Sacar(10, senha);

                Console.WriteLine("Saldo:" + conta.Saldo);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
