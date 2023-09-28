using AUTH.Backend.Domains.Models;
using AUTH.Backend.Domains.Requests;
using AUTH.Backend.Domains.Responses;

namespace AUTH.Backend.Managers;

public interface IUserManager
{
    Task<TokenResponse> SignUp(SignUpRequest request);

    Task<TokenResponse> SignIn(SignInRequest request);

    Task<TokenResponse> SignInTokenRenew(SignInTokenRenewRequest request);

    Task<TokenResponse> SignInRememberMeTokenRenew(SignInRememberMeTokenRenewRequest request);

    Task<TokenResponse> CreateAccessToken(User User);



    Task<string> SendConfirmationCode(SendConfirmationCodeRequest request);

    Task<string> VerifyConfirmationCode(VerifyConfirmationCodeRequest request);

    Task<string> SendResetPasswordCode(SendResetPasswordCodeRequest request);

    Task<string> VerifyResetPasswordCode(VerifyResetPasswordCodeRequest request);



    Task<IEnumerable<GetUserRoleResponse>> GetUserRoles();



    Task<CreateUserResponse> CreateUser(CreateUserRequest request);

    Task<GetUserProfileResponse> GetUserProfile();

    Task<GetUserProfileResponse> GetUserProfileById(long id);

    Task<IList<GetUserProfileResponse>> GetUsers(GetUsersRequest request);



    Task<bool> ChangePassword(ChangePasswordRequest request);

    Task<bool> UpdateUserProfile(UpdateUserProfileRequest request);

    Task<bool> UpdateUserEmail(UpdateUserEmailRequest request);

    Task<bool> UpdateUserPhoneNumber(UpdateUserPhoneNumberRequest request);

    Task<bool> UpdateUserName(UpdateUserNameRequest request);

    Task<bool> UpdateUserRole(UpdateUserRoleRequest request);
}