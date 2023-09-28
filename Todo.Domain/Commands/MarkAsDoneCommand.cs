namespace Todo.Domain.Commands
{
    public class MarkAsDoneCommand
    {
        public MarkAsDoneCommand(){}
        public MarkAsDoneCommand(Guid id, string user)
        {
            Id = id;
            User = user;
        }

        public Guid Id { get; set; }
        public string User { get; set; }
    }
}