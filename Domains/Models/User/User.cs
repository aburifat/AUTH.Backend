using AUTH.Backend.Domains.Enums;
using Microsoft.AspNetCore.Identity;

namespace AUTH.Backend.Domains.Models;

public class User : IdentityUser<long>
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public override string? UserName { get; set; }

    public override string? PhoneNumber { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public Gender? Gender { get; set; }

    public string? UserAddress { get; set; }

}