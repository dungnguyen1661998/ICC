using ICC.DataAccess.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICC.DataAccess.Interfaces
{
    public interface IUserAcountRepository
    {
        void Add(UserAcount userAcount);
        void Edit(UserAcount userAcount);
        void Remove(Guid? Id);
        IEnumerable GetProducts(); UserAcount FindById(Guid? Id);
    }
}
