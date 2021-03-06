namespace Gecko.WebIDL
{
    using System;
    
    
    internal class MediaStreamTrackEvent : WebIDLBase
    {
        
        public MediaStreamTrackEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Receiver
        {
            get
            {
                return this.GetProperty<nsISupports>("receiver");
            }
        }
        
        public nsISupports Track
        {
            get
            {
                return this.GetProperty<nsISupports>("track");
            }
        }
        
        public nsISupports Stream
        {
            get
            {
                return this.GetProperty<nsISupports>("stream");
            }
        }
    }
}
