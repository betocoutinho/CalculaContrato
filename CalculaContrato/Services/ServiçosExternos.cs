using System;
using System.Collections.Generic;
using System.Text;

namespace CalculaContrato.Services
{
    interface ServiçosExternos
    {
        double Juros(double parcela);
        double taxas(double parcela);
    }
}
