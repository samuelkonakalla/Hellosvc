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
            ServiceHost host = new ServiceHost(typeof(ClassLibrary1.HelloSVC));
            
                host.Open();
                Console.WriteLine("HelloSVC service Host started at:" + DateTime.Now.ToShortTimeString());
                
            
            using (ServiceHost host1 = new ServiceHost(typeof(ClassLibrary1.HelloSVCpubPrivate)))
            {
                host1.Open();
                Console.WriteLine("HelloSVCpubPrivate service Host started at:" + DateTime.Now.ToShortTimeString());
                Console.ReadLine();
            }
        }

    }
}
