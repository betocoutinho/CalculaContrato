using System;
using System.Globalization;
using CalculaContrato.Entities;
using CalculaContrato.Services;

namespace CalculaContrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados do Contrato");
            Console.WriteLine("Numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Data (dd/MM/yyyy): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture); ;
            Console.WriteLine("Valor do Contrato: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Numero de Parcelas: ");
            int parcelas = int.Parse(Console.ReadLine());

            Contrato contrato1 = new Contrato(numero, data, parcelas, valor);
            ProcessaContrato Pc = new ProcessaContrato(new Paypal());

            Pc.Processamento(contrato1);

            contrato1.ExtratoContrato();


            



        }
    }
}
