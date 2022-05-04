namespace Banking.Cqrs.Core.Messages
{
    public class Message
    {
        public string Id { get; set; } = string.Empty;

        public Message(string id)
        {
            Id = id;
        }
    }
}
