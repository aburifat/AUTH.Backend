namespace AUTH.Backend.Domains.Requests;

public class SignInTokenRenewRequest
{
    public string AccessToken { get; set; }

    public string RefreshToken { get; set; }

    public string RememberMeToken { get; set; }
}