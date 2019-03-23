using ICC.DataAccess.DAL;
using ICC.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICC.DataAccess.Implements
{
    public class OrderItemRepository : Repository<OrderItem>, IOrderItemRepository
    {
        private readonly ICCEntities _iCCEntities;
        public OrderItemRepository(ICCEntities context) : base(context)
        {
            _iCCEntities = context;
        }
        public IEnumerable<OrderItem> GetBestOrderItems(int amountOfOrederItems)
        {
            return _iCCEntities.OrderItems.Take(amountOfOrederItems).ToList();
        }
    }
}