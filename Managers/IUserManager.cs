using AUTH.Backend.Repository.Models;
using AUTH.Backend.Repository.Requests;
using AUTH.Backend.Repository.Responses;

namespace AUTH.Backend.Managers;

public interface IUserManager
{
    Task<TokenViewModel> SignUp(SignUpRequest request);

    Task<TokenViewModel> SignIn(SignInRequest request);

    Task<TokenViewModel> SignInTokenRenew(SignInTokenRenewRequest  request);

    Task<TokenViewModel> SignInRememberMeTokenRenew(SignInRememberMeTokenRenewRequest request);

    Task<TokenViewModel> CreateAccessToken(User User);

    Task<string> SendConfirmationCode(SendConfirmationCodeRequest request);

    Task<string> VerifyConfirmationCode(VerifyConfirmationCodeRequest request);

    Task<string> SendResetPasswordCode(SendResetPasswordCodeRequest request);

    Task<string> VerifyResetPasswordCode(VerifyResetPasswordCodeRequest request);

    Task<string> ChangePassword(ChangePasswordRequest request);

    Task<IEnumerable<GetUserRoleResponse>> GetUserRoles();

    Task<CreateUserResponse> CreateUser(CreateUserRequest request);

    Task<GetUserProfileResponse> GetUserProfile();

    Task<GetUserProfileResponse> GetUserProfileById(long id);

    Task<IList<GetUserProfileResponse>> GetUsers(GetUsersRequest request);

    Task<bool> UpdateUserProfile(UpdateUserProfileRequest request);

    Task<bool> UpdateUserEmail(UpdateUserEmailRequest request);

    Task<bool> UpdateUserPhoneNumber(UpdateUserPhoneNumberRequest request);

    Task<bool> UpdateUserRole(UpdateUserRoleRequest request);
}
