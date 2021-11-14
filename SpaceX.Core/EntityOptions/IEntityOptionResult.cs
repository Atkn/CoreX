using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX.Backoffice.Core.EntityOptions
{
    public interface IEntityOptionResult
    {
        Type EntityType(string tableName);

    }
}
