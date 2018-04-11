// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIComponentManager.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    /// The nsIComponentManager interface.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("d604ffc3-1ba3-4f6c-b65f-1ed4199364c3")]
	internal interface nsIComponentManager
	{
		
		/// <summary>
        /// getClassObject
        ///
        /// Returns the factory object that can be used to create instances of
        /// CID aClass
        ///
        /// @param aClass The classid of the factory that is being requested
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetClassObject(ref System.Guid aClass, ref System.Guid aIID);
		
		/// <summary>
        /// getClassObjectByContractID
        ///
        /// Returns the factory object that can be used to create instances of
        /// CID aClass
        ///
        /// @param aClass The classid of the factory that is being requested
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetClassObjectByContractID([MarshalAs(UnmanagedType.LPStr)] string aContractID, ref System.Guid aIID);
		
		/// <summary>
        /// createInstance
        ///
        /// Create an instance of the CID aClass and return the interface aIID.
        ///
        /// @param aClass : ClassID of object instance requested
        /// @param aDelegate : Used for aggregation
        /// @param aIID : IID of interface requested
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr CreateInstance(ref System.Guid aClass, [MarshalAs(UnmanagedType.Interface)] nsISupports aDelegate, ref System.Guid aIID);
		
		/// <summary>
        /// createInstanceByContractID
        ///
        /// Create an instance of the CID that implements aContractID and return the
        /// interface aIID.
        ///
        /// @param aContractID : aContractID of object instance requested
        /// @param aDelegate : Used for aggregation
        /// @param aIID : IID of interface requested
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr CreateInstanceByContractID([MarshalAs(UnmanagedType.LPStr)] string aContractID, [MarshalAs(UnmanagedType.Interface)] nsISupports aDelegate, ref System.Guid aIID);
		
		/// <summary>
        /// addBootstrappedManifestLocation
        ///
        /// Adds a bootstrapped manifest location on runtime.
        ///
        /// @param aLocation : A directory where chrome.manifest resides,
        /// or an XPI with it on the root.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddBootstrappedManifestLocation([MarshalAs(UnmanagedType.Interface)] nsIFile aLocation);
		
		/// <summary>
        /// removeBootstrappedManifestLocation
        ///
        /// Removes a bootstrapped manifest location on runtime.
        ///
        /// @param aLocation : A directory where chrome.manifest resides,
        /// or an XPI with it on the root.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveBootstrappedManifestLocation([MarshalAs(UnmanagedType.Interface)] nsIFile aLocation);
		
		/// <summary>
        /// getManifestLocations
        ///
        /// Get an array of nsIURIs of all registered and builtin manifest locations.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetManifestLocations();
	}
}
