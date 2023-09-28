namespace Todo.Domain.Commands
{
    public class UpdateCommand
    {
        public UpdateCommand() { }
        public UpdateCommand(Guid id, string title, string user)
        {
            Id = id;
            Title = title;
            User = user;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string User { get; set; }
    }
}