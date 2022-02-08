using Application.Interfaces;
using Domain.Interfaces.InterfaceEstacionamento;
using Entities.Entities;

namespace Application.OpenApp
{
    public class TarifaApp : ITarifaApp
    {
        ITarifa _ITarifa;

        public TarifaApp(ITarifa ITarifa)
        {
            _ITarifa = ITarifa;
        }
        public async Task Add(Tarifa Objeto)
        {
            await _ITarifa.Add(Objeto);
        }

        public async Task Delete(Tarifa Objeto)
        {
            await _ITarifa.Delete(Objeto);
        }

        async Task<Tarifa> Interfaces.Generics.IGenericsApp<Tarifa>
            .GetEntityById(string Id) => await _ITarifa.GetEntityById(Id);

        public async Task<List<Tarifa>> List()
        {
            return await _ITarifa.List();
        }

        public async Task Update(Tarifa Objeto)
        {
            await _ITarifa.Update(Objeto);
        }
    }
}
