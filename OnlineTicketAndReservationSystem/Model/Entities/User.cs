namespace Model.Entities
{
    /// <summary>
    /// The User Entity
    /// </summary>
    public class User : BaseEntity<Guid>
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
        /// The email of user
        /// </summary>
        public string Email { get; set; } = string.Empty;
        /// <summary>
        /// The password of user
        /// </summary>
        public string Password { get; set; } = string.Empty;
        /// <summary>
        /// The time of DOB of user
        /// </summary>
        public DateTime? DateOfBirth { get; set; }
        /// <summary>
        /// The user name of user
        /// </summary>
        public string Username { get; set; } = string.Empty;
    }
}
