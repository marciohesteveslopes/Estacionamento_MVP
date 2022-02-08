using Domain.Interfaces.InterfaceEstacionamento;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceEstacionamento : IServiceEstacionamento
    {
        private readonly IEstacionamento _IEstacionamento;
        public ServiceEstacionamento(IEstacionamento IEstacionamento)
        {
            _IEstacionamento = IEstacionamento;
        }
        public async Task MarcaEntradaEstacionamento(Estacionamento estacionamento)
        {
            var validarPreco = estacionamento.ValidarPropriedadeDecimal(estacionamento.Preco, "Preco");
            if (validarPreco)
            {
                await _IEstacionamento.Add(estacionamento);
            }
        }

        public async Task MarcaSaidaEstacionamento(Estacionamento estacionamento)
        {
            
            var horaSaida = estacionamento.DataHoraSaida;
            if (estacionamento.validarHoraSaida((DateTime)horaSaida))
            {
                await _IEstacionamento.Add(estacionamento);
            }
        }

        public async Task CalculaPagamento(Estacionamento estacionamento)
        {
             
        }
    }
}
