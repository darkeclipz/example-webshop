using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExampleWebshop.Core
{
    abstract class TextRepository<TEntity, TIdentifier> : IRepository<TEntity, TIdentifier> where TEntity : IIdentifiable<TIdentifier>
    {
        protected IList<TEntity> entities;
        private readonly string filePath = $"{Directory.GetCurrentDirectory()}/{typeof(TEntity).Name}.txt";

        public TextRepository()
        {
            if(File.Exists(filePath))
            {
                entities = JsonConvert.DeserializeObject<List<TEntity>>(File.ReadAllText(filePath));
            }
            else
            {
                entities = new List<TEntity>();
            }           
        }

        private void Save()
        {
            File.WriteAllText(filePath, JsonConvert.SerializeObject(entities));
        }

        public virtual TEntity Add(TEntity entity)
        {
            entities.Add(entity);
            Save();
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
            Save();
        }

        public virtual void Update(TEntity entity)
        {
            entities[entities.IndexOf(entity)] = entity;
            Save();
        }
    }
}
