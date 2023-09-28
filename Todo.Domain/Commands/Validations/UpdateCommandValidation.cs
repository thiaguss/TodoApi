using FluentValidation;

namespace Todo.Domain.Commands.Validations
{
    public class UpdateCommandValidation : AbstractValidator<UpdateCommand>
    {
        public UpdateCommandValidation() 
        {
            RuleFor(command => command.Id)
            .NotEmpty();

            RuleFor(command => command.User)
            .NotEmpty()
            .MinimumLength(6);

            RuleFor(command => command.Title)
            .NotEmpty()
            .MinimumLength(3);
           
        }
    }
}