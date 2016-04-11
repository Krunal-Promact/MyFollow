using System.ComponentModel.DataAnnotations;

namespace MyFollow.Models
{
    /// <summary>
    /// Product Class
    /// </summary>
    public class Product : MyFollowBase
    {
        /// <summary>
        /// Name Of The Product
        /// </summary>
        [StringLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// Short Description Of The Product
        /// </summary>
        [StringLength(500)]
        public string Intro { get; set; }

        /// <summary>
        /// Long Description Of The Product
        /// </summary>
        [StringLength(1000)]
        public string Detail { get; set; }

        /// <summary>
        /// Name Of The First Uploaded Media
        /// </summary>
        [StringLength(50)]
        public string Media1 { get; set; }

        /// <summary>
        /// Name Of The Second Uploaded Media
        /// </summary>
        [StringLength(50)]
        public string Media2 { get; set; }

        /// <summary>
        /// Name Of The Third Uploaded Media
        /// </summary>
        [StringLength(50)]
        public string Media3 { get; set; }

        /// <summary>
        /// Name Of The Fourth Uploaded Media
        /// </summary>
        [StringLength(50)]
        public string Media4 { get; set; }

        /// <summary>
        /// Name Of The Fifth Uploaded Media
        /// </summary>
        [StringLength(50)]
        public string Media5 { get; set; }

        /// <summary>
        /// Reference Id Of The Product Owner
        /// </summary>
        public int ProductOwnerId { get; set; }

        /// <summary>
        /// Product Owner Reference
        /// </summary>
        public virtual ProductOwner ProductOwner { get; set; }
    }
}