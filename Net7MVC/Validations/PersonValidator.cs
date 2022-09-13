
using FluentValidation;
using Net7MVC.Models;

namespace Net7MVC.Validations
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Gir laaa isim");
            RuleFor(x => x.Age).InclusiveBetween(18, 60);
        }
    }
}
