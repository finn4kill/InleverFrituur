using InleverFrituur.Model;

namespace InleverFrituur.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer? Customer { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
    }
}
