using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Softanize.POZ.DataAccess.Models
{
    public partial class Item
    {
        public Item()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public long Id { get; set; }
        [Required(ErrorMessage = "Please fill Code")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Please fill Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please fill Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please fill Price")]
        public decimal? Price { get; set; }
        [Required(ErrorMessage = "Please fill Gst")]
        public decimal? Gst { get; set; }
        public bool? DiscountEnabled { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public string DiscountValidFrom { get; set; }
        public string DiscountValidTo { get; set; }
        [Required(ErrorMessage = "Please fill RevisionNumber")]
        public string RevisionNumber { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsKitchenItem { get; set; }
        public long? SubCategoryId { get; set; }

        public virtual SubCategory SubCategory { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
