﻿namespace AUTH.Backend.Repository.Requests;

public class VerifyResetPasswordCodeRequest
{
    public string Email { get; set; }

    public string Code { get; set; }

    public string NewPassword { get; set; }

    public string ConfirmNewPassword { get; set; }
}
