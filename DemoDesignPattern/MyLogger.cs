using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDesignPattern
{
    public interface IMyLogger
    {
        public void Log(string message);
    }

    public sealed class MyLogger : IMyLogger
    {
        public MyLogger()
        {

        }

        void IMyLogger.Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
