namespace Gecko.WebIDL
{
    using System;
    
    
    internal class DOMMobileMessageError : WebIDLBase
    {
        
        public DOMMobileMessageError(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public WebIDLUnion<nsISupports,nsISupports> Data
        {
            get
            {
                return this.GetProperty<WebIDLUnion<nsISupports,nsISupports>>("data");
            }
        }
    }
}
