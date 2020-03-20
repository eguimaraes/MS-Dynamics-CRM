using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Description;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;

namespace ServicoDescoberta
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri local = new Uri("https://disco.crm2.dynamics.com/XRMServices/2011/Discovery.svc");

            ClientCredentials clientcred = new ClientCredentials();
            clientcred.UserName.UserName = lerEntradaCmd("Digite o Usuário");     
            clientcred.UserName.Password = lerEntradaCmd("Digite a Senha");

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            DiscoveryServiceProxy dsp = new DiscoveryServiceProxy(local, null, clientcred, null);
            dsp.Authenticate();

            RetrieveOrganizationsRequest rosreq = new RetrieveOrganizationsRequest();
            rosreq.AccessType = EndpointAccessType.Default;
            rosreq.Release = OrganizationRelease.Current;

            RetrieveOrganizationsResponse r = (RetrieveOrganizationsResponse)dsp.Execute(rosreq);

            foreach (var item in r.Details)
            {
                Console.WriteLine("Nome " + item.UniqueName);
                Console.WriteLine("Nome Exibição " + item.FriendlyName);
                foreach (var endpoint in item.Endpoints)
                {
                    Console.WriteLine(endpoint.Key);
                    Console.WriteLine(endpoint.Value);
                }
            }

            Console.ReadLine();
        }

        private static string lerEntradaCmd(string msg)
        {
            Console.Write(msg+": ");
            return Console.ReadLine();
        }
    }
}
