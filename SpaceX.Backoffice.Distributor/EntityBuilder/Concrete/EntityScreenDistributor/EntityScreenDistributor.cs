using SpaceX.Backoffice.Distributor.EntityBuilder.Abstraction;
using SpaceX.Backoffice.Distributor.Object.EntityDatatable;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX.Backoffice.Distributor.EntityBuilder.Concrete.EntityScreenDistributor
{
    public class EntityScreenDistributor
    {
        private IEntityScreenBuilder _entityBuilder;
        public IEntityScreenBuilder EntityBuilder
        {
            set
            {
                _entityBuilder = value;
            }
        }

        public EntityDatatable EntityScreenBuild(string entityName)
        {
            return this._entityBuilder.EntityScreenBuild(entityName);
        }
    }
}
