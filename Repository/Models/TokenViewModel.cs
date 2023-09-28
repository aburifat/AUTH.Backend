namespace AUTH.Backend.Repository.Models;

public class TokenViewModel
{
    public string AccessToken { get; set; }

    public string RefreshToken { get; set; }

    public string RememberMeToken { get; set; }

    public string ExpireAt { get; set; }
}
