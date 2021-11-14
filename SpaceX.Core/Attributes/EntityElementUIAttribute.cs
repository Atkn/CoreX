using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX.Backoffice.Core.Attributes
{
    public class EntityElementUIAttribute : Attribute
    {
        public UIElementType ElementType;
        public int FormOrder;
        public int TableOrder;
        public EntityElementUIAttribute(UIElementType UIElementType, int formOrder, int tableOrder)
        {
            ElementType = UIElementType;
            FormOrder = formOrder;
            TableOrder = tableOrder;
        }
    }
}
