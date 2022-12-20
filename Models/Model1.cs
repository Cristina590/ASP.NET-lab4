namespace lab4.Models
{
    public class Model1: BaseEntity.BaseEntity
    {
        public string Name  { get; set; }

        public int Order { get; set; }

        public ICollection<Model2> Models2 { get; set; }
    }
}
