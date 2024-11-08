namespace DataTransferObject.DTOClasses
{
    public class BlobDTO : BaseDTO<int>
    {
        public string FileAddress { get; set; }
        public string MimeType { get; set; }
        public int FileSize { get; set; }
    }
}
