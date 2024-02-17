﻿using Microsoft.AspNetCore.Identity;

namespace TraversalCoreProject.Models
{
	public class CustomIdentityValidator : IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = "PasswordTooShort",
				Description = $"Parola minimum {length} karakter olmalıdır."
			};
		}

		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresLower",
				Description = $"Parola en az 1 küçük harf içermelidir ('a'-'z')."
			};
		}

		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresUpper",
				Description = $"Parola en az 1 büyük harf içermelidir ('A'-'Z')."
			};
		}

		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresNonAlphanumeric",
				Description = $"Parola en az 1 sembol içermelidir ('!'-'#')."
			};
		}
	}
}
