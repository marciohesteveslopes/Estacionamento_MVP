using Application.Interfaces;
using Domain.Interfaces.InterfaceEstacionamento;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.OpenApp
{
    public class EstacionamentoApp : IEstacionamentoApp
    {
        IEstacionamento _IEstacionamento;
        public EstacionamentoApp (IEstacionamento IEstacionamento)
        {
            _IEstacionamento = IEstacionamento;
        }


        public async Task Add(Estacionamento Objeto)
        {
            await _IEstacionamento.Add(Objeto);
        }

        public async Task Delete(Estacionamento Objeto)
        {
            await _IEstacionamento.Delete(Objeto);
        }

        async Task<Estacionamento> Interfaces.Generics.IGenericsApp<Estacionamento>.GetEntityById(string Id) => await _IEstacionamento.GetEntityById(Id);

        public async Task<List<Estacionamento>> List()
        {
            return await _IEstacionamento.List();
        }

        public async Task Update(Estacionamento Objeto)
        {
            await _IEstacionamento.Update(Objeto);
        }

        public Task<Estacionamento> GetEntityById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
