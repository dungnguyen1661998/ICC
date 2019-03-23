using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ICC.DataAccess.Interfaces
{
    public interface IRepository<I> where I : class
    {
        I GetById(Guid id);
        IEnumerable<I> GetAll();
        IEnumerable<I> Find(Expression<Func<I, bool>> predicate);
        void Insert(I entity);
        void Update(I entity);
        void Delete(Guid id);
        //void Save();
    }
}
