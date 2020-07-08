using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System.Runtime.Serialization;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CrmServiceClient crmServiceClient = Conectar();
            
            Entity contact=new Entity("contact");

            contact.Attributes.Add("lastname", "ConsoleApp");

            Guid guid= crmServiceClient.Create(contact);

            Console.WriteLine(guid);
            
            Console.ReadLine();

        }

        
        private static CrmServiceClient Conectar()
        {
            Configure configure = new Configure();

            string connectionString = configure.connectionString;

            CrmServiceClient crmServiceClient = new CrmServiceClient(connectionString);

            return crmServiceClient;
        }
    }
}
