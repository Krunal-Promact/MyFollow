using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace MyFollow.Models
{
    /// <summary>
    /// My Follow Database Context
    /// </summary>
    public class MyFollowDbContext : IdentityDbContext
    {
        /// <summary>
        /// Product Owner Table
        /// </summary>
        public DbSet<ProductOwner> ProductOwner { get; set; }

        /// <summary>
        /// End User Table
        /// </summary>
        public DbSet<EndUser> EndUser { get; set; }

        /// <summary>
        /// Address Table
        /// </summary>
        public DbSet<Address> Address { get; set; }

        /// <summary>
        /// Product Table
        /// </summary>
        public DbSet<Product> Product { get; set; }

        /// <summary>
        /// Product And End User Mapping Table
        /// </summary>
        public DbSet<UserProductMapping> UserProductMapping { get; set; }
    }
}
