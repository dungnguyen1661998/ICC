using ICC.DataAccess.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICC.DataAccess.Interfaces
{
    public interface IItemRepository
    {
        void Add(Item item);
        void Edit(Item item);
        void Remove(Guid? Id);
        IEnumerable GetProducts(); Item FindById(Guid? Id);
    }
}
