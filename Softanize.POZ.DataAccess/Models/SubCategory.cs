using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Softanize.POZ.DataAccess.Models
{
    public partial class SubCategory
    {
        public SubCategory()
        {
            Items = new HashSet<Item>();
        }

        public long Id { get; set; }
        [Required(ErrorMessage = "Please fill SubCategory Code")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Please fill SubCategory Name")]
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public long? CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
