using System;

namespace ConsoleLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            var msg = new Message<int>(1, "the type is a number");
            msg.ShowMessage();
            Console.ReadLine();
            var msg2 = new Message<string>("a string", "the type is a string");
            msg2.ShowMessage();
            Console.ReadLine();
            */

            var LinqTest = new LinqGroupBy();
            LinqTest.main();
            Console.ReadLine();

        }
    }

    public class Message<T>
    {

        private readonly T _messageType;
        public string _theMessage;

        public Message(T messageType, string theMessage)
        {
            _messageType = messageType;
            _theMessage = theMessage;
        }

        public void ShowMessage()
        {
            Console.WriteLine($"Message Type: {_messageType} and the message is: {_theMessage}");
        }
    }
}
