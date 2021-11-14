using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceX.Backoffice.Core.EntityOptions
{
    public class EntityOptionResult : IEntityOptionResult
    {
        private string nameSpace => "SpaceX.Backoffice.Core.Entities";
        public Type EntityType(string tableName)
        {
            var result = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => x.IsClass && x.Namespace == nameSpace && x.Name == tableName)
                .FirstOrDefault();
            if(result != null)
            {
                return result;
            }
            return null;
        }
    }
}
