using ICC.DataAccess.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICC.DataAccess.Interfaces
{
    public interface IUserRoleRepository
    {
        void Add(UserRole userRole);
        void Edit(UserRole userRole);
        void Remove(Guid? Id);
        IEnumerable GetProducts(); UserRole FindById(Guid? Id);
    }
}
