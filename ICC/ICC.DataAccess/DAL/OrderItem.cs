//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ICC.DataAccess.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderItem
    {
        public System.Guid Id { get; set; }
        public System.Guid ItemId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public System.Guid UserId { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime InsAt { get; set; }
        public string InsBy { get; set; }
        public System.DateTime UpdAt { get; set; }
        public string UpdBy { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual UserAcount UserAcount { get; set; }
    }
}
