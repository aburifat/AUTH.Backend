using AUTH.Backend.Domains.Enums;

namespace AUTH.Backend.Domains.Requests;

public class GetUsersRequest
{
    public string SearchQuery { get; set; }

    public long? RoleId { get; set; }

    public Gender? Gender { get; set; }
}