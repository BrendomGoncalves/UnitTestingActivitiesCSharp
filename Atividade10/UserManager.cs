namespace Atividade10
{
    public class UserManager
    {
        private readonly IUserService _userService;

        public UserManager(IUserService userService)
        {
            _userService = userService;
        }

        public User FetchUserInfo(int userId)
        {
            return _userService.GetUserInfo(userId);
        }
    }
}
