using AUTH.Backend.Domains.Enums;

namespace AUTH.Backend.Domains.Requests;

public class CreateUserRequest
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public string UserName { get; set; }

    public Gender? Gender { get; set; }

    public string Password { get; set; }

    public string ConfirmPassword { get; set; }

    public string UserAddress { get; set; }

    public long RoleId { get; set; }

}