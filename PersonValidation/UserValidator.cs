using APIDemo.Models;
using FluentValidation;

namespace APIDemo.PersonValidation
{
	public class UserValidator : AbstractValidator<Users>
	{
		public UserValidator()
		{
			//RuleFor(x => x.UserName)
			//	.NotEmpty().Length(16).WithMessage("UserName is required.");
			//RuleFor(x => x.Password)
			//	.NotEmpty().WithMessage("Your password cannot be empty")
			//	.MinimumLength(8).WithMessage("Your password length must be at least 8.")
			//	.MaximumLength(16).WithMessage("Your password length must not exceed 16.")
			//	.Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.")
			//	.Matches(@"[a-z]+").WithMessage("Your password must contain at least one lowercase letter.")
			//	.Matches(@"[0-9]+").WithMessage("Your password must contain at least one number.")
			//	.Matches(@"[\!\?\*\.]+").WithMessage("Your password must contain at least one (!? *.).");
			//RuleFor(x => x.ConfirmPassword)
			//	.NotEmpty().WithMessage("ConfirmPassword is required.")
			//	.Equal(x => x.Password).WithMessage("Password does not match.");
			//RuleFor(x => x.Email)
			//	.NotEmpty().EmailAddress().WithMessage("Enter valid Email.");
			//RuleFor(x => x.Contact)
			//	.NotEmpty().WithMessage("10 digit Contact is required.")
			//	.InclusiveBetween(5999999999, 9999999999).WithMessage("Contact number out of range.")
			//	.ExclusiveBetween(0, 5999999998)
			//	.LessThanOrEqualTo(9999999999)
			//	.GreaterThan(5999999998);
		}
	}
}
