using ICC.DataAccess.DAL;
using ICC.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICC.DataAccess.Implements
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        private readonly ICCEntities _iCCEntities;
        public RoleRepository(ICCEntities context) : base(context)
        {
            _iCCEntities = context;
        }
        public IEnumerable<Role> GetBestRoles(int amountOfRoles)
        {
            return _iCCEntities.Roles.Take(amountOfRoles).ToList();
        }
    }
}