namespace DataTransferObject.DTOClasses
{
    public class MenuItemDTO : BaseDTO<int>
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Link { get; set; }
        public bool ShowBadge { get; set; }
        public bool? IsRepaired { get; set; }
    }
}
