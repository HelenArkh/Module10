using System;

namespace Module10
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessenger<Phone> viberInPhone = new Viber<Phone>();
            viberInPhone.GetDeviceInfo(new Phone());

            IMessenger<IPhone> viberInIphone = new Viber<IPhone>();
            viberInIphone.GetDeviceInfo(new IPhone());
        }
    }
}
