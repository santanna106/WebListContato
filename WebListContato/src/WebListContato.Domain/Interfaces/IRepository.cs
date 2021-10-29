using System;
using System.Collections.Generic;
using WebListContato.Domain.Entities;

namespace WebListContato.Domain.Interfaces
{
    public interface IRepository<T> : IDisposable where T : BaseEntity<int>
    {
        T Create(T item);
        T FindByID(int id);
        List<T> FindAll();
        T Update(T item);
        void Delete(int id);
        bool Exists(int id);
    }
}
