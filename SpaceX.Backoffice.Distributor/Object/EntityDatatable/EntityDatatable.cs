using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX.Backoffice.Distributor.Object.EntityDatatable
{
    public class EntityDatatable
    {
        
        public string AjaxRequets { get; set; }

        public int ColumnCount { get; set; }

        public string TableName { get; set; }
        public bool IsReadOnly { get; set; }
        public bool IsUpdate { get; set; }
        public bool IsCreate { get; set; }
        public List<DatatableItem> DatatableItems { get; set; }
        public List<EntityOperationItem> OperationItems { get; set; }
        public EntityDatatable()
        {
            DatatableItems = new List<DatatableItem>();
            OperationItems = new List<EntityOperationItem>();
        }
    }
}
