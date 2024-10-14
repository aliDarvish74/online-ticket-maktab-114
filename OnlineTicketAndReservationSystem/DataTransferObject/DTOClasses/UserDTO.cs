namespace DataTransferObject.DTOClasses
{
    public class UserDTO : BaseDTO<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
    }
}
