using System;
using System.Collections.Generic;
using System.Text;

namespace CalculaContrato.Services
{
    class Paypal : IServicosExternos
    {
        public double Juros(double parcela)
        {
            return parcela * 1.01;
        }

        public double taxas(double parcela)
        {
            return parcela * 1.02;
        }
    }
}
