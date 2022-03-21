using System.Collections.Generic;
using System.Threading;
using Lab2_Observable;
using NUnit.Framework;

namespace Lab3Observable_Tests
{
    public class ChatMessagingTest
    {
        [Test]
        public void Test1()
        {
            Chat chat = new Chat("Chat1");
            
            MockUser firstUser = new MockUser("Lucas");
            firstUser.JoinToChat(chat, 1);
            
            MockUser secondUser = new MockUser("Roma");
            secondUser.JoinToChat(chat, 2);
            
            MockUser thirdUser = new MockUser("Anna");
            thirdUser.JoinToChat(chat, 3);
            
            firstUser.SendMessage("Hello everyone!", chat);
            
            Thread.Sleep(4000);
            
            Assert.AreEqual(1, secondUser.ReceivedMessages.Count);
            Assert.AreEqual("Hello everyone!", secondUser.ReceivedMessages[0].Content);
            Assert.AreEqual(firstUser, secondUser.ReceivedMessages[0].Sender.User);
        }

        private class MockUser : User
        {
            public List<ChatMessage> ReceivedMessages { get; }

            public MockUser(string name) : base(name)
            {
                ReceivedMessages = new List<ChatMessage>();
            }

            public override void ReceiveMessage(ChatMessage message)
            {
                ReceivedMessages.Add(message);
            }
        }
    }
}