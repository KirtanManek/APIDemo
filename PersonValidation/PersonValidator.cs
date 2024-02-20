using APIDemo.Models;
using FluentValidation;

namespace APIDemo.PersonValidation
{
	public class PersonValidator : AbstractValidator<PersonModel>
	{
		public PersonValidator()
		{
			RuleFor(x => x.Name)
				.NotEmpty().WithMessage("Name is required.");
			RuleFor(x => x.Contact)
				.NotEmpty().Length(10).WithMessage("10 digit Contact is required.");
			RuleFor(x => x.Email)
				.NotEmpty().EmailAddress().WithMessage("Enter valid Email.");
		}
	}
}
