using SpaceX.Backoffice.Distributor.Object.EntityDatatable;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX.Backoffice.Distributor.EntityBuilder.Abstraction
{
    public interface IEntityScreenBuilder
    {
        EntityDatatable EntityScreenBuild(string entityName);
    }
}
