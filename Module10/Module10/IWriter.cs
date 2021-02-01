using System;
using System.Collections.Generic;
using System.Text;

namespace Module10
{
    public interface IWriter
    {
        void Write() { Console.WriteLine("Hello, I'm Writer!"); }
    }

    public class Writer : IWriter
    {

    }
}
