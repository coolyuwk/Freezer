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
// Generated by IDLImporter from file nsIControllerContext.idl
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
	[Guid("47B82B60-A36F-4167-8072-6F421151ED50")]
	internal interface nsIControllerContext
	{
		
		/// <summary>
        /// Init the controller, optionally passing a controller
        /// command table.
        ///
        /// @param aCommandTable  a command table, used internally
        /// by this controller. May be null, in
        /// which case the controller will create
        /// a new, empty table.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIControllerCommandTable aCommandTable);
		
		/// <summary>
        /// Set a context on this controller, which is passed
        /// to commands to give them some context when they execute.
        ///
        /// @param aCommandContext  the context passed to commands.
        /// Note that this is *not* addreffed by the
        /// controller, and so needs to outlive it,
        /// or be nulled out.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCommandContext([MarshalAs(UnmanagedType.Interface)] nsISupports aCommandContext);
	}
}
