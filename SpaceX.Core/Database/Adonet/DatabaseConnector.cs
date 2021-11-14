using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX.Backoffice.Core.Database.Adonet
{
    public class DatabaseConnector
    {
        public string UserName { get; set; }
        public string Catalog { get; set; }

        public string ServerName { get; set; }

        public string ConnectionString 
        { 
            get 
            {
                if (Catalog == null)
                    return DefaultConnection;
                else
                {
                    return "";
                }
            } 
        }

        public string DefaultConnection
        {
            get
            {
                return "Server=(localdb)\\MSSQLLocalDB;Database=SpaceX;Trusted_Connection=True;";
            }
            set
            {
                
            }
        }

    }
}
