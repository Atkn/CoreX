using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SpaceX.Backoffice.Core.Database.Adonet
{
    public interface ISqlOptions
    {
        (bool, SqlConnection connection, string message) CreateConnectionSql();
    }
}
