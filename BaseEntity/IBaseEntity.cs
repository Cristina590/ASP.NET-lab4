namespace lab4.BaseEntity
{
    public interface IBaseEntity
    {
        public Guid Id { get; set; }
        DateTime? DateCreated { get; set; }
        DateTime? DateModified { get; set; }
    }
}
