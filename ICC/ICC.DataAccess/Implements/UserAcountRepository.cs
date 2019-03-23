using ICC.DataAccess.DAL;
using ICC.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICC.DataAccess.Implements
{
    public class UserAcountRepository : Repository<UserAcount>, IUserAcountRepository
    {
        private readonly ICCEntities _iCCEntities;
        public UserAcountRepository(ICCEntities context) : base(context)
        {
            _iCCEntities = context;
        }
        public IEnumerable<UserAcount> GetBestUserAcounts(int amountOfUserAcounts)
        {
            return _iCCEntities.UserAcounts.Take(amountOfUserAcounts).ToList();
        }
    }
}