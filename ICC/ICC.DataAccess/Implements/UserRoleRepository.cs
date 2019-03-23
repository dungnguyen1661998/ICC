using ICC.DataAccess.DAL;
using ICC.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICC.DataAccess.Implements
{
    public class UserRoleRepository : Repository<UserRole>, IUserRoleRepository
    {
        private readonly ICCEntities _iCCEntities;
        public UserRoleRepository(ICCEntities context) : base(context)
        {
            _iCCEntities = context;
        }
        public IEnumerable<UserRole> GetBestUserRoles(int amountOfUserRoles)
        {
            return _iCCEntities.UserRoles.Take(amountOfUserRoles).ToList();
        }
    }
}