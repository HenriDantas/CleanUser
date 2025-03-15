namespace Core.Entities.User;

public class User()
{
    public long Id { get; set; }
    public required string Name { get; set; }
    public required string Mail { get; set; }
    public required string Password { get; set; }
    
}
