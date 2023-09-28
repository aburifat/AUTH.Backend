using AUTH.Backend.Domains.Models;
using AUTH.Backend.Domains.Requests;
using AUTH.Backend.Domains.Responses;
using AUTH.Backend.Options;
using Microsoft.AspNetCore.Identity;

namespace AUTH.Backend.Managers
{
    public class UserManager : IUserManager
    {
        private readonly AppUserManager<User> _appUserManager;
        private readonly RoleManager<Role> _identityRoleManager;
        private readonly JwtAuthOptions _jwtAuthOptions;









        Task<bool> IUserManager.ChangePassword(ChangePasswordRequest request)
        {
            throw new NotImplementedException();
        }

        Task<TokenResponse> IUserManager.CreateAccessToken(User User)
        {
            throw new NotImplementedException();
        }

        Task<CreateUserResponse> IUserManager.CreateUser(CreateUserRequest request)
        {
            throw new NotImplementedException();
        }

        Task<GetUserProfileResponse> IUserManager.GetUserProfile()
        {
            throw new NotImplementedException();
        }

        Task<GetUserProfileResponse> IUserManager.GetUserProfileById(long id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<GetUserRoleResponse>> IUserManager.GetUserRoles()
        {
            throw new NotImplementedException();
        }

        Task<IList<GetUserProfileResponse>> IUserManager.GetUsers(GetUsersRequest request)
        {
            throw new NotImplementedException();
        }

        Task<string> IUserManager.SendConfirmationCode(SendConfirmationCodeRequest request)
        {
            throw new NotImplementedException();
        }

        Task<string> IUserManager.SendResetPasswordCode(SendResetPasswordCodeRequest request)
        {
            throw new NotImplementedException();
        }

        Task<TokenResponse> IUserManager.SignIn(SignInRequest request)
        {
            throw new NotImplementedException();
        }

        Task<TokenResponse> IUserManager.SignInRememberMeTokenRenew(SignInRememberMeTokenRenewRequest request)
        {
            throw new NotImplementedException();
        }

        Task<TokenResponse> IUserManager.SignInTokenRenew(SignInTokenRenewRequest request)
        {
            throw new NotImplementedException();
        }

        Task<TokenResponse> IUserManager.SignUp(SignUpRequest request)
        {
            throw new NotImplementedException();
        }

        Task<bool> IUserManager.UpdateUserEmail(UpdateUserEmailRequest request)
        {
            throw new NotImplementedException();
        }

        Task<bool> IUserManager.UpdateUserName(UpdateUserNameRequest request)
        {
            throw new NotImplementedException();
        }

        Task<bool> IUserManager.UpdateUserPhoneNumber(UpdateUserPhoneNumberRequest request)
        {
            throw new NotImplementedException();
        }

        Task<bool> IUserManager.UpdateUserProfile(UpdateUserProfileRequest request)
        {
            throw new NotImplementedException();
        }

        Task<bool> IUserManager.UpdateUserRole(UpdateUserRoleRequest request)
        {
            throw new NotImplementedException();
        }

        Task<string> IUserManager.VerifyConfirmationCode(VerifyConfirmationCodeRequest request)
        {
            throw new NotImplementedException();
        }

        Task<string> IUserManager.VerifyResetPasswordCode(VerifyResetPasswordCodeRequest request)
        {
            throw new NotImplementedException();
        }
    }
}