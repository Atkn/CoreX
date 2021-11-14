using SpaceX.Backoffice.Core.Attributes;
using SpaceX.Backoffice.Core.EntityOptions;
using SpaceX.Backoffice.Distributor.EntityBuilder.Abstraction;
using SpaceX.Backoffice.Distributor.Object.EntityDatatable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceX.Backoffice.Distributor.EntityBuilder.Concrete
{
    public class EntityScreenBuilder : IEntityScreenBuilder
    {
        private readonly IEntityOptionResult _entityOptionResult;
        private EntityDatatable _tables;

        public EntityScreenBuilder(IEntityOptionResult entityOptionResult) { _tables = new EntityDatatable(); _entityOptionResult = entityOptionResult; }

        public EntityDatatable EntityScreenBuild(string entityName)
        {
            var entityDatatable = new EntityDatatable();
            var entity = _entityOptionResult.EntityType(entityName);
            if(entity != null)
            {
                var attributes = entity.GetCustomAttributes(typeof(EntityBehaviorAttribute), true).FirstOrDefault() as EntityBehaviorAttribute;
                var properties = entity.GetProperties();
                var columns = new List<DatatableItem>();
                var operation = new List<EntityOperationItem>();
                foreach (var property in properties)
                {
                    var column = new DatatableItem
                    {
                        ColumnName = property.Name
                    };
                    columns.Add(column);
                    object[] propAttributes = property.GetCustomAttributes(true);
                    foreach (var attribute in propAttributes)
                    {
                        EntityElementUIAttribute propertyAttrbiute = attribute as EntityElementUIAttribute;
                        if (propertyAttrbiute != null)
                        {
                            var entityOperationItem = new EntityOperationItem
                            {
                                Element = propertyAttrbiute.ElementType,
                                FormOrder = propertyAttrbiute.FormOrder,
                                TableOrder = propertyAttrbiute.TableOrder
                            };
                            operation.Add(entityOperationItem);
                        }
                    }
                }

                if (!attributes.IsReadOnly)
                {
                    entityDatatable.AjaxRequets = string.Concat(entity.Name, "DataList");
                    entityDatatable.IsCreate = attributes.IsCreate;
                    entityDatatable.IsUpdate = attributes.IsUpdate;
                    entityDatatable.TableName = entity.Name;
                    entityDatatable.IsReadOnly = attributes.IsReadOnly;
                }
                entityDatatable.DatatableItems = columns;
                entityDatatable.OperationItems = operation;
                entityDatatable.ColumnCount = properties.Count();
                return entityDatatable;
            }
            return null;
            
        }
    }
}
