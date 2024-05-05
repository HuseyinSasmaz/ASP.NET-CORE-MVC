using Microsoft.AspNetCore.Identity;

namespace GeziRehberim.Model
{
	public class ÜyeKimlikDogrulama : IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError
			{
				Code = nameof(PasswordTooShort),
				Description = $"Şifreniz en az {length} karakter uzunluğunda olmalıdır."
			};
		}

		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError
			{
				Code = nameof(PasswordRequiresUpper),
				Description = "Şifrede en az 1 büyük harf olmalıdır."
			};
		}

		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError
			{
				Code = nameof(PasswordRequiresLower),
				Description = "Şifrede en az 1 küçük harf olmalıdır."
			};
		}

		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError
			{
				Code = nameof(PasswordRequiresNonAlphanumeric),
				Description = "Şifre en az 1 sembol içermelidir."
			};
		}
	}
}
