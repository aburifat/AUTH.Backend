namespace AUTH.Backend.Domains.Responses;

public class TokenResponse
{
    public string AccessToken { get; set; }

    public string RefreshToken { get; set; }

    public string RememberMeToken { get; set; }

    public string ExpireAt { get; set; }
}