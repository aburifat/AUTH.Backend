using AUTH.Backend.Repository.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AUTH.Backend.Repository.Models;

[Index(propertyNames: nameof(Email), Name = nameof(Email))]
public class User : IdentityUser<long>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public override string PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime JoinedAt { get; set; }
    public Gender? Gender { get; set; }
    public long? ProfilePictureId { get; set; }

    [ForeignKey(nameof(ProfilePictureId))]
    public virtual Document ProfilePicture { get; set; }
}


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
