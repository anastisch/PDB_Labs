namespace Lab2_Observable
{
    public class ChatMessage
    {
        public string Content { get; }
        
        public ChatMembership Sender { get; }

        public ChatMessage(string content, ChatMembership sender)
        {
            Content = content;
            Sender = sender;
        }
    }
}