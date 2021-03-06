namespace Gecko.WebIDL
{
    using System;
    
    
    internal class CSSPrimitiveValue : WebIDLBase
    {
        
        public CSSPrimitiveValue(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ushort PrimitiveType
        {
            get
            {
                return this.GetProperty<ushort>("primitiveType");
            }
        }
        
        public void SetFloatValue(ushort unitType, float floatValue)
        {
            this.CallVoidMethod("setFloatValue", unitType, floatValue);
        }
        
        public float GetFloatValue(ushort unitType)
        {
            return this.CallMethod<float>("getFloatValue", unitType);
        }
        
        public void SetStringValue(ushort stringType, string stringValue)
        {
            this.CallVoidMethod("setStringValue", stringType, stringValue);
        }
        
        public string GetStringValue()
        {
            return this.CallMethod<string>("getStringValue");
        }
        
        public nsISupports GetCounterValue()
        {
            return this.CallMethod<nsISupports>("getCounterValue");
        }
        
        public nsISupports GetRectValue()
        {
            return this.CallMethod<nsISupports>("getRectValue");
        }
        
        public nsISupports GetRGBColorValue()
        {
            return this.CallMethod<nsISupports>("getRGBColorValue");
        }
    }
}
