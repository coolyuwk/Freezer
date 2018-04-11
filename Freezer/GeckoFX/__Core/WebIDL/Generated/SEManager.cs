namespace Gecko.WebIDL
{
    using System;
    
    
    internal class SEManager : WebIDLBase
    {
        
        public SEManager(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise < nsISupports[] > GetSEReaders()
        {
            return this.CallMethod<Promise < nsISupports[] >>("getSEReaders");
        }
    }
}
