using SpaceX.Backoffice.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX.Backoffice.Core.Entities
{
    [EntityBehavior(tableName: "Moduler", isReadOnly: false,  isCreate: true, isUpdate: false)]
    public class Moduler : BaseEntity
    {

    }
}
