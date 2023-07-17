using FluentValidation;
using FluentValidationApp.Web.Models;

namespace FluentValidationApp.Web.FluentValidator
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name alanı boş geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Email alanı boş geçilemez").EmailAddress().WithMessage("Email alanı doğru formatta olmalıdır");

            RuleFor(x => x.Age).NotEmpty().WithMessage("Yaş alanı boş geçilemez").InclusiveBetween(18, 60).WithMessage
                ("Age alanı 18 ile 60 arasında olmalıdır.");

        }
    }
}
