namespace Gecko.WebIDL
{
    using System;
    
    
    internal class NetworkInformation : WebIDLBase
    {
        
        public NetworkInformation(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ConnectionType Type
        {
            get
            {
                return this.GetProperty<ConnectionType>("type");
            }
        }
    }
}
