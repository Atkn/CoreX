using SpaceX.Core.statics;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX.Core.concrete
{
    public class Entity : IEntity
    {
        public string EntityName { get; set; }
        public IDictionary<string, string> Fields { get; set; }
    }
}
