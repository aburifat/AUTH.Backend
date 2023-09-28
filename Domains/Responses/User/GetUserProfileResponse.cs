using AUTH.Backend.Domains.Enums;

namespace AUTH.Backend.Domains.Responses;

public class GetUserProfileResponse
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public string Username { get; set; }

    public Gender? Gender { get; set; }

    public string UserAddress { get; set; }

    public long RoleId { get; set; }
}