using ICC.DataAccess.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICC.DataAccess.Interfaces
{
    public interface IMembershipRepository
    {
        void Add(Membership membership);
        void Edit(Membership membership);
        void Remove(Guid? Id);
        IEnumerable GetProducts(); Membership FindById(Guid? Id);
    }
}
