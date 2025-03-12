using Entities.User;
using Repositories.IUserService;

public class UserService : IUserService
{
    private readonly IUserService _userService;
    
    public UserService(IUserService userService)
    {
        _userService = userService;
    }

    public User CreateUser(User user)
    {
        throw new NotImplementedException();
    }

    public User DeleteUser(long id)
    {
        throw new NotImplementedException();
    }

    public User GetUser(long id)
    {
        throw new NotImplementedException();
    }

    public User UpdateUser(User user)
    {
        throw new NotImplementedException();
    }
}