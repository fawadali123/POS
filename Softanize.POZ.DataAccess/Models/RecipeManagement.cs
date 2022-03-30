using System;
using System.Collections.Generic;

#nullable disable

namespace Softanize.POZ.DataAccess.Models
{
    public partial class RecipeManagement
    {
        public long Id { get; set; }
        public long? ItemId { get; set; }
        public long? InventoryItemId { get; set; }
    }
}
