using System;
using System.Collections.Generic;

#nullable disable

namespace Softanize.POZ.DataAccess.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public long? MembershipTypeId { get; set; }
        public string MembershipCode { get; set; }
        public string MembershipValidFrom { get; set; }
        public string MembershipValidTo { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public long? BranchId { get; set; }

        public virtual MembershipType MembershipType { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
