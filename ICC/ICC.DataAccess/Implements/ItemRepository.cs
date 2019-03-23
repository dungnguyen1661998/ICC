using ICC.DataAccess.DAL;
using ICC.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICC.DataAccess.Implements
{
    public class ItemRepository : Repository<Item>, IItemRepository
    {
        private readonly ICCEntities _iCCEntities;
        public ItemRepository(ICCEntities context) : base(context)
        {
            _iCCEntities = context;
        }
        public IEnumerable<Item> GetBestItems(int amountOfItems)
        {
            return _iCCEntities.Items.Take(amountOfItems).ToList();
        }
    }
}