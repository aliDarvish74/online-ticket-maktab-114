namespace Model.Entities
{
    public class Blob : BaseEntity<int>
    {
        public string FileAddress { get; set; }
        public string MimeType { get; set; }
        public int FileSize { get; set; }
    }
}
