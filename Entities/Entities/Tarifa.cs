using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Tarifa : Base
    {
        #region Atributos

        public decimal ValorHora { get; private set; }

        public decimal ValorAdicionalHora { get; private set; }

        public DateTime DataEfetivaInicial { get; private set; }

        public DateTime DataEfetivaFinal { get; private set; }

        #endregion

        #region Métodos

        public void SetValorHora(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentOutOfRangeException("Valor da Hora deve ser maior que ZERO.");
            else
                ValorHora = valor;
        }

        public void SetValorAdicionalHora(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentOutOfRangeException("Valor Adicional da Hora deve ser maior que ZERO.");
            else
                ValorAdicionalHora = valor;
        }

        public void SetDataEfetivaInicial(DateTime data)
        {
            DataEfetivaInicial = data;
        }

        public void SetDataEfetivaFinal(DateTime date)
        {
            DataEfetivaFinal = date;
        }

        #endregion
    }
}
