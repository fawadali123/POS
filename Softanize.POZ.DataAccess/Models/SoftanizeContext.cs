using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Softanize.POZ.DataAccess.Models
{
    public partial class SoftanizeContext : IdentityDbContext
    {

        public SoftanizeContext(DbContextOptions<SoftanizeContext> options)
            : base(options)
        {
        }


    }
}
