namespace Model.Entities
{
    public class Role : BaseEntity<Guid>
    {
        public string RolePersianName { get; set; } = string.Empty;
        public string RoleName { get; set; } = string.Empty;
        public string RoleDescription { get; set; } = string.Empty;
    }
}
