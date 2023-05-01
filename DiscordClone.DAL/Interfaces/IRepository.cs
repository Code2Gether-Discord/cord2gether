using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordClone.DAL.Interfaces
{
    internal interface IRepository<TEntity> where TEntity : class
    {
        // Retrieves a single entity by its primary key
        TEntity GetById(int id);

        // Retrieves all entities of this type
        IEnumerable<TEntity> GetAll();

        // Adds a new entity to the repository
        void Add(TEntity entity);

        // Removes an entity from the repository
        void Remove(TEntity entity);

        //TODO : Add more methods to hand CRUD operations
    }
}
