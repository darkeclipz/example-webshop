using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleWebshop.Core
{
    public interface IRepository<T, I>
    {
        T Add(T entity);
        void Remove(T entity);
        IEnumerable<T> Get();
        T Get(I id);
        void Update(T entity);
    }
}
