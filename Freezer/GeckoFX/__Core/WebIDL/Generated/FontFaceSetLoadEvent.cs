namespace Gecko.WebIDL
{
    using System;
    
    
    internal class FontFaceSetLoadEvent : WebIDLBase
    {
        
        public FontFaceSetLoadEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports[] Fontfaces
        {
            get
            {
                return this.GetProperty<nsISupports[]>("fontfaces");
            }
        }
    }
}
