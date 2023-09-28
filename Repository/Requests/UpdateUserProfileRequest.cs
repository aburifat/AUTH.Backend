using AUTH.Backend.Repository.Enums;

namespace AUTH.Backend.Repository.Requests;

public class UpdateUserProfileRequest
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Username { get; set; }

    public Gender? Gender { get; set; }

    public string UserAddress { get; set; }
}
