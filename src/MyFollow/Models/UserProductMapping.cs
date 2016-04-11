using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFollow.Models
{
    /// <summary>
    /// User And Product Mapping Class
    /// </summary>
    public class UserProductMapping : MyFollowBase
    {
        /// <summary>
        /// User Id Of End User
        /// </summary>
        [ForeignKey("EndUserId")]
        public int UsreId { get; set; }

        /// <summary>
        /// End User Reference
        /// </summary>
        public ICollection<EndUser> EndUser { get; set; }

        /// <summary>
        /// Product Id Of The Product Which Is Followed By End User
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Product Reference
        /// </summary>
        public ICollection<Product> Product { get; set; }
    }
}