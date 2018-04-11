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
// Generated by IDLImporter from file nsIDOMMozBrowserFrame.idl
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
    /// License, v. 2.0. If a copy of the MPL was not distributed with this file,
    /// You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4CAFE116-581B-4194-B0DE-7F02378FC51D")]
	internal interface nsIDOMMozBrowserFrame
	{
		
		/// <summary>
        /// <iframe> element may have the mozbrowser attribute.
        ///
        /// The mozbrowser attribute has no effect unless the <iframe> element is
        /// contained in a document privileged to create browser frames.
        ///
        /// An <iframe> element in a privileged document with the mozbrowser attribute
        /// emits a variety of events when various things happen inside the frame.
        ///
        /// This will be documented eventually, but for more information at the moment,
        /// see dom/browser-element/BrowserElement{Child,Parent}.js.
        ///
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetMozbrowserAttribute();
		
		/// <summary>
        /// <iframe> element may have the mozbrowser attribute.
        ///
        /// The mozbrowser attribute has no effect unless the <iframe> element is
        /// contained in a document privileged to create browser frames.
        ///
        /// An <iframe> element in a privileged document with the mozbrowser attribute
        /// emits a variety of events when various things happen inside the frame.
        ///
        /// This will be documented eventually, but for more information at the moment,
        /// see dom/browser-element/BrowserElement{Child,Parent}.js.
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMozbrowserAttribute([MarshalAs(UnmanagedType.U1)] bool aMozbrowser);
	}
}
