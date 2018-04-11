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
// Generated by IDLImporter from file nsIContentPrefService.idl
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
	[Guid("746c7a02-f6c1-4869-b434-7c8b86e60e61")]
	internal interface nsIContentPrefObserver
	{
		
		/// <summary>
        /// Called when a content pref is set to a different value.
        ///
        /// @param    aGroup      the group to which the pref belongs, or null
        /// if it's a global pref (applies to all sites)
        /// @param    aName       the name of the pref that was set
        /// @param    aValue      the new value of the pref
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnContentPrefSet([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aGroup, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, [MarshalAs(UnmanagedType.Interface)] nsIVariant aValue);
		
		/// <summary>
        /// Called when a content pref is removed.
        ///
        /// @param    aGroup      the group to which the pref belongs, or null
        /// if it's a global pref (applies to all sites)
        /// @param    aName       the name of the pref that was removed
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnContentPrefRemoved([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aGroup, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);
	}
	
	/// <summary>nsIContentPrefCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c1b3d6df-5373-4606-8494-8bcf14a7fc62")]
	internal interface nsIContentPrefCallback
	{
		
		/// <summary>Member OnResult </summary>
		/// <param name='aResult'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnResult([MarshalAs(UnmanagedType.Interface)] nsIVariant aResult);
	}
	
	/// <summary>
    /// @deprecated Please use nsIContentPrefService2 instead.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e3f772f3-023f-4b32-b074-36cf0fd5d414")]
	internal interface nsIContentPrefService
	{
		
		/// <summary>
        /// Get a pref.
        ///
        /// Besides the regular string, integer, boolean, etc. values, this method
        /// may return null (nsIDataType::VTYPE_EMPTY), which means the pref is set
        /// to NULL in the database, as well as undefined (nsIDataType::VTYPE_VOID),
        /// which means there is no record for this pref in the database.
        ///
        /// This method can be called from content processes in electrolysis builds.
        /// We have a whitelist of values that can be read in such a way.
        ///
        /// @param    aGroup      the group for which to get the pref, as an nsIURI
        /// from which the hostname will be used, a string
        /// (typically in the format of a hostname), or null
        /// to get the global pref (applies to all sites)
        /// @param    aName       the name of the pref to get
        /// @param    aPrivacyContext
        /// a context from which to determine the privacy status
        /// of the pref (ie. whether to search in memory or in
        /// permanent storage for it), obtained from a relevant
        /// window or channel.
        /// @param    aCallback   an optional nsIContentPrefCallback to receive the
        /// result. If desired, JavaScript callers can instead
        /// provide a function to call upon completion
        ///
        /// @returns  the value of the pref
        /// @throws   NS_ERROR_ILLEGAL_VALUE if aGroup is not a string, nsIURI, or null
        /// @throws   NS_ERROR_ILLEGAL_VALUE if aName is null or an empty string
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetPref([MarshalAs(UnmanagedType.Interface)] nsIVariant aGroup, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, [MarshalAs(UnmanagedType.Interface)] nsILoadContext aPrivacyContext, System.IntPtr aCallback);
		
		/// <summary>
        /// Set a pref.
        ///
        /// This method can be called from content processes in electrolysis builds.
        /// We have a whitelist of values that can be set in such a way.
        ///
        /// @param    aGroup      the group for which to set the pref, as an nsIURI
        /// from which the hostname will be used, a string
        /// (typically in the format of a hostname), or null
        /// to set the global pref (applies to all sites)
        /// @param    aName       the name of the pref to set
        /// @param    aValue      the new value of the pref
        /// @param    aPrivacyContext
        /// a context from which to determine the privacy status
        /// of the pref (ie. whether to store it in memory or in
        /// permanent storage), obtained from a relevant
        /// window or channel.
        /// @throws   NS_ERROR_ILLEGAL_VALUE if aGroup is not a string, nsIURI, or null
        /// @throws   NS_ERROR_ILLEGAL_VALUE if aName is null or an empty string
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPref([MarshalAs(UnmanagedType.Interface)] nsIVariant aGroup, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, [MarshalAs(UnmanagedType.Interface)] nsIVariant aValue, [MarshalAs(UnmanagedType.Interface)] nsILoadContext aPrivacyContext);
		
		/// <summary>
        /// Check whether or not a pref exists.
        ///
        /// @param    aGroup      the group for which to check for the pref, as an nsIURI
        /// from which the hostname will be used, a string
        /// (typically in the format of a hostname), or null
        /// to check for the global pref (applies to all sites)
        /// @param    aName       the name of the pref to check for
        /// @param    aPrivacyContext
        /// a context from which to determine the privacy status
        /// of the pref (ie. whether to search in memory or in
        /// permanent storage for it), obtained from a relevant
        /// window or channel.
        /// @throws   NS_ERROR_ILLEGAL_VALUE if aGroup is not a string, nsIURI, or null
        /// @throws   NS_ERROR_ILLEGAL_VALUE if aName is null or an empty string
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasPref([MarshalAs(UnmanagedType.Interface)] nsIVariant aGroup, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, [MarshalAs(UnmanagedType.Interface)] nsILoadContext aContext);
		
		/// <summary>
        /// Check whether or not the value of a pref (or its non-existance) is cached.
        ///
        /// @param    aGroup      the group for which to check for the pref, as an nsIURI
        /// from which the hostname will be used, a string
        /// (typically in the format of a hostname), or null
        /// to check for the global pref (applies to all sites)
        /// @param    aName       the name of the pref to check for
        /// @param    aPrivacyContext
        /// a context from which to determine the privacy status
        /// of the pref (ie. whether to search in memory or in
        /// permanent storage for it), obtained from a relevant
        /// window or channel.
        /// @throws   NS_ERROR_ILLEGAL_VALUE if aGroup is not a string, nsIURI, or null
        /// @throws   NS_ERROR_ILLEGAL_VALUE if aName is null or an empty string
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasCachedPref([MarshalAs(UnmanagedType.Interface)] nsIVariant aGroup, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, [MarshalAs(UnmanagedType.Interface)] nsILoadContext aContext);
		
		/// <summary>
        /// Remove a pref.
        ///
        /// @param    aGroup      the group for which to remove the pref, as an nsIURI
        /// from which the hostname will be used, a string
        /// (typically in the format of a hostname), or null
        /// to remove the global pref (applies to all sites)
        /// @param    aName       the name of the pref to remove
        /// @param    aPrivacyContext
        /// a context from which to determine the privacy status
        /// of the pref (ie. whether to search in memory or in
        /// permanent storage for it), obtained from a relevant
        /// window or channel.
        /// @throws   NS_ERROR_ILLEGAL_VALUE if aGroup is not a string, nsIURI, or null
        /// @throws   NS_ERROR_ILLEGAL_VALUE if aName is null or an empty string
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemovePref([MarshalAs(UnmanagedType.Interface)] nsIVariant aGroup, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, [MarshalAs(UnmanagedType.Interface)] nsILoadContext aContext);
		
		/// <summary>
        /// Remove all grouped prefs.  Useful for removing references to the sites
        /// the user has visited when the user clears their private data.
        ///
        /// @param    aPrivacyContext
        /// a context from which to determine the privacy status
        /// of the pref (ie. whether to remove prefs in memory or
        /// in permanent storage), obtained from a relevant
        /// window or channel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveGroupedPrefs([MarshalAs(UnmanagedType.Interface)] nsILoadContext aContext);
		
		/// <summary>
        /// Remove all prefs with the given name.
        ///
        /// @param    aName        the setting name for which to remove prefs
        /// @param    aPrivacyContext
        /// a context from which to determine the privacy status
        /// of the prefs (ie. whether to remove prefs in memory or
        /// in permanent storage), obtained from a relevant
        /// window or channel.
        /// @throws   NS_ERROR_ILLEGAL_VALUE if aName is null or an empty string
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemovePrefsByName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, [MarshalAs(UnmanagedType.Interface)] nsILoadContext aContext);
		
		/// <summary>
        /// Get the prefs that apply to the given site.
        ///
        /// @param    aGroup      the group for which to retrieve prefs, as an nsIURI
        /// from which the hostname will be used, a string
        /// (typically in the format of a hostname), or null
        /// to get the global prefs (apply to all sites)
        /// @param    aPrivacyContext
        /// a context from which to determine the privacy status
        /// of the pref (ie. whether to search for prefs in memory
        /// or in permanent storage), obtained from a relevant
        /// window or channel.
        ///
        /// @returns  a property bag of prefs
        /// @throws   NS_ERROR_ILLEGAL_VALUE if aGroup is not a string, nsIURI, or null
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPropertyBag2 GetPrefs([MarshalAs(UnmanagedType.Interface)] nsIVariant aGroup, [MarshalAs(UnmanagedType.Interface)] nsILoadContext aContext);
		
		/// <summary>
        /// Get the prefs with the given name.
        ///
        /// @param    aName        the setting name for which to retrieve prefs
        /// @param    aPrivacyContext
        /// a context from which to determine the privacy status
        /// of the pref (ie. whether to search for prefs in memory
        /// or in permanent storage), obtained from a relevant
        /// window or channel.
        ///
        /// @returns  a property bag of prefs
        /// @throws   NS_ERROR_ILLEGAL_VALUE if aName is null or an empty string
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPropertyBag2 GetPrefsByName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, [MarshalAs(UnmanagedType.Interface)] nsILoadContext aContext);
		
		/// <summary>
        /// Add an observer.
        ///
        /// @param    aName       the setting to observe, or null to add
        /// a generic observer that observes all settings
        /// @param    aObserver   the observer to add
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddObserver([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, System.IntPtr aObserver);
		
		/// <summary>
        /// Remove an observer.
        ///
        /// @param    aName       the setting being observed, or null to remove
        /// a generic observer that observes all settings
        /// @param    aObserver   the observer to remove
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveObserver([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, System.IntPtr aObserver);
		
		/// <summary>
        /// The component that the service uses to determine the groups to which
        /// URIs belong.  By default this is the "hostname grouper", which groups
        /// URIs by full hostname (a.k.a. site).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetGrouperAttribute();
		
		/// <summary>
        /// The database connection to the content preferences database.
        /// Useful for accessing and manipulating preferences in ways that are caller-
        /// specific or for which there is not yet a generic method, although generic
        /// functionality useful to multiple callers should generally be added to this
        /// unfrozen interface.  Also useful for testing the database creation
        /// and migration code.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIStorageConnection GetDBConnectionAttribute();
	}
}
