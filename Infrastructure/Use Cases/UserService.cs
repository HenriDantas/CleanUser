using System.Threading.Tasks;
using Adapters.IUseCase.IUserService;
using Core.Entities.User;
using Infrastructure.Db.AppDbContext;
using Microsoft.EntityFrameworkCore;

namespace Core.UseCases.UserService;

public class UserService : IUserService
{
    private readonly AppDbContext _context; 
    public UserService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<User> CreateUser(User user)
    {
        var newUser = await _context.User.AddAsync(user);

        if(newUser == null) throw new Exception("Error in creating user.");
        
        return newUser.Entity;
    }

    public async Task<User> DeleteUser(long id)
    {
        var dbUser = await GetUser(id);

        _context.User.Remove(dbUser);

        return dbUser;
    }

    public async Task<User> GetUser(long id)
    {
        var dbUser = await _context.User.Where(u => u.Id == id).FirstOrDefaultAsync();

        if(dbUser == null) throw new Exception("User not found.");

        return dbUser;
    }

    public async Task<User> UpdateUser(User user)
    {
        var dbUser = await GetUser(user.Id);  

        dbUser = user;

        _context.User.Update(dbUser);

        return dbUser;
    }
}
