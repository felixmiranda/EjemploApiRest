using EjemploApiRest.Abstractions;
using System;

namespace EjemploApiRest.Repository
{
    public interface IRepository<T> : ICrud<T>
    {

    }

    public class Repository<T> : IRepository<T>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.IList<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T Save(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
