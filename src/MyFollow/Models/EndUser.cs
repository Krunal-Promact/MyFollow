using System;
using System.ComponentModel.DataAnnotations;

namespace MyFollow.Models
{
    /// <summary>
    /// End User Class
    /// </summary>
    public class EndUser : User
    {
        /// <summary>
        /// Gender Of End User
        /// </summary>
        [StringLength(10)]
        public string Gender { get; set; }

        /// <summary>
        /// End User Birth Date
        /// </summary>
        public DateTime DateOfBirth { get; set; }
    }
}