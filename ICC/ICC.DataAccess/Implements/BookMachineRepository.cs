using ICC.DataAccess.DAL;
using ICC.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICC.DataAccess.Implements
{
    public class BookMachineRepository : Repository<BookMachine>, IBookMachineRepository
    {
        private readonly ICCEntities _iCCEntities;
        public BookMachineRepository(ICCEntities context) : base(context)
        {
            _iCCEntities = context;
        }
        public IEnumerable<BookMachine> GetBestBookMachines(int amountOfBookMachines)
        {
            return _iCCEntities.BookMachines.Take(amountOfBookMachines).ToList();
        }
    }
}