namespace Gecko.WebIDL
{
    using System;
    
    
    internal class DominatorTree : WebIDLBase
    {
        
        public DominatorTree(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public UInt64 Root
        {
            get
            {
                return this.GetProperty<UInt64>("root");
            }
        }
        
        public UInt64 GetRetainedSize(UInt64 node)
        {
            return this.CallMethod<UInt64>("getRetainedSize", node);
        }
        
        public UInt64[] GetImmediatelyDominated(UInt64 node)
        {
            return this.CallMethod<UInt64[]>("getImmediatelyDominated", node);
        }
        
        public UInt64 GetImmediateDominator(UInt64 node)
        {
            return this.CallMethod<UInt64>("getImmediateDominator", node);
        }
    }
}
