using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midleware.Donation.Domain.Repository
{
    public interface IRepositoryBase<T> where T : class
    {
        void add(T obj);

        T GetById(string id);

        IEnumerable<T> Getall();

        void Update(T obj);

        void Remove(T obj);
    }
}
