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
// Generated by IDLImporter from file nsIDOMNodeFilter.idl
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
    /// Introduced in DOM Level 2:
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e4723748-1dd1-11b2-8ee6-866a532a6237")]
	internal interface nsIDOMNodeFilter
	{
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short AcceptNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode n);
	}
	
	/// <summary>nsIDOMNodeFilterConsts </summary>
	internal class nsIDOMNodeFilterConsts
	{
		
		// <summary>
        // Constants returned by acceptNode
        // </summary>
		public const short FILTER_ACCEPT = 1;
		
		// 
		public const short FILTER_REJECT = 2;
		
		// 
		public const short FILTER_SKIP = 3;
		
		// <summary>
        // Constants for whatToShow
        // </summary>
		public const ulong SHOW_ALL = 0xFFFFFFFF;
		
		// 
		public const ulong SHOW_ELEMENT = 0x00000001;
		
		// 
		public const ulong SHOW_ATTRIBUTE = 0x00000002;
		
		// 
		public const ulong SHOW_TEXT = 0x00000004;
		
		// 
		public const ulong SHOW_CDATA_SECTION = 0x00000008;
		
		// 
		public const ulong SHOW_ENTITY_REFERENCE = 0x00000010;
		
		// 
		public const ulong SHOW_ENTITY = 0x00000020;
		
		// 
		public const ulong SHOW_PROCESSING_INSTRUCTION = 0x00000040;
		
		// 
		public const ulong SHOW_COMMENT = 0x00000080;
		
		// 
		public const ulong SHOW_DOCUMENT = 0x00000100;
		
		// 
		public const ulong SHOW_DOCUMENT_TYPE = 0x00000200;
		
		// 
		public const ulong SHOW_DOCUMENT_FRAGMENT = 0x00000400;
		
		// 
		public const ulong SHOW_NOTATION = 0x00000800;
	}
}
