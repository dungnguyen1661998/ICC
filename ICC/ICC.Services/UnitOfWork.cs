using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ICC.DataAccess.DAL;
using ICC.DataAccess.Implements;
using ICC.DataAccess.Interfaces;

namespace ICC.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        
        public readonly ICCEntities context;

        public UnitOfWork (ICCEntities _context)
        {
            context = _context;
            UserAcount = new UserAcountRepository(_context);
            UserRole = new UserRoleRepository(_context);
            Role = new RoleRepository(_context);
            OrderItem = new OrderItemRepository(_context);
            Membership = new MembershipRepository(_context);
            Machine = new MachineRepository(_context);
            Item = new ItemRepository(_context);
            Facility = new FacilityRepository(_context);
            BuyFacility = new BuyFacilityRepository(_context);
            BookMachine = new BookMachineRepository(_context);

           // UserAcounts = new UserAcountRepository(userAcount);
        }
        public IUserAcountRepository UserAcount { get; }

        public IUserRoleRepository UserRole { get; }

        public IRoleRepository Role { get; }

        public IOrderItemRepository OrderItem { get; }

        public IMembershipRepository Membership { get; }

        public IMachineRepository Machine { get; }

        public IItemRepository Item { get; }

        public IFacilityRepository Facility { get; }

        public IBuyFacilityRepository BuyFacility { get; }

        public IBookMachineRepository BookMachine { get; }

        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}