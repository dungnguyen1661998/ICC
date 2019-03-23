using ICC.DataAccess.DAL;
using ICC.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICC.DataAccess.Implements
{
    public class FacilityRepository : Repository<Facility>, IFacilityRepository
    {
        private readonly ICCEntities _iCCEntities;
        public FacilityRepository(ICCEntities context) : base(context)
        {
            _iCCEntities = context;
        }
        public IEnumerable<Facility> GetBestFacilities(int amountOfFacilities)
        {
            return _iCCEntities.Facilities.Take(amountOfFacilities).ToList();
        }
    }
}