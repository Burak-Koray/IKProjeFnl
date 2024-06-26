using Microsoft.AspNetCore.Identity;

public class TurkishIdentityErrorDescriber : IdentityErrorDescriber
{
    public override IdentityError PasswordRequiresDigit()
    {
        return new IdentityError { Code = nameof(PasswordRequiresDigit), Description = "Şifrede en az bir rakam olmalıdır." };
    }

    public override IdentityError PasswordRequiresLower()
    {
        return new IdentityError { Code = nameof(PasswordRequiresLower), Description = "Şifrede en az bir küçük harf olmalıdır." };
    }

    public override IdentityError PasswordRequiresNonAlphanumeric()
    {
        return new IdentityError { Code = nameof(PasswordRequiresNonAlphanumeric), Description = "Şifrede en az bir özel karakter olmalıdır." };
    }

    public override IdentityError PasswordRequiresUpper()
    {
        return new IdentityError { Code = nameof(PasswordRequiresUpper), Description = "Şifrede en az bir büyük harf olmalıdır." };
    }

    public override IdentityError PasswordTooShort(int length)
    {
        return new IdentityError { Code = nameof(PasswordTooShort), Description = $"Şifre en az {length} karakter olmalıdır." };
    }

    public override IdentityError PasswordRequiresUniqueChars(int uniqueChars)
    {
        return new IdentityError { Code = nameof(PasswordRequiresUniqueChars), Description = $"Şifrede en az {uniqueChars} farklı karakter olmalıdır." };
    }
}
