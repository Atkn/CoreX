using SpaceX.Core.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceX.Backoffice.Distributor.DatabaseStringBuilder
{
    public class DatabaseStringBuilder
    {
        public static string TransactionStringTableCreate(Entity entity)
        {
            var baseCreateTableTransaction = $"Create Table {entity.EntityName} (";
            StringBuilder builder = new StringBuilder();
            var counter = 0;
            builder.Append(baseCreateTableTransaction);
            string fieldString = "";
            foreach (var field in entity.Fields)
            {
                counter++;
                
                if (counter != entity.Fields.Count())
                    fieldString = string.Concat(field.Key, " ", field.Value, ",");
                else
                    fieldString = string.Concat(field.Key, " ", field.Value);
                builder.Append(fieldString);
            }
            builder.Append(")");
            return builder.ToString();
        }

        public static string TransactionStringTableUpdate()
        {
            return "";
        }

        public static string TransactionStringTableDelete()
        {
            return "";
        }
    }
}
