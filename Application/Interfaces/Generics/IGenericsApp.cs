﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Generics
{
    public interface IGenericsApp<T> where T : class
    {
        Task Add(T Objeto);
        Task Update(T Objeto);
        Task Delete(T Objeto);
        Task<T> GetEntityById(string Id);
        Task<List<T>> List();
    }
}
