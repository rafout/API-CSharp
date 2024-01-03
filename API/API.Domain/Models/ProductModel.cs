namespace API.Domain.Models
{
    public class ProductModel : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
    }
}
