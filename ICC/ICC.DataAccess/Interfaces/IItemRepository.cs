using ICC.DataAccess.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICC.DataAccess.Interfaces
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetBestItems(int amountOfItems);
    }
}
