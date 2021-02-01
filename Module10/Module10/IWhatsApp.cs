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

    public interface IMessenger<in T>
    {
        void GetDeviceInfo(T device);
    }

    public class Phone { }
    public class IPhone : Phone { }
    public class Computer { }

    public class Viber<T> : IMessenger<T> where T : Phone,
new()
    {
        public T DeviceInfo()
        {
            T device = new T();
            Console.WriteLine(device);
            return new T();
        }
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
