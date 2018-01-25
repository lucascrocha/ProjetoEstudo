using Microsoft.EntityFrameworkCore;
using ProjetoEstudo.Domain.Interfaces;
using ProjetoEstudo.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoEstudo.Infra.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private DbContextOptionsBuilder<ProjetoContext> _optionsBuilder;

        public RepositoryBase()
        {
            _optionsBuilder = new DbContextOptionsBuilder<ProjetoContext>();
        }

        public void Add(T entity)
        {
            using (var context = new ProjetoContext(_optionsBuilder.Options))
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new ProjetoContext(_optionsBuilder.Options))
            {
                var entidade = context.Set<T>().Find(id);
                context.Remove(entidade);
                context.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            using (var context = new ProjetoContext(_optionsBuilder.Options))
            {
                return context.Set<T>().ToList();
            }
        }

        public T GetById(int id)
        {
            using (var context = new ProjetoContext(_optionsBuilder.Options))
            {
                return context.Set<T>().Find(id);
            }
        }

        public void Update(T entity)
        {
            using (var context = new ProjetoContext(_optionsBuilder.Options))
            {
                context.Set<T>().Update(entity);
                context.SaveChanges();
            }
        }
    }
}