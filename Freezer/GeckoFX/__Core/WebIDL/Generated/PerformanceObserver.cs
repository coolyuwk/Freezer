namespace Gecko.WebIDL
{
    using System;
    
    
    internal class PerformanceObserver : WebIDLBase
    {
        
        public PerformanceObserver(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void Observe(object options)
        {
            this.CallVoidMethod("observe", options);
        }
        
        public void Disconnect()
        {
            this.CallVoidMethod("disconnect");
        }
    }
}
