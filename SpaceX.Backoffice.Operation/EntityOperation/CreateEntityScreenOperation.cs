using SpaceX.Backoffice.Core.EntityOptions;
using SpaceX.Backoffice.Distributor.EntityBuilder.Concrete;
using SpaceX.Backoffice.Distributor.EntityBuilder.Concrete.EntityScreenDistributor;
using SpaceX.Backoffice.Distributor.Object.EntityDatatable;
using SpaceX.Backoffice.Operation.EntityOperation.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX.Backoffice.Operation.EntityOperation
{
    public class CreateEntityScreenOperation : ICreateEntityScreenOperation
    {

        public EntityDatatable CreateScreen()
        {
            var entityBuild = new EntityScreenDistributor();
            var builder = new EntityScreenBuilder(new EntityOptionResult());
            entityBuild.EntityBuilder = builder;
            var result = entityBuild.EntityScreenBuild("Moduler");
            return result;
        }
    }
}
