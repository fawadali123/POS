using System;
using System.Collections.Generic;

#nullable disable

namespace Softanize.POZ.DataAccess.Models
{
    public partial class InventoryItem
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string StockValue { get; set; }
        public long? InventoryUomid { get; set; }
        public long? ConsumptionUomid { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
