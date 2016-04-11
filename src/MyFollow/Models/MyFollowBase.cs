using System.ComponentModel.DataAnnotations;

namespace MyFollow.Models
{
    /// <summary>
    /// Base Class
    /// </summary>
    public class MyFollowBase
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        [Key]
        public int Id { get; set; }
    }
}