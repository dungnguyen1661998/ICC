using ICC.DataAccess.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICC.DataAccess.Interfaces
{
    public interface IFacilityRepository
    {
        void Add(Facility facility);
        void Edit(Facility facility);
        void Remove(Guid? Id);
        IEnumerable GetProducts(); Facility FindById(Guid? Id);
    }
}
