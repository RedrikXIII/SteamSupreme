namespace DAL.Models
{
    public class SettingsModel
    {
        public Guid Id { get; set; }
        public bool Dark { get; set; }
        public UserModel User { get; set; }
        public Guid UserId { get; set; }
    }
}
