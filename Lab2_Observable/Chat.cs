using System.Collections.Generic;
using System.Threading;

namespace Lab2_Observable
{
    public class Chat
    {
        public string Name { get; }
        private List<ChatMembership> _members;
        private List<ChatMessage> _messages;

        public Chat(string name)
        {
            Name = name;
            _members = new List<ChatMembership>();
            _messages = new List<ChatMessage>();
        }

        public void AddMember(ChatMembership membership)
        {
            _members.Add(membership);
        }

        public void PublishMessage(ChatMessage message)
        {
            _messages.Add(message);
            foreach (var member in _members)
            {
                new Thread(() => member.Notify(message)).Start();
            }
        }
    }
}