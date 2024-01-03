namespace API.Domain.Models
{
    public class UserModel : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public ProfileModel Profile { get; set; }
    }
}
