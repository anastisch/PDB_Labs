using System.Threading;

namespace Lab2_Observable
{
    public class ChatMembership
    {
        public Chat Chat { get; }

        public User User { get; }

        public int ReceivedMessageDelay { get; }

        public ChatMembership(Chat chat, User user, int receivedMessageDelay)
        {
            Chat = chat;
            User = user;
            ReceivedMessageDelay = receivedMessageDelay;
        }

        public void Notify(ChatMessage message)
        {
            Thread.Sleep(ReceivedMessageDelay * 1000);
            User.ReceiveMessage(message);
        }
    }
}