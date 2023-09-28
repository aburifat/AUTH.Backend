using AUTH.Backend.Domains.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AUTH.Backend.Managers;

public class AppUserManager<TUser> : UserManager<TUser>
    where TUser : User
{
    public AppUserManager(IUserStore<TUser> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<TUser> passwordHasher, IEnumerable<IUserValidator<TUser>> userValidators, IEnumerable<IPasswordValidator<TUser>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<TUser>> logger) : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
    {
    }

    public async Task<TUser> FindByUserNameAsync(string userName)
    {
        return await Users.FirstOrDefaultAsync(_ => _.UserName == userName);
    }

    public async Task<TUser> FindByIdAsync(long userId)
    {
        return await Users.FirstOrDefaultAsync(_ => _.Id == userId);
    }
}