using SpaceX.Backoffice.Distributor.Object.EntityDatatable;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX.Backoffice.Operation.EntityOperation.Abstraction
{
    public interface ICreateEntityScreenOperation 
    {
        EntityDatatable CreateScreen();
    }
}
