﻿using ICC.DataAccess.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICC.DataAccess.Interfaces
{
    public interface IRoleRepository
    {
        IEnumerable<Role> GetBestRoles(int amountOfRoles);
    }
}
