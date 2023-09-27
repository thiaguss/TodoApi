using FluentValidation;

namespace Todo.Domain.Commands.Validations
{
    public class CreateTodoValidation : AbstractValidator<CreateTodoCommand>
    {
        public CreateTodoValidation() 
        {
            RuleFor(command => command.Title)
            .NotEmpty()
            .WithMessage("The title must be filled in")
            .MaximumLength(50)
            .WithMessage("The title must contain a maximum of 300 characters");

             RuleFor(command => command.User)
            .NotEmpty()
            .WithMessage("The user must be filled in")
            .MaximumLength(15)
            .WithMessage("The user must contain a maximum of 50 characters");

             RuleFor(command => command.Date)
             .NotEmpty()
             .WithMessage("The date must be filled in")
             .GreaterThan(DateTime.MinValue);
           
        }
    }
}