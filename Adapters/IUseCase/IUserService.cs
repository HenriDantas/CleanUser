using Core.Entities.User;

namespace Adapters.IUseCase.IUserService;

public interface IUserService
{
    Task<User> CreateUser(User user);
    Task<User> UpdateUser(User user);
    Task<User> DeleteUser(long id);
    Task<User> GetUser(long id);
}