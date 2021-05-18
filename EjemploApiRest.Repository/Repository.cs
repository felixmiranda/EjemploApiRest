using EjemploApiRest.Abstractions;
using System;

namespace EjemploApiRest.Repository
{
    public interface IRepository<T> : ICrud<T>
    {

    }

    public class Repository<T> : IRepository<T> where T : IEntity
    {
        readonly IDbContext<T> _ctx;

        public Repository(IDbContext<T> ctx)
        {
            _ctx = ctx;
        }
        public void Delete(int id)
        {
            _ctx.Delete(id);
        }

        public System.Collections.Generic.IList<T> GetAll()
        {
            return _ctx.GetAll();
        }

        public T GetById(int id)
        {
            return _ctx.GetById(id);

        }

        public T Save(T entity)
        {
            return _ctx.Save(entity);
        }
    }
}
