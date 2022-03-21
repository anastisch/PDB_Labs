using System;
using System.Collections.Generic;

namespace Lab2_Observable
{
    public class User
    {
        public string Name { get; }

        private List<ChatMembership> _subscribtions;

        public User(string name)
        {
            Name = name;
            _subscribtions = new List<ChatMembership>();
        }

        public void JoinToChat(Chat chat, int delay)
        {
            ChatMembership membership = new ChatMembership(chat, this, delay);
            chat.AddMember(membership);
            _subscribtions.Add(membership);
        }

        public void SendMessage(string content, Chat chat)
        {
            ChatMembership chatMembership = _subscribtions.Find(subscription => subscription.Chat.Equals(chat));
            ChatMessage message = new ChatMessage(content, chatMembership);
            chat.PublishMessage(message);
        }

        public virtual void ReceiveMessage(ChatMessage message)
        {
            string dateTimeString = DateTime.Now.ToString();
            Console.WriteLine(dateTimeString + " User " + Name +
                              " received message from user " + message.Sender.User.Name +
                              " in chat " + message.Sender.Chat.Name +
                              ". Message content: " + message.Content);
        }
    }
}