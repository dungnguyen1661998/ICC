using ICC.DataAccess.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICC.DataAccess.Interfaces
{
    public interface IBuyFacilityRepository
    {
        void Add(BuyFacility buyFacility);
        void Edit(BuyFacility buyFacility);
        void Remove(Guid? Id);
        IEnumerable GetProducts(); BuyFacility FindById(Guid? Id);
    }
}
