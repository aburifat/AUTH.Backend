using AUTH.Backend.Domains.Enums;

namespace AUTH.Backend.Domains.Requests;

public class UpdateUserProfileRequest
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string UserName { get; set; }

    public Gender? Gender { get; set; }

    public string UserAddress { get; set; }
}