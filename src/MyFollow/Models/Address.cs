using System.ComponentModel.DataAnnotations;

namespace MyFollow.Models
{
    /// <summary>
    /// Address Class
    /// </summary>
    public class Address : MyFollowBase
    {
        /// <summary>
        /// Street 1 Of Address
        /// </summary>
        [StringLength(50)]
        public string StreetOne { get; set; }

        /// <summary>
        /// Street 2 Of Address
        /// </summary>
        [StringLength(50)]
        public string StreetTwo { get; set; }

        /// <summary>
        /// City Of Address
        /// </summary>
        [StringLength(50)]
        public string City { get; set; }

        /// <summary>
        /// State Of Address
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Country Of Address
        /// </summary>
        [StringLength(50)]
        public string Country { get; set; }

        /// <summary>
        /// Pin Number Of Address
        /// </summary>
        [StringLength(20)]
        public string Pin { get; set; }
    }
}