using Security.Models;

namespace Security.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, Username = "admin", Password = "xpto%123", Role = "manager" });
            users.Add(new User { Id = 2, Username = "adriana", Password = "115500", Role = "provider" });
            users.Add(new User { Id = 2, Username = "joao", Password = "996633", Role = "associate" });

            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == password).FirstOrDefault();
        }
    }
}