namespace SharedKernel
{
    public abstract class BaseEntity : BaseEntity<int>
    {


    }
    public abstract class BaseEntity<T> where T : struct
    {
        public T Id { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public bool IsDeleted { get; set; }

        public byte[]? Timestamp { get; set; }
    }
}
