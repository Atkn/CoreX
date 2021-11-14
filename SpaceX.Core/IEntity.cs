using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX.Core.statics
{
    public interface IEntity
    {
        public string EntityName { get; set; }

        public IDictionary<string, string> Fields { get; set; }
    }
}
