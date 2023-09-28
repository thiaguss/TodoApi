using FluentValidation;

namespace Todo.Domain.Commands.Validations
{
    public class MarkAsUndoneCommandValidation : AbstractValidator<MarkAsUndoneCommand>
    {
        public MarkAsUndoneCommandValidation() 
        {
            RuleFor(command => command.Id)
            .NotEmpty();

            RuleFor(command => command.User)
            .NotEmpty()
            .MinimumLength(6);
           
        }
    }
}