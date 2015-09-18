using uFrame.Attributes;

namespace Invert.uFrame.ECS
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;


    public class BranchesChildItem : BranchesChildItemBase, IActionFieldInfo
    {
        public string MemberName { get { return this.Name; } }
        public ITypeInfo MemberType { get { return new SystemTypeInfo(typeof(Action)); } }
        public IEnumerable<Attribute> GetAttributes()
        {
            yield break;
        }

        public bool IsGenericArgument { get { return false; } }
        public bool IsReturn { get { return false; } }
        public bool IsByRef {get { return false; } }
        public FieldDisplayTypeAttribute DisplayType { get{return new Out(MemberName);} }
        public bool IsBranch { get { return true; }}
    }

    public partial interface IBranchesConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable
    {
    }
}
