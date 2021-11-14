using SpaceX.Backoffice.Core;
using SpaceX.Backoffice.Core.Database.Adonet;
using SpaceX.Backoffice.Core.EntityOptions;
using SpaceX.Backoffice.Distributor.EntityBuilder.Concrete;
using SpaceX.Backoffice.Distributor.EntityBuilder.Concrete.EntityScreenDistributor;
using SpaceX.Backoffice.Operation.EntityOperation;
using SpaceX.Core.concrete;
using SpaceX.Core.statics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SpaceX.Packages.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var createScreen = new CreateEntityScreenOperation();
            createScreen.CreateScreen();
        }
    }
}
