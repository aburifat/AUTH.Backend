namespace AUTH.Backend.Repository.Requests;

public class VerifyConfirmationCodeRequest
{
    public string Email { get; set; }

    public string Code { get; set; }
}
