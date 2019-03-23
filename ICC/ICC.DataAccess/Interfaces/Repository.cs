using ICC.DataAccess.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace ICC.DataAccess.Interfaces
{
    public class Repository<I> : IRepository<I> where I : class
    {
        private  DbSet<I> _entities;
        private DbContext _context;
        public Repository(DbContext context)
        {
            _entities = context.Set<I>();
            _context = context;
        }

        public void Delete(Guid id)
        {
            var entity = _entities.Find(id);
            _entities.Remove(entity);
        }

        public IEnumerable<I> Find(Expression<Func<I, bool>> predicate)
        {
            return _entities.Where(predicate);
        }

        public IEnumerable<I> GetAll()
        {
            return _entities.ToList();
        }

        public I GetById(Guid id)
        {
            return _entities.Find(id);
        }

        public void Insert(I entity)
        {
            _entities.Add(entity);
        }

        //public void Save()
        //{
        //    _entities.s
        //}

        public void Update(I entity)
        {
            _entities.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;

        }
        //private ICCEntities db = new ICCEntities();

        //public Repository(DbContext context)
        //{
        //    _entities = context.Set<I>();
        //}

        //public I GetById    (Guid id)
        //{
        //    return _entities.Find(id);
        //}
        //public IEnumerable<I> GetAll()
        //{
        //    return _entities.ToList();
        //}
        //public IEnumerable<I> Find(Expression<Func<I, bool>> predicate)
        //{
        //    return _entities.Where(predicate);
        //}


    }
}