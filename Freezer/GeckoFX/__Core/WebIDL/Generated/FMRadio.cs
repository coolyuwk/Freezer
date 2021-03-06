namespace Gecko.WebIDL
{
    using System;
    
    
    internal class FMRadio : WebIDLBase
    {
        
        public FMRadio(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public bool RdsEnabled
        {
            get
            {
                return this.GetProperty<bool>("rdsEnabled");
            }
        }
        
        public bool AntennaAvailable
        {
            get
            {
                return this.GetProperty<bool>("antennaAvailable");
            }
        }
        
        public System.Nullable<double> Frequency
        {
            get
            {
                return this.GetProperty<System.Nullable<double>>("frequency");
            }
        }
        
        public double FrequencyUpperBound
        {
            get
            {
                return this.GetProperty<double>("frequencyUpperBound");
            }
        }
        
        public double FrequencyLowerBound
        {
            get
            {
                return this.GetProperty<double>("frequencyLowerBound");
            }
        }
        
        public double ChannelWidth
        {
            get
            {
                return this.GetProperty<double>("channelWidth");
            }
        }
        
        public uint RdsGroupMask
        {
            get
            {
                return this.GetProperty<uint>("rdsGroupMask");
            }
            set
            {
                this.SetProperty("rdsGroupMask", value);
            }
        }
        
        public System.Nullable<ushort> Pi
        {
            get
            {
                return this.GetProperty<System.Nullable<ushort>>("pi");
            }
        }
        
        public System.Nullable<byte> Pty
        {
            get
            {
                return this.GetProperty<System.Nullable<byte>>("pty");
            }
        }
        
        public string Ps
        {
            get
            {
                return this.GetProperty<string>("ps");
            }
        }
        
        public string Rt
        {
            get
            {
                return this.GetProperty<string>("rt");
            }
        }
        
        public IntPtr Rdsgroup
        {
            get
            {
                return this.GetProperty<IntPtr>("rdsgroup");
            }
        }
        
        public nsISupports Disable()
        {
            return this.CallMethod<nsISupports>("disable");
        }
        
        public nsISupports Enable(double frequency)
        {
            return this.CallMethod<nsISupports>("enable", frequency);
        }
        
        public nsISupports SetFrequency(double frequency)
        {
            return this.CallMethod<nsISupports>("setFrequency", frequency);
        }
        
        public nsISupports SeekUp()
        {
            return this.CallMethod<nsISupports>("seekUp");
        }
        
        public nsISupports SeekDown()
        {
            return this.CallMethod<nsISupports>("seekDown");
        }
        
        public nsISupports CancelSeek()
        {
            return this.CallMethod<nsISupports>("cancelSeek");
        }
        
        public nsISupports EnableRDS()
        {
            return this.CallMethod<nsISupports>("enableRDS");
        }
        
        public nsISupports DisableRDS()
        {
            return this.CallMethod<nsISupports>("disableRDS");
        }
    }
}
