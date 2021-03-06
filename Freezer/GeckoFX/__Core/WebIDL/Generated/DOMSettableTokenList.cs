namespace Gecko.WebIDL
{
    using System;
    
    
    internal class DOMSettableTokenList : WebIDLBase
    {
        
        public DOMSettableTokenList(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Value
        {
            get
            {
                return this.GetProperty<string>("value");
            }
            set
            {
                this.SetProperty("value", value);
            }
        }
    }
}
