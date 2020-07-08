using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Configure
    {
        public string name = "CrMServer";
        public string AuthType = "Office365";
        public string Url = @"https://name.crm2.dynamics.com/";
        public string Domain = "";
        public string Username = "user@nnn.onmicrosoft.com";
        public string Password = "passWord";
        public string connectionString = "";


        void setConnectionString() {

            this.connectionString= $"AuthType = {AuthType};Url = {Url};Username = {Username};Password= {Password}";
        
        
        }


        public Configure() { setConnectionString(); }
        
        }


    }

