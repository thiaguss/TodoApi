using FluentValidation;

namespace Todo.Domain.Commands.Validations
{
    public class MarkAsDoneCommandValidation : AbstractValidator<MarkAsDoneCommand>
    {
        public MarkAsDoneCommandValidation() 
        {
            RuleFor(command => command.Id)
            .NotEmpty();

            RuleFor(command => command.User)
            .NotEmpty()
            .MinimumLength(6);
           
        }
    }
}