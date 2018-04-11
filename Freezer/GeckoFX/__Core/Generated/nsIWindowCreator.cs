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
// Generated by IDLImporter from file nsIWindowCreator.idl
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
    /// nsIWindowCreator is a callback interface used by Gecko to create
    /// new browser windows. The application, either Mozilla or an embedding app,
    /// must provide an implementation of the Window Watcher component and
    /// notify the WindowWatcher during application initialization.
    /// @see nsIWindowWatcher
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("30465632-A777-44cc-90F9-8145475EF999")]
	internal interface nsIWindowCreator
	{
		
		/// <summary>
        ///Create a new window. Gecko will/may call this method, if made
        ///      available to it, to create new windows.
        ///      @param parent parent window, if any. null if not. the newly created
        ///                    window should be made a child/dependent window of
        ///                    the parent, if any (and if the concept applies
        ///                    to the underlying OS).
        ///      @param chromeFlags chrome features from nsIWebBrowserChrome
        ///      @return the new window
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebBrowserChrome CreateChromeWindow([MarshalAs(UnmanagedType.Interface)] nsIWebBrowserChrome parent, uint chromeFlags);
	}
}
