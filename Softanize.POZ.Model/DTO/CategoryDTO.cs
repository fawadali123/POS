using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softanize.POZ.Model.DTO
{
    public class CategoryDTO
    {
        public long Id { get; set; }
        [Required(ErrorMessage ="Please enter Code")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Please enter Name")]
        public string Name { get; set; }
    }
}
