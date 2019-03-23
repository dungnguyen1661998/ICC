using ICC.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ICC.Services
{
    public interface IUnitOfWork : IDisposable
    {
        IUserAcountRepository UserAcount { get; }
        IUserRoleRepository UserRole { get; }
        IRoleRepository Role { get; }
        IOrderItemRepository OrderItem { get; }
        IMembershipRepository Membership { get; }
        IMachineRepository Machine { get; }
        IItemRepository Item { get; }
        IFacilityRepository Facility { get; }
        IBuyFacilityRepository BuyFacility { get; }
        IBookMachineRepository BookMachine { get; }

        int Complete();
    }
}
