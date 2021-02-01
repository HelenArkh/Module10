using System;
using System.Collections.Generic;
using System.Text;

namespace Module10
{
    public interface IWriter
    {
        void Write();
    }

    public class Writer : IWriter
    {
        void IWriter.Write()
        {
            throw new NotImplementedException();
        }
    }
}
