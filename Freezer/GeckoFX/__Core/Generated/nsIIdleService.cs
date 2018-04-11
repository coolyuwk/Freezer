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
// Generated by IDLImporter from file nsIIdleService.idl
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
    /// This interface lets you monitor how long the user has been 'idle',
    /// i.e. not used their mouse or keyboard. You can get the idle time directly,
    /// but in most cases you will want to register an observer for a predefined
    /// interval. The observer will get an 'idle' notification when the user is idle
    /// for that interval (or longer), and receive an 'active' notification when the
    /// user starts using their computer again.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("cc52f19a-63ae-4a1c-9cc3-e79eace0b471")]
	internal interface nsIIdleService
	{
		
		/// <summary>
        /// The amount of time in milliseconds that has passed
        /// since the last user activity.
        ///
        /// If we do not have a valid idle time to report, 0 is returned
        /// (this can happen if the user never interacted with the browser
        /// at all, and if we are also unable to poll for idle time manually).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetIdleTimeAttribute();
		
		/// <summary>
        /// Add an observer to be notified when the user idles for some period of
        /// time, and when they get back from that.
        ///
        /// @param observer the observer to be notified
        /// @param time the amount of time in seconds the user should be idle before
        /// the observer should be notified.
        ///
        /// @note
        /// The subject of the notification the observer will get is always the
        /// nsIIdleService itself.
        /// When the user goes idle, the observer topic is "idle" and when he gets
        /// back, the observer topic is "active".
        /// The data param for the notification contains the current user idle time.
        ///
        /// @note
        /// You can add the same observer twice.
        /// @note
        /// Most implementations need to poll the OS for idle info themselves,
        /// meaning your notifications could arrive with a delay up to the length
        /// of the polling interval in that implementation.
        /// Current implementations use a delay of 5 seconds.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddIdleObserver([MarshalAs(UnmanagedType.Interface)] nsIObserver observer, uint time);
		
		/// <summary>
        /// Remove an observer registered with addIdleObserver.
        /// @param observer the observer that needs to be removed.
        /// @param time the amount of time they were listening for.
        /// @note
        /// Removing an observer will remove it once, for the idle time you specify.
        /// If you have added an observer multiple times, you will need to remove it
        /// just as many times.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveIdleObserver([MarshalAs(UnmanagedType.Interface)] nsIObserver observer, uint time);
	}
}
