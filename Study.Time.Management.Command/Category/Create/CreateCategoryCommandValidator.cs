using FluentValidation;

namespace Study.Time.Management.Commands.Category.Create
{
    public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
    {
        public CreateCategoryCommandValidator()
        {
            RuleFor(c => c.Title).NotNull().NotEmpty();
        }
    }
}
