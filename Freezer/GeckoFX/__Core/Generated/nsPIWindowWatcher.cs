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
// Generated by IDLImporter from file nsPIWindowWatcher.idl
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
    ///Private "control" methods on the Window Watcher. These are annoying
    ///   bookkeeping methods, not part of the public (embedding) interface. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0f2d9d75-c46b-4114-802e-83b4655e61d2")]
	internal interface nsPIWindowWatcher
	{
		
		/// <summary>
        ///A window has been created. Add it to our list.
        ///      @param aWindow the window to add
        ///      @param aChrome the corresponding chrome window. The DOM window
        ///                     and chrome will be mapped together, and the corresponding
        ///                     chrome can be retrieved using the (not private)
        ///                     method getChromeForWindow. If null, any extant mapping
        ///                     will be cleared.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.Interface)] nsIWebBrowserChrome aChrome);
		
		/// <summary>
        ///A window has been closed. Remove it from our list.
        ///      @param aWindow the window to remove
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
		
		/// <summary>
        ///Like the internal interface's open(), but can handle openDialog-style
        ///      arguments and calls which shouldn't result in us navigating the window.
        ///      @param aParent parent window, if any. Null if no parent.  If it is
        ///             impossible to get to an nsIWebBrowserChrome from aParent, this
        ///             method will effectively act as if aParent were null.
        ///      @param aURL url to which to open the new window. Must already be
        ///             escaped, if applicable. can be null.
        ///      @param aName window name from JS window.open. can be null.  If a window
        ///             with this name already exists, the openWindow call may just load
        ///             aUrl in it (if aUrl is not null) and return it.
        ///      @param aFeatures window features from JS window.open. can be null.
        ///      @param aCalledFromScript true if we were called from script.
        ///      @param aDialog use dialog defaults (see nsIDOMWindow::openDialog)
        ///      @param aNavigate true if we should navigate the new window to the
        ///             specified URL.
        ///      @param aOpeningTab the nsITabParent that is opening the new window. The
        ///                         nsITabParent is a remote tab belonging to aParent. Can
        ///                         be nullptr if this window is not being opened from a tab.
        ///      @param aArgs Window argument
        ///      @return the new window
        ///      @note This method may examine the JS context stack for purposes of
        ///            determining the security context to use for the search for a given
        ///            window named aName.
        ///      @note This method should try to set the default charset for the new
        ///            window to the default charset of the document in the calling window
        ///            (which is determined based on the JS stack and the value of
        ///            aParent).  This is not guaranteed, however.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow OpenWindow2([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPStr)] string aUrl, [MarshalAs(UnmanagedType.LPStr)] string aName, [MarshalAs(UnmanagedType.LPStr)] string aFeatures, [MarshalAs(UnmanagedType.U1)] bool aCalledFromScript, [MarshalAs(UnmanagedType.U1)] bool aDialog, [MarshalAs(UnmanagedType.U1)] bool aNavigate, [MarshalAs(UnmanagedType.Interface)] nsITabParent aOpeningTab, [MarshalAs(UnmanagedType.Interface)] nsISupports aArgs);
		
		/// <summary>
        /// Find a named docshell tree item amongst all windows registered
        /// with the window watcher.  This may be a subframe in some window,
        /// for example.
        ///
        /// @param aName the name of the window.  Must not be null.
        /// @param aRequestor the tree item immediately making the request.
        /// We should make sure to not recurse down into its findItemWithName
        /// method.
        /// @param aOriginalRequestor the original treeitem that made the request.
        /// Used for security checks.
        /// @return the tree item with aName as the name, or null if there
        /// isn't one.  "Special" names, like _self, _top, etc, will be
        /// treated specially only if aRequestor is null; in that case they
        /// will be resolved relative to the first window the windowwatcher
        /// knows about.
        /// @see findItemWithName methods on nsIDocShellTreeItem and
        /// nsIDocShellTreeOwner
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem FindItemWithName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aName, [MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem aRequestor, [MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem aOriginalRequestor);
	}
}
