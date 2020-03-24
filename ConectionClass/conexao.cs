using System;
using System.Net;
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


namespace ConectionClass
{
    class Conexao
    {
        public Uri uri;
        public ClientCredentials clientCredentials;
        public OrganizationServiceProxy serviceProxy;

        public Conexao(string u, string p,string uriStr)
        {
            clientCredentials.UserName.UserName = u;
            clientCredentials.UserName.Password = p;
            uri = new Uri(uriStr);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            serviceProxy = new OrganizationServiceProxy(uri, null, clientCredentials, null);
            serviceProxy.EnableProxyTypes();
        }


    }
}