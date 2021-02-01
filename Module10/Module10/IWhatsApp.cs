using System;
using System.Collections.Generic;
using System.Text;

namespace Module10
{
    public interface IWhatsApp
    {
        public void SendMessage(string message);
    }

    public interface IViber
    {
        public void SendMessage(string message);
    }

    public class NewMessenger : IWhatsApp,
IViber
    {
        public void SendMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}
