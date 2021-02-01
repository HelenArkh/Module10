using System;

namespace Module10
{
    class Program
    {
        static void Main(string[] args)
        {
            NewMessenger newMessenger = new NewMessenger();

            ((IWhatsApp)newMessenger).SendMessage("Hello World!");
            ((IViber)newMessenger).SendMessage("Hello World!");
        }
    }
}
