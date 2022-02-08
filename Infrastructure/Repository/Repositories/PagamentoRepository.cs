using Domain.Interfaces.InterfaceEstacionamento;
using Entities.Entities;
using Infrastructure.Repository.Generics;

namespace Infrastructure.Repository.Repositories
{
    public class PagamentoRepository : GenericsRepository<Pagamento>, IPagamento
    {

    }
}
