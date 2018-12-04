namespace Entities.ViewModels.User
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Token { get; set; }
        public string Email { get; set; }
        public int AccountType { get; set; }
        public string Password { get; set; }
    }
}
