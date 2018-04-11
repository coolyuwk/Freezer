namespace Gecko.WebIDL
{
    using System;
    
    
    internal class HTMLBRElement : WebIDLBase
    {
        
        public HTMLBRElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Clear
        {
            get
            {
                return this.GetProperty<string>("clear");
            }
            set
            {
                this.SetProperty("clear", value);
            }
        }
    }
}
