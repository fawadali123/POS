using System;
using System.Collections.Generic;

#nullable disable

namespace Softanize.POZ.DataAccess.Models
{
    public partial class MembershipType
    {
        public MembershipType()
        {
            Customers = new HashSet<Customer>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
