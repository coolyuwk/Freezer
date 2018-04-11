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
// Generated by IDLImporter from file nsIEntityConverter.idl
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
	[Guid("D14C7111-55E0-11d3-91D9-00105AA3F7DC")]
	internal interface nsIEntityConverter
	{
		
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ConvertUTF32ToEntity(uint character, uint entityVersion);
		
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ConvertToEntity(char character, uint entityVersion);
		
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ConvertToEntities([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string inString, uint entityVersion);
	}
	
	/// <summary>nsIEntityConverterConsts </summary>
	internal class nsIEntityConverterConsts
	{
		
		// <summary>
        //This Source Code Form is subject to the terms of the Mozilla Public
        // License, v. 2.0. If a copy of the MPL was not distributed with this
        // file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		public const ulong entityNone = 0;
		
		// 
		public const ulong html40Latin1 = 1;
		
		// 
		public const ulong html40Symbols = 2;
		
		// 
		public const ulong html40Special = 4;
		
		// <summary>
        // excludes &quot, &amp, &lt, &gt
        // </summary>
		public const ulong transliterate = 8;
		
		// <summary>
        // Obsolete
        // </summary>
		public const ulong mathml20 = 16;
		
		// 
		public const ulong html32 = html40Latin1;
		
		// 
		public const ulong html40 = html40Latin1+html40Symbols+html40Special;
		
		// 
		public const ulong entityW3C = html40+mathml20;
	}
}
