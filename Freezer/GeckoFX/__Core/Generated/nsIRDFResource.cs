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
// Generated by IDLImporter from file nsIRDFResource.idl
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
    /// An nsIRDFResource is an object that has unique identity in the
    /// RDF data model. The object's identity is determined by its URI.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fb9686a7-719a-49dc-9107-10dea5739341")]
	internal interface nsIRDFResource : nsIRDFNode
	{
		
		/// <summary>
        /// Determine if two nodes are identical
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool EqualsNode([MarshalAs(UnmanagedType.Interface)] nsIRDFNode aNode);
		
		/// <summary>
        /// The single-byte string value of the resource.
        /// @note THIS IS OBSOLETE. C++ should use GetValueConst and script
        /// should use .valueUTF8
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetValueAttribute();
		
		/// <summary>
        /// The UTF-8 URI of the resource.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetValueUTF8Attribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aValueUTF8);
		
		/// <summary>
        /// An unscriptable version used to avoid a string copy. Meant
        /// for use as a performance optimization. The string is encoded
        /// in UTF-8.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetValueConst([MarshalAs(UnmanagedType.LPStr)] ref string aConstValue);
		
		/// <summary>
        /// This method is called by the nsIRDFService after constructing
        /// a resource object to initialize its URI. You would not normally
        /// call this method directly
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.LPStr)] string uri);
		
		/// <summary>
        /// Determine if the resource has the given URI.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool EqualsString([MarshalAs(UnmanagedType.LPStr)] string aURI);
		
		/// <summary>
        /// Retrieve the "delegate" object for this resource. A resource
        /// may have several delegate objects, each of whose lifetimes is
        /// bound to the life of the resource object.
        ///
        /// This method will return the delegate for the given key after
        /// QueryInterface()-ing it to the requested IID.
        ///
        /// If no delegate exists for the specified key, this method will
        /// attempt to create one using the component manager. Specifically,
        /// it will combine aKey with the resource's URI scheme to produce
        /// a ContractID as follows:
        ///
        /// component:/rdf/delegate-factory/[key]/[scheme]
        ///
        /// This ContractID will be used to locate a factory using the
        /// FindFactory() method of nsIComponentManager. If the nsIFactory
        /// exists, it will be used to create a "delegate factory"; that
        /// is, an object that supports nsIRDFDelegateFactory. The delegate
        /// factory will be used to construct the delegate object.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetDelegate([MarshalAs(UnmanagedType.LPStr)] string aKey, ref System.Guid aIID);
		
		/// <summary>
        /// Force a delegate to be "unbound" from the resource.
        ///
        /// Normally, a delegate object's lifetime will be identical to
        /// that of the resource to which it is bound; this method allows a
        /// delegate to unlink itself from an RDF resource prematurely.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReleaseDelegate([MarshalAs(UnmanagedType.LPStr)] string aKey);
	}
}
