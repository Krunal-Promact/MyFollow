using System;
using System.ComponentModel.DataAnnotations;

namespace MyFollow.Models
{
    /// <summary>
    /// Product Owner Class
    /// </summary>
    public class ProductOwner : User
    {
        /// <summary>
        /// Name Of The Product Owner
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// Company Name Own By Product Owner
        /// </summary>
        [Required]
        [StringLength(50)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Description Of Company Owned By Product Owner
        /// </summary>
        [StringLength(100)]
        public string Description { get; set; }

        /// <summary>
        /// Establishment Date Of Company
        /// </summary>
        public DateTime FoundedIn { get; set; }

        /// <summary>
        /// Company Web Site URL
        /// </summary>
        [StringLength(50)]
        public string WebSiteUrl { get; set; }

        /// <summary>
        /// Twitter Handle Of The Company
        /// </summary>
        [StringLength(50)]
        public string TwitterHandle { get; set; }

        /// <summary>
        /// Facebook Page Url Of Company
        /// </summary>
        [StringLength(100)]
        public string FacebookPageUrl { get; set; }

        /// <summary>
        /// Role To Differentiate Product Owner From Admin
        /// </summary>
        [StringLength(10)]
        public string Role { get; set; }

        /// <summary>
        /// Random Number To Be Sent In Registration Link
        /// </summary>
        [StringLength(20)]
        public string RandomNumber { get; set; }
    }
}
