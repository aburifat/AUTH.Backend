namespace AUTH.Backend.Repository.Requests;

public class SignInRequest
{
    public string Email { get; set; }

    public string Password { get; set; }

    public bool RememberMe { get; set; }
}
