using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(ClassLibrary1.HelloSVC)))
            {
                host.Open();
                Console.WriteLine("Host started at:"+DateTime.Now.ToShortTimeString());
                Console.ReadLine();
            }
        }

    }
}
