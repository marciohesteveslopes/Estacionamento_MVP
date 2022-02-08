using Domain.Interfaces.InterfaceEstacionamento;
using Entities.Entities;
using Infrastructure.Configuration;
using Infrastructure.Repository.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Repositories
{
    public class TarifaRepository : GenericsRepository<Tarifa>, ITarifa
    {
        
    }
}
