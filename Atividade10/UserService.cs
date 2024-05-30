namespace Atividade10
{
    internal class UserService : IUserService
    {
        public User GetUserInfo(int userId)
        {
            return new User("name", "email");
        }
    }
}
