namespace DAL.Models
{
    public class OrderModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public GameModel User { get; set; }
        public Guid GameId { get; set; }
        public GameModel Game { get; set; }
    }
}
