using ICC.DataAccess.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICC.DataAccess.Interfaces
{
    public interface IMachineRepository
    {
        void Add(Machine machine);
        void Edit(Machine machine);
        void Remove(Guid? Id);
        IEnumerable GetProducts(); Machine FindById(Guid? Id);
    }
}
