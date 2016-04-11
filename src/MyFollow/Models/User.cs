using System;
using System.ComponentModel.DataAnnotations;

namespace MyFollow.Models
{
    /// <summary>
    /// User Class
    /// </summary>
    public abstract class User : MyFollowBase
    {
        /// <summary>
        /// Email Address Of End User
        /// </summary>
        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        /// <summary>
        /// Joining Date Into The Application
        /// </summary>
        public DateTime DateOfJoining { get; } = DateTime.Today;

        /// <summary>
        /// User Contact Number
        /// </summary>
        [StringLength(20)]
        public string ContactNumber { get; set; }

        /// <summary>
        /// User Address Id Reference
        /// </summary>
        public int AddressId { get; set; }

        /// <summary>
        /// User Address Reference
        /// </summary>
        public virtual Address Address { get; set; }
    }
}