namespace Gecko.WebIDL
{
    using System;
    
    
    internal class ServiceWorkerMessageEvent : WebIDLBase
    {
        
        public ServiceWorkerMessageEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public object Data
        {
            get
            {
                return this.GetProperty<object>("data");
            }
        }
        
        public string Origin
        {
            get
            {
                return this.GetProperty<string>("origin");
            }
        }
        
        public string LastEventId
        {
            get
            {
                return this.GetProperty<string>("lastEventId");
            }
        }
        
        public WebIDLUnion<nsISupports,nsISupports> Source
        {
            get
            {
                return this.GetProperty<WebIDLUnion<nsISupports,nsISupports>>("source");
            }
        }
        
        public nsISupports Ports
        {
            get
            {
                return this.GetProperty<nsISupports>("ports");
            }
        }
    }
}
