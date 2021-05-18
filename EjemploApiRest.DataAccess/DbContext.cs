using EjemploApiRest.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EjemploApiRest.DataAccess
{
    public class DbContext<T> : IDbContext<T> where T : class, IEntity
    {
        //readonly IList<T> _data;
        DbSet<T> _items;
        ApiDbContext _ctx;

        public DbContext( ApiDbContext ctx)
        {
            //_data = new List<T>();
            _ctx = ctx;
            _items = ctx.Set<T>();

        }
        public void Delete(int id)
        {
            //var e = _data.Where(u => u.Id.Equals(id)).FirstOrDefault();
            //if (e != null)
            //{
            //    _data.Remove(e);
            //}
        }

        public IList<T> GetAll()
        {
            //return _data;
            return _items.ToList();
        }

        public T GetById(int id)
        {
            //return _data.Where(e => e.Id.Equals(id)).FirstOrDefault();
            return _items.Where(i => i.Id.Equals(id)).FirstOrDefault();
        }

        public T Save(T entity)
        {
            //if (entity.Id.Equals(0))
            //{
            //    _data.Add(entity);
            //} else
            //{
            //    //actualizar el objeto

            //}
            //return entity;

            _items.Add(entity);
            _ctx.SaveChanges();
            return entity;
        }
    }
}
