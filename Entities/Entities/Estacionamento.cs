using System.ComponentModel;

namespace Entities.Entities
{
    public class Estacionamento : Base
    {
        #region Atributos
        [DisplayName("Data e Hora da Entrada")]
        public DateTime DataHoraEntrada { get; set; }

        [DisplayName("Data e Hora da Saída")]
        public DateTime? DataHoraSaida { get; set; }

        [DisplayName("Duração da estadia")]
        public TimeSpan? DuracaoEstacionamento { get; set; }

        [DisplayName("Horas a cobrar")]
        public int? HorasEfetivas { get; set; }

        [DisplayName("Preço")]
        public decimal Preco { get; set; }

        [DisplayName("Quantia a ser paga")]
        public decimal? QuantiaAPagar { get; set; }
        #endregion

        #region Métodos
        public bool validarHoraSaida(DateTime dataHoraSaida)
        {
            if (dataHoraSaida < DataHoraEntrada)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void SetId(string id)
        {
            Id = id;
        }

        public void SetDataHoraEntrada(DateTime dataHoraEntrada)
        {
            DataHoraEntrada = dataHoraEntrada;
        }

        public void SetDataHoraSaida(DateTime dataHoraSaida)
        {
            if (dataHoraSaida < DataHoraEntrada)
            {
                throw new ArgumentException("Data de saída não pode ser menor que a Data de entrada do veículo.");
            }
            else
                DataHoraSaida = dataHoraSaida;
        }

        public void SetDuracaoEstacionamento(TimeSpan duracao)
        {
            DuracaoEstacionamento = duracao;
        }

        public void SetHorasEfetivas(int horasEfetivas)
        {
            HorasEfetivas = horasEfetivas;
        }

        public void SetPreco(decimal preco)
        {
            if (preco <= 0)
            {
                throw new ArgumentException("Valor da tarifa deve ser maior que ZERO.");
            }
            else
                Preco = preco;
        }

        public void SetQuantiaAPagar(decimal quantiaAPagar)
        {
            if (quantiaAPagar <= 0)
            {
                throw new ArgumentException("Quantia a pagar deve ser maior que ZERO.");
            }
            else
                QuantiaAPagar = quantiaAPagar;
        }

        #endregion
    }
}
