using SpaceX.Backoffice.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX.Backoffice.Distributor.Object.EntityDatatable
{
    public class EntityOperationItem
    {
        public int FormOrder { get; set; }

        public int TableOrder { get; set; }

        public UIElementType Element { get; set; }
    }
}
