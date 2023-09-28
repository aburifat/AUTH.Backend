using AUTH.Backend.Repository.Enums;

namespace AUTH.Backend.Repository.Requests;

public class GetUsersRequest
{
    public string SearchQuery { get; set; }
    public long? RoleId { get; set; }
    public Gender? Gender { get; set; }
}
