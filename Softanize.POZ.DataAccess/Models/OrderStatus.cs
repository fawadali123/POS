using System;
using System.Collections.Generic;

#nullable disable

namespace Softanize.POZ.DataAccess.Models
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            Orders = new HashSet<Order>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
