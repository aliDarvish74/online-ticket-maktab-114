using Microsoft.AspNetCore.Identity;

namespace Model.Entities
{
    /// <summary>
    /// The User Entity
    /// </summary>
    public class User : IdentityUser<Guid>
    {
        /// <summary>
        /// The first name of user
        /// </summary>
        public string FirstName { get; set; } = string.Empty;
        /// <summary>
        /// The last name of user
        /// </summary>
        public string LastName { get; set; } = string.Empty;
        /// <summary>
        /// The time of DOB of user
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        public int? AvatarId { get; set; }

        public DateTime CreatedDateTime { get; set; }
        /// <summary>
        /// The date time of data has updated in system
        /// </summary>
        public DateTime UpdatedDataTime { get; set; }
        /// <summary>
        /// The id of user where created data in system
        /// </summary>
        public Guid? CreatedUserId { get; set; }
        /// <summary>
        /// The id of user where updated data in system
        /// </summary>
        public Guid? UpdatedUserId { get; set; }

        public virtual User CreateUser { get; set; }

        public virtual User UpdateUser { get; set; }

        public virtual Blob? Avatar { get; set; }

        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
