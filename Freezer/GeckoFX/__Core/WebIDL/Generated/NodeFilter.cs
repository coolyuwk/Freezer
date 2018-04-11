namespace Gecko.WebIDL
{
    using System;
    
    
    internal class NodeFilter : WebIDLBase
    {
        
        public NodeFilter(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ushort AcceptNode(nsIDOMNode node)
        {
            return this.CallMethod<ushort>("acceptNode", node);
        }
    }
}
