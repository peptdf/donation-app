using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midleware.Domain.Service.Contracts
{
    public interface IServiceBase<T> where T : class
    {
        void add(T obj);

        T GetById(int id);

        IEnumerable<T> Getall();

        void Update(T obj);

        void Remove(int id);
    }
}
