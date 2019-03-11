using ICC.DataAccess.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICC.DataAccess.Interfaces
{
    public interface IBookMachineRepository
    {
        void Add(BookMachine bookMachine);
        void Edit(BookMachine bookMachine);
        void Remove(Guid? Id);
        IEnumerable GetProducts(); BookMachine FindById(Guid? Id);
    }
}
