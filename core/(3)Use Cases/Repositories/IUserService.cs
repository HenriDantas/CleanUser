using Entities.User;


namespace Repositories.IUserService;
public interface IUserService
{
    User CreateUser(User user);
    User GetUser(long id);
    User UpdateUser(User user);
    User DeleteUser(long id);
}
