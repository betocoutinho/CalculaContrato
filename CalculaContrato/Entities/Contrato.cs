using System;
using System.Collections.Generic;
using System.Globalization;

namespace CalculaContrato.Entities
{
    class Contrato
    {
        public int NumeroContrato { get; private set; }
        public DateTime DataDoContrato { get; private set; }
        public int NumeroDeParcelas { get; private set; }

        public double ValorDoContrato { get; private set; }

        public List<Parcela> Parcelas { get; set; } = new List<Parcela>();

        public Contrato(int numeroContrato, DateTime dataDoContrato, int numeroDeParcelas, double valorDoContrato)
        {
            NumeroContrato = numeroContrato;
            DataDoContrato = dataDoContrato;
            NumeroDeParcelas = numeroDeParcelas;
            ValorDoContrato = valorDoContrato;
        }

        public void ExtratoContrato()
        {
            foreach (var item in Parcelas)
            {
                Console.WriteLine(item.DataDaParcela.ToString("dd/MM/yyyy") +" - " + item.ValorDaParcela.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
