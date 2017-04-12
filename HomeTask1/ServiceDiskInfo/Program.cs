using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDiskInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Host";

            Uri address = new Uri("http://localhost:4000/IDiskInfo");//Adress (A)
            BasicHttpBinding binding = new BasicHttpBinding();//Binding (B)
            Type contract = typeof(IDiskInfo);//Contract (C)

            //create Host
            ServiceHost host = new ServiceHost(typeof(Service));
            //create Endpoint
            host.AddServiceEndpoint(contract, binding, address);

            host.Open();
            Console.WriteLine("Host works");
            Console.ReadKey();
            Console.WriteLine("Host will close");
        }      
    }
}
