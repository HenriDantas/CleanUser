using System.Threading.Tasks;
using Adapters.IUseCase.IUserService;
using Core.Entities.User;
using Microsoft.AspNetCore.Mvc;


namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _service;
    public UserController(IUserService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetUser(long id)
    {
        try
        {
            return Ok(await _service.GetUser(id));
            
        }catch(Exception e){
            throw new Exception(e.Message);
        }
    }

    [HttpPost] 
    public async Task<IActionResult> PostUser(User user)
    {
        try
        {
            return Ok(await _service.CreateUser(user));

        }catch(Exception e){
            throw new Exception(e.Message);
        }
    }

    [HttpPut]
    public async Task<IActionResult> UpdateUser(User user)
    {
        try
        {
            return Ok(await _service.UpdateUser(user));

        }catch(Exception e){
            throw new Exception(e.Message);
        }
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteUser(long id)
    {
        try
        {
            return Ok(await _service.DeleteUser(id));

        }catch(Exception e){
            throw new Exception(e.Message);
        }
    }

}
