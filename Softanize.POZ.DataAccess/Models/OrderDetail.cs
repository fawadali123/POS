using System;
using System.Collections.Generic;

#nullable disable

namespace Softanize.POZ.DataAccess.Models
{
    public partial class OrderDetail
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public long ItemId { get; set; }
        public decimal Quantity { get; set; }
        public decimal? Gst { get; set; }
        public decimal? ServiceCharge { get; set; }
        public decimal? Discount { get; set; }

        public virtual Item Item { get; set; }
        public virtual Order Order { get; set; }
    }
}
