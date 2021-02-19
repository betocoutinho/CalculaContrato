using System;
using System.Collections.Generic;
using System.Text;

namespace CalculaContrato.Entities
{
    class Parcela
    {
        public DateTime DataDaParcela { get; set; }
        public double ValorDaParcela { get; set; }

        public Parcela(DateTime dataDaParcela, double valorDaParcela)
        {
            DataDaParcela = dataDaParcela;
            ValorDaParcela = valorDaParcela;
        }
    }
}
