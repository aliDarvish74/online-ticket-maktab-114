namespace DataTransferObject
{
    public class BaseDTO<KeyTypeId> where KeyTypeId : struct
    {
        public KeyTypeId Id { get; set; }
    }
}
