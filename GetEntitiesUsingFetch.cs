using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using System.Runtime.Serialization;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CrmServiceClient crmServiceClient = Conectar();           
           

            FetchExpression fetchExpression = new FetchExpression();

            XmlDocument xml = new XmlDocument();

            StreamReader reader = new StreamReader("FetchXML.xml");

            fetchExpression.Query = reader.ReadToEnd();

            EntityCollection collection= crmServiceClient.RetrieveMultiple(fetchExpression);

            foreach (Entity entity in collection.Entities)
            {

                Console.WriteLine($"Nome do contato {entity.Attributes["fullname"].ToString()}");


            }

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
