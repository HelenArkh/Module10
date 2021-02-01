using System;
using System.Collections.Generic;
using System.Text;

namespace Module10
{
    public interface IWriter
    {
        void Write();
    }

    public interface IReader
    {
        void Read();
    }

    public interface IMailer
    {
        void SendEmail();
    }

    public class FileManager : IWriter, IReader, IMailer
    {
        public void Read()
        {
            throw new NotImplementedException();
        }

        public void SendEmail()
        {
            throw new NotImplementedException();
        }

        public void Write()
        {
            throw new NotImplementedException();
        }
    }

    public class Writer : IWriter
    {
        void IWriter.Write()
        {
            throw new NotImplementedException();
        }
    }
}
