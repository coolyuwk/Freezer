namespace Gecko.WebIDL
{
    using System;
    
    
    internal class WheelEvent : WebIDLBase
    {
        
        public WheelEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public double DeltaX
        {
            get
            {
                return this.GetProperty<double>("deltaX");
            }
        }
        
        public double DeltaY
        {
            get
            {
                return this.GetProperty<double>("deltaY");
            }
        }
        
        public double DeltaZ
        {
            get
            {
                return this.GetProperty<double>("deltaZ");
            }
        }
        
        public uint DeltaMode
        {
            get
            {
                return this.GetProperty<uint>("deltaMode");
            }
        }
    }
}
