namespace Infastructure.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public int SoldCounter { get; set; }
    }
}
