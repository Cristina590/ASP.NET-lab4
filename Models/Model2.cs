namespace lab4.Models
{
    public class Model2:BaseEntity.BaseEntity
    {
        public string Name { get; set; }
        public Model1 Model1 { get; set; }
        public Guid Model1Id { get; set; }
    }
}
