using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.InterfaceServices
{
    public interface IServiceEstacionamento
    {
        Task MarcaEntradaEstacionamento(Estacionamento estacionamento);
        Task MarcaSaidaEstacionamento(Estacionamento estacionamento);
        Task CalculaPagamento(Estacionamento estacionamento);
    }
}
