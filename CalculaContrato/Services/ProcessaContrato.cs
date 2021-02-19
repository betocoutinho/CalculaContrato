using System;
using System.Collections.Generic;
using System.Text;
using CalculaContrato.Services;

namespace CalculaContrato.Entities
{
    class ProcessaContrato
    {
        private ServiçosExternos _serviço;

        public ProcessaContrato(ServiçosExternos serviço)
        {
            _serviço = serviço;
        }

        public void Processamento(Contrato contrato)
        {
            //Calcular o valor da parcela
            double parcela = contrato.ValorDoContrato / contrato.NumeroDeParcelas;

            double novaParcela = parcela;

            for (int i = 1; i <= contrato.NumeroDeParcelas; i++)
            {
                DateTime novaData = contrato.DataDoContrato.AddMonths(i);

                double temp1 = _serviço.Juros(novaParcela);

                double temp2 = _serviço.taxas(temp1);
                novaParcela = temp2;

                contrato.Parcelas.Add(new Parcela(novaData, temp2));

               
            }
        }
        
    }
}
