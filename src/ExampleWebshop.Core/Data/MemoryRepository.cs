using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleWebshop.Core
{
    abstract class MemoryRepository<TEntity, TIdentifier> : IRepository<TEntity, TIdentifier> where TEntity : IIdentifiable<TIdentifier>
    {
        protected IList<TEntity> entities;

        public MemoryRepository()
        {
            entities = new List<TEntity>();
        }

        public virtual TEntity Add(TEntity entity)
        {
            entities.Add(entity);
            return entity;
        }

        public virtual IEnumerable<TEntity> Get()
        {
            return entities.ToList();
        }

        public virtual TEntity Get(TIdentifier id)
        {
            return entities.First(e => id.ToString() == e.GetIdentifier().ToString());
        }

        public virtual void Remove(TEntity entity)
        {
            entities.Remove(entity);
        }

        public virtual void Update(TEntity entity)
        {
            entities[entities.IndexOf(entity)] = entity;
        }
    }
}
