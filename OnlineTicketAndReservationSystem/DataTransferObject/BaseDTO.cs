namespace DataTransferObject
{
    public abstract class BaseDTO<KeyTypeId> where KeyTypeId : struct
    {
        public KeyTypeId Id { get; set; }
    }
}
