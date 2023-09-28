using AUTH.Backend.Repository.Enums;

namespace AUTH.Backend.Repository.Requests;

public class CreateUserRequest
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public string Username { get; set; }

    public Gender? Gender { get; set; }

    public string Password { get; set; }

    public string ConfirmPassword { get; set; }

    public string UserAddress { get; set; }

    public long RoleId { get; set; }

}
