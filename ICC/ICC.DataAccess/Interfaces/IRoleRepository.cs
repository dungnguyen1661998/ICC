﻿using ICC.DataAccess.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICC.DataAccess.Interfaces
{
    public interface IRoleRepository
    {
        void Add(Role role);
        void Edit(Role role);
        void Remove(Guid? Id);
        IEnumerable GetProducts(); Role FindById(Guid? Id);
    }
}