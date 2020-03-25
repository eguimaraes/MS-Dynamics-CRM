using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectionClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Conexao conexao = new Conexao(lerEntradaCmd("Digite o usuário"), lerEntradaCmd("Digite a senha"),"https://disco.crm2.dynamics.com/XRMServices/2011/Discovery.svc");


        }

        private static string lerEntradaCmd(string msg)
        {
            Console.Write(msg + ": ");
            return Console.ReadLine();
        }
    }
}
