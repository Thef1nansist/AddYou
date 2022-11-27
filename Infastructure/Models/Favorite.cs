namespace Infastructure.Models
{
    public class Favorite
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
