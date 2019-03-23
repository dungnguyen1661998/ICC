using ICC.DataAccess.DAL;
using ICC.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICC.DataAccess.Implements
{
    public class BuyFacilityRepository : Repository<BuyFacility>, IBuyFacilityRepository
    {
        private readonly ICCEntities _iCCEntities;
        public BuyFacilityRepository(ICCEntities context) : base(context)
        {
            _iCCEntities = context;
        }
        public IEnumerable<BuyFacility> GetBestBuyFacilities(int amountOfBuyFacilities)
        {
            return _iCCEntities.BuyFacilities.Take(amountOfBuyFacilities).ToList();
        }
    }
}