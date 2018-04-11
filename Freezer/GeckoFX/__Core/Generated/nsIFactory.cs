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
// Generated by IDLImporter from file nsIFactory.idl
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
    /// A class factory allows the creation of nsISupports derived
    /// components without specifying a concrete base class.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("00000001-0000-0000-c000-000000000046")]
	internal interface nsIFactory
	{
		
		/// <summary>
        /// Creates an instance of a component.
        ///
        /// @param aOuter Pointer to a component that wishes to be aggregated
        /// in the resulting instance. This will be nullptr if no
        /// aggregation is requested.
        /// @param iid    The IID of the interface being requested in
        /// the component which is being currently created.
        /// @param result [out] Pointer to the newly created instance, if successful.
        /// @throws NS_NOINTERFACE - Interface not accessible.
        /// @throws NS_ERROR_NO_AGGREGATION - if an 'outer' object is supplied, but the
        /// component is not aggregatable.
        /// NS_ERROR* - Method failure.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr CreateInstance([MarshalAs(UnmanagedType.Interface)] nsISupports aOuter, ref System.Guid iid);
		
		/// <summary>
        /// LockFactory provides the client a way to keep the component
        /// in memory until it is finished with it. The client can call
        /// LockFactory(PR_TRUE) to lock the factory and LockFactory(PR_FALSE)
        /// to release the factory.	
        ///
        /// @param lock - Must be PR_TRUE or PR_FALSE
        /// @throws NS_ERROR* - Method failure.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LockFactory([MarshalAs(UnmanagedType.U1)] bool @lock);
	}
}
