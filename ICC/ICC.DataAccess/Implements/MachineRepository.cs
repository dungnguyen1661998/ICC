using ICC.DataAccess.DAL;
using ICC.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICC.DataAccess.Implements
{
    public class MachineRepository : Repository<Machine>, IMachineRepository
    {
        private readonly ICCEntities _iCCEntities;
        public MachineRepository(ICCEntities context) : base(context)
        {
            _iCCEntities = context;
        }
        public IEnumerable<Machine> GetBestMachines(int amountOfMachines)
        {
            return _iCCEntities.Machines.Take(amountOfMachines).ToList();
        }
    }
}