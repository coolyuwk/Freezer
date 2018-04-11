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
// Generated by IDLImporter from file nsIPluginTag.idl
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
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5daa99d5-265a-4397-b429-c943803e2619")]
	internal interface nsIPluginTag
	{
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDescriptionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aDescription);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFilenameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFilename);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFullpathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFullpath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aVersion);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>
        /// The 'nice' name of this plugin, e.g. 'flash' 'java'
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNiceNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aNiceName);
		
		/// <summary>
        /// FIXME-jsplugins implement missing + tests (whatever that means)
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetBlocklistedAttribute();
		
		/// <summary>
        /// true if the state is non-default and locked, false otherwise.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsEnabledStateLockedAttribute();
		
		/// <summary>
        /// If this plugin is capable of being used (not disabled, blocklisted, etc)
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetActiveAttribute();
		
		/// <summary>
        /// Get a specific nsIBlocklistService::STATE_*
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetBlocklistStateAttribute();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDisabledAttribute();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetClicktoplayAttribute();
		
		/// <summary>
        /// See the STATE_* values above.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetEnabledStateAttribute();
		
		/// <summary>
        /// See the STATE_* values above.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEnabledStateAttribute(uint aEnabledState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetLastModifiedTimeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMimeTypes(ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref System.IntPtr[] aResults);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMimeDescriptions(ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref System.IntPtr[] aResults);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetExtensions(ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref System.IntPtr[] aResults);
	}
	
	/// <summary>nsIPluginTagConsts </summary>
	internal class nsIPluginTagConsts
	{
		
		// <summary>
        // so if new states are added, they must not renumber the existing states.
        // </summary>
		public const ulong STATE_DISABLED = 0;
		
		// 
		public const ulong STATE_CLICKTOPLAY = 1;
		
		// 
		public const ulong STATE_ENABLED = 2;
	}
	
	/// <summary>
    /// An interface representing a "fake" plugin: one implemented in JavaScript, not
    /// as a NPAPI plug-in.  See nsIPluginHost.registerFakePlugin and the
    /// documentation for the FakePluginTagInit dictionary.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6d22c968-226d-4156-b230-da6ad6bbf6e8")]
	internal interface nsIFakePluginTag : nsIPluginTag
	{
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetDescriptionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aDescription);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetFilenameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFilename);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetFullpathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFullpath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aVersion);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>
        /// The 'nice' name of this plugin, e.g. 'flash' 'java'
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNiceNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aNiceName);
		
		/// <summary>
        /// FIXME-jsplugins implement missing + tests (whatever that means)
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetBlocklistedAttribute();
		
		/// <summary>
        /// true if the state is non-default and locked, false otherwise.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetIsEnabledStateLockedAttribute();
		
		/// <summary>
        /// If this plugin is capable of being used (not disabled, blocklisted, etc)
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetActiveAttribute();
		
		/// <summary>
        /// Get a specific nsIBlocklistService::STATE_*
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetBlocklistStateAttribute();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetDisabledAttribute();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetClicktoplayAttribute();
		
		/// <summary>
        /// See the STATE_* values above.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetEnabledStateAttribute();
		
		/// <summary>
        /// See the STATE_* values above.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetEnabledStateAttribute(uint aEnabledState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new long GetLastModifiedTimeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetMimeTypes(ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref System.IntPtr[] aResults);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetMimeDescriptions(ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref System.IntPtr[] aResults);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetExtensions(ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref System.IntPtr[] aResults);
		
		/// <summary>
        /// and will need to be requested by the handler via XHR or similar if desired.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetHandlerURIAttribute();
	}
}
