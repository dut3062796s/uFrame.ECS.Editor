using Invert.Json;
using uFrame.Attributes;

namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class PropertiesChildItem : PropertiesChildItemBase {
        private string _friendlyName;

        public override Type Type
        {
            get { return base.Type ?? typeof(int); }
        }

        [JsonProperty]
        public string FriendlyName
        {
            get
            {
                if (string.IsNullOrEmpty(_friendlyName))
                    return Name;
                return _friendlyName;
            }
            set { _friendlyName = value; }
        }


        public override string DefaultTypeName
        {
            get { return typeof(int).Name; }
        }

        [InspectorProperty]
        public bool Mapping
        {
            get { return this["Mapping"]; }
            set { this["Mapping"] = value; }
        }

        public override IEnumerable<Attribute> GetAttributes()
        {
            if (Mapping)
            {
                yield return new uFrameEventMapping(this.Name);
            }
        }
    }
    
    public partial interface IPropertiesConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
}
