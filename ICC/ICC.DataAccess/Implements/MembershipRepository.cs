using ICC.DataAccess.DAL;
using ICC.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ICC.DataAccess.Implements
{
    public class MembershipRepository : Repository<Membership>, IMembershipRepository
    {
        private readonly ICCEntities _iCCEntities;
        public MembershipRepository(ICCEntities context) : base(context)
        {
            _iCCEntities = context;
        }
        public IEnumerable<Membership> GetBestMemberships(int amountOfMemberships)
        {
           return _iCCEntities.Memberships.Take(amountOfMemberships).ToList();
        }
    }
}