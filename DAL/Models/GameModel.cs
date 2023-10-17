namespace DAL.Models
{
    public class GameModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public CompanyModel Company { get; set; }
        public Guid CompanyId { get; set; }
        public List<OrderModel> GameOrders { get; set; }
    }
}
