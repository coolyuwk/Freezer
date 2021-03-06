namespace Gecko.WebIDL
{
    using System;
    
    
    internal class MozWifiManager : WebIDLBase
    {
        
        public MozWifiManager(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool Enabled
        {
            get
            {
                return this.GetProperty<bool>("enabled");
            }
        }
        
        public string MacAddress
        {
            get
            {
                return this.GetProperty<string>("macAddress");
            }
        }
        
        public nsISupports Connection
        {
            get
            {
                return this.GetProperty<nsISupports>("connection");
            }
        }
        
        public nsISupports ConnectionInformation
        {
            get
            {
                return this.GetProperty<nsISupports>("connectionInformation");
            }
        }
        
        public nsISupports Capabilities
        {
            get
            {
                return this.GetProperty<nsISupports>("capabilities");
            }
        }
        
        public nsISupports SetWifiEnabled(bool enabled)
        {
            return this.CallMethod<nsISupports>("setWifiEnabled", enabled);
        }
        
        public nsISupports GetNetworks()
        {
            return this.CallMethod<nsISupports>("getNetworks");
        }
        
        public nsISupports GetKnownNetworks()
        {
            return this.CallMethod<nsISupports>("getKnownNetworks");
        }
        
        public nsISupports Associate(nsISupports network)
        {
            return this.CallMethod<nsISupports>("associate", network);
        }
        
        public nsISupports Forget(nsISupports network)
        {
            return this.CallMethod<nsISupports>("forget", network);
        }
        
        public nsISupports Wps()
        {
            return this.CallMethod<nsISupports>("wps");
        }
        
        public nsISupports Wps(object detail)
        {
            return this.CallMethod<nsISupports>("wps", detail);
        }
        
        public nsISupports SetPowerSavingMode(bool enabled)
        {
            return this.CallMethod<nsISupports>("setPowerSavingMode", enabled);
        }
        
        public nsISupports SetStaticIpMode(nsISupports network)
        {
            return this.CallMethod<nsISupports>("setStaticIpMode", network);
        }
        
        public nsISupports SetStaticIpMode(nsISupports network, object info)
        {
            return this.CallMethod<nsISupports>("setStaticIpMode", network, info);
        }
        
        public nsISupports SetHttpProxy(nsISupports network, object info)
        {
            return this.CallMethod<nsISupports>("setHttpProxy", network, info);
        }
        
        public nsISupports ImportCert(nsIDOMBlob certBlob, string certPassword, string certNickname)
        {
            return this.CallMethod<nsISupports>("importCert", certBlob, certPassword, certNickname);
        }
        
        public nsISupports GetImportedCerts()
        {
            return this.CallMethod<nsISupports>("getImportedCerts");
        }
        
        public nsISupports DeleteCert(string certNickname)
        {
            return this.CallMethod<nsISupports>("deleteCert", certNickname);
        }
    }
}
