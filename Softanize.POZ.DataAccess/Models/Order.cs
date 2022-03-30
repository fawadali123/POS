using System;
using System.Collections.Generic;

#nullable disable

namespace Softanize.POZ.DataAccess.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public long Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public string InvoiceNumber { get; set; }
        public long? CustomerId { get; set; }
        public long? OrderTypeId { get; set; }
        public long? OrderStatusId { get; set; }
        public long? BranchId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual OrderType OrderType { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
