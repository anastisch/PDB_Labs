using System;

namespace Lab2_Observable
{
    class Program
    {
        static void Main(string[] args)
        {
            Chat chat = new Chat("Friends");
            
            User lucas = new User("Lucas");
            lucas.JoinToChat(chat, 2);
            
            User michael = new User("Michael");
            michael.JoinToChat(chat, 5);
            
            User john = new User("John");
            john.JoinToChat(chat, 3);
            
            john.SendMessage("Hi there!", chat);
        }
    }
}