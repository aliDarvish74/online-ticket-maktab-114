namespace DataTransferObject.DTOClasses
{
    public class RoleDTO : BaseDTO<Guid>
    {
        public string PersianName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int StatusOfRole { get; set; }
    }
}
