using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Softanize.POZ.DataAccess.Models
{
    public partial class Category
    {
        public Category()
        {
            SubCategories = new HashSet<SubCategory>();
        }
        [Key]
        public long Id { get; set; }
        [Required(ErrorMessage ="Please fill Category Code")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Please fill Category Name")]
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}
