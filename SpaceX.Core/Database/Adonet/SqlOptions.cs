using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SpaceX.Backoffice.Core.Database.Adonet
{
    public class SqlOptions : ISqlOptions
    {
        public string defaultConnection;
        public SqlOptions(DatabaseConnector connector)
        {
            defaultConnection = connector != null ? connector.ConnectionString : new DatabaseConnector().DefaultConnection;
        }
        public (bool, SqlConnection connection, string message) CreateConnectionSql()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = defaultConnection;
                    connection.Open();
                    return (true,connection, "Bağlantı Başarılı");
                }
            }
            catch (Exception ex)
            {
                return (true, new SqlConnection(), "Bağlantı Başarısız Sebebi: " + ex.Message);
                
                
            }
            
            
        }
    }
}
