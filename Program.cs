using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace StackoverServiceTestnet
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceHost selfHost = new ServiceHost(typeof(Service1));
            selfHost.Open();
            Console.WriteLine("Service Open");
            Console.ReadKey();
            selfHost.Close();
        }
    }
}
