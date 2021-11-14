using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SpaceX.Backoffice.Distributor.Concrete
{
    public class EntityDistributor<TConcrete, TInterfaces> where TConcrete :class, new() 
    {
        public static (TConcrete objector, bool IsCreate) CreateInjectıon()
        {
            return (new TConcrete(), true);
        }

    }
}
