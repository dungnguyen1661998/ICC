using ICC.DataAccess.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICC.DataAccess.Interfaces
{
    public interface IOrderItemRepository
    {
        void Add(OrderItem orderItem);
        void Edit(OrderItem orderItem);
        void Remove(Guid? Id);
        IEnumerable GetProducts(); OrderItem FindById(Guid? Id);
    }
}
