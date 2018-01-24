using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudo.Domain.Interfaces
{
    public interface IRepositoryBase<Entity> where Entity : class
    {
        void Add(Entity entity);
        void Update(Entity entity);
        void Delete(int id);
        List<Entity> GetAll();
        Entity GetById(int id);
    }
}