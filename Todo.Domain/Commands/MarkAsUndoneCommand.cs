namespace Todo.Domain.Commands
{
    public class MarkAsUndoneCommand
    {
        public MarkAsUndoneCommand(){}
        public MarkAsUndoneCommand(Guid id, string user)
        {
            Id = id;
            User = user;
        }

        public Guid Id { get; set; }
        public string User { get; set; }
    }
}