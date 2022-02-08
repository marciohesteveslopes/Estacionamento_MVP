namespace Entities.Entities
{
    public class Pagamento
    {
        public decimal CalculaPagamento(TimeSpan duracaoEstacionamento, decimal valorHora, decimal valorAdicionalHora)
        {
            var totalAPagar = 0m;

            if ((duracaoEstacionamento.Hours == 0) && (duracaoEstacionamento.Minutes <= 30))
            {
                totalAPagar = valorHora / 2;
            }
            else if ((duracaoEstacionamento.Hours > 0) && (duracaoEstacionamento.Minutes > 10))
            {
                totalAPagar = valorHora + (valorAdicionalHora * duracaoEstacionamento.Hours);
            }
            else if ((duracaoEstacionamento.Hours > 0) && (duracaoEstacionamento.Minutes < 10))
            {
                totalAPagar = valorHora + (valorAdicionalHora * (duracaoEstacionamento.Hours - 1));
            }
            else
            {
                totalAPagar = valorHora;
            }

            return totalAPagar;
        }
    }
}
