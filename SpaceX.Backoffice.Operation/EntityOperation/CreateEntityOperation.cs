using SpaceX.Backoffice.Core.Database.Adonet;
using SpaceX.Backoffice.Core.EntityOptions;
using SpaceX.Backoffice.Distributor.DatabaseStringBuilder;
using SpaceX.Backoffice.Distributor.Object;
using SpaceX.Core.concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SpaceX.Backoffice.Operation.EntityOperation
{
    public class CreateEntityOperation
    {
        private readonly ISqlOptions _sqlOptions;
        public CreateEntityOperation(ISqlOptions sqlOptions)
        {
            _sqlOptions = sqlOptions;
        }

        public ModelWrapper CreateTableGenerateMethod(Entity entity)
        {
            //var result = _sqlOptions.CreateConnectionSql();
            if (true)
            {
                using SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=SpaceX;Trusted_Connection=True;");
                connection.Open();
                using SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = DatabaseStringBuilder.TransactionStringTableCreate(entity);
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Close();
                Console.WriteLine($"{entity.EntityName} başarıyla oluştu");
                return new ModelWrapper
                {
                    IsSuccessFull = true,
                };


            }

        }


    }
}
