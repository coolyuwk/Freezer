namespace Gecko.WebIDL
{
    using System;
    
    
    internal class BrowserElementPrivileged : WebIDLBase
    {
        
        public BrowserElementPrivileged(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void SendMouseEvent(string type, uint x, uint y, uint button, uint clickCount, uint modifiers)
        {
            this.CallVoidMethod("sendMouseEvent", type, x, y, button, clickCount, modifiers);
        }
        
        public void SendTouchEvent(string type, uint[] identifiers, int[] x, int[] y, uint[] rx, uint[] ry, float[] rotationAngles, float[] forces, uint count, uint modifiers)
        {
            this.CallVoidMethod("sendTouchEvent", type, identifiers, x, y, rx, ry, rotationAngles, forces, count, modifiers);
        }
        
        public void GoBack()
        {
            this.CallVoidMethod("goBack");
        }
        
        public void GoForward()
        {
            this.CallVoidMethod("goForward");
        }
        
        public void Reload()
        {
            this.CallVoidMethod("reload");
        }
        
        public void Reload(bool hardReload)
        {
            this.CallVoidMethod("reload", hardReload);
        }
        
        public void Stop()
        {
            this.CallVoidMethod("stop");
        }
        
        public nsISupports Download(string url)
        {
            return this.CallMethod<nsISupports>("download", url);
        }
        
        public nsISupports Download(string url, object options)
        {
            return this.CallMethod<nsISupports>("download", url, options);
        }
        
        public nsISupports PurgeHistory()
        {
            return this.CallMethod<nsISupports>("purgeHistory");
        }
        
        public nsISupports GetScreenshot(uint width, uint height)
        {
            return this.CallMethod<nsISupports>("getScreenshot", width, height);
        }
        
        public nsISupports GetScreenshot(uint width, uint height, string mimeType)
        {
            return this.CallMethod<nsISupports>("getScreenshot", width, height, mimeType);
        }
        
        public void Zoom(float zoom)
        {
            this.CallVoidMethod("zoom", zoom);
        }
        
        public nsISupports GetCanGoBack()
        {
            return this.CallMethod<nsISupports>("getCanGoBack");
        }
        
        public nsISupports GetCanGoForward()
        {
            return this.CallMethod<nsISupports>("getCanGoForward");
        }
        
        public nsISupports GetContentDimensions()
        {
            return this.CallMethod<nsISupports>("getContentDimensions");
        }
        
        public nsISupports SetInputMethodActive(bool isActive)
        {
            return this.CallMethod<nsISupports>("setInputMethodActive", isActive);
        }
        
        public void SetNFCFocus(bool isFocus)
        {
            this.CallVoidMethod("setNFCFocus", isFocus);
        }
        
        public void FindAll(string searchString, BrowserFindCaseSensitivity caseSensitivity)
        {
            this.CallVoidMethod("findAll", searchString, caseSensitivity);
        }
        
        public void FindNext(BrowserFindDirection direction)
        {
            this.CallVoidMethod("findNext", direction);
        }
        
        public void ClearMatch()
        {
            this.CallVoidMethod("clearMatch");
        }
        
        public nsISupports ExecuteScript(string script)
        {
            return this.CallMethod<nsISupports>("executeScript", script);
        }
        
        public nsISupports ExecuteScript(string script, object options)
        {
            return this.CallMethod<nsISupports>("executeScript", script, options);
        }
        
        public nsISupports GetStructuredData()
        {
            return this.CallMethod<nsISupports>("getStructuredData");
        }
        
        public nsISupports GetWebManifest()
        {
            return this.CallMethod<nsISupports>("getWebManifest");
        }
        
        public nsISupports[] AllowedAudioChannels
        {
            get
            {
                return this.GetProperty<nsISupports[]>("allowedAudioChannels");
            }
        }
        
        public void Mute()
        {
            this.CallVoidMethod("mute");
        }
        
        public void Unmute()
        {
            this.CallVoidMethod("unmute");
        }
        
        public nsISupports GetMuted()
        {
            return this.CallMethod<nsISupports>("getMuted");
        }
        
        public void SetVolume(float volume)
        {
            this.CallVoidMethod("setVolume", volume);
        }
        
        public nsISupports GetVolume()
        {
            return this.CallMethod<nsISupports>("getVolume");
        }
    }
}
