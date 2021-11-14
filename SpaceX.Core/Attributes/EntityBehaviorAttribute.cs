using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX.Backoffice.Core.Attributes
{
    public class EntityBehaviorAttribute : Attribute
    {
        public string TableName;
        public bool IsReadOnly;
        public bool IsUpdate;
        public bool IsCreate;
        public EntityBehaviorAttribute(string tableName, bool isReadOnly, bool isUpdate,bool isCreate)
        {
            TableName = tableName;
            IsReadOnly = isReadOnly;
            IsUpdate = isUpdate;
            IsCreate = isCreate;
        }

    }
}
