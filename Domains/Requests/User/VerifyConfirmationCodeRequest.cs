namespace AUTH.Backend.Domains.Requests;

public class VerifyConfirmationCodeRequest
{
    public string Email { get; set; }

    public string Code { get; set; }
}