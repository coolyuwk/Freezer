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
// Generated by IDLImporter from file nsIMobileMessageCallback.idl
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
	[Guid("19b24f93-7c02-4acf-addd-2f53bbb4e3fd")]
	internal interface nsIMobileMessageCallback
	{
		
		/// <summary>
        /// |message| can be nsI{Mms,Sms}Message.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyMessageSent([MarshalAs(UnmanagedType.Interface)] nsISupports message);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifySendMessageFailed(int error, [MarshalAs(UnmanagedType.Interface)] nsISupports message);
		
		/// <summary>
        /// |message| can be nsI{Mms,Sms}Message.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyMessageGot([MarshalAs(UnmanagedType.Interface)] nsISupports message);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyGetMessageFailed(int error);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyMessageDeleted([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] bool[] deleted, uint count);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyDeleteMessageFailed(int error);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyMessageMarkedRead([MarshalAs(UnmanagedType.U1)] bool read);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyMarkMessageReadFailed(int error);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifySegmentInfoForTextGot(int segments, int charsPerSegment, int charsAvailableInLastSegment);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyGetSegmentInfoForTextFailed(int error);
		
		/// <summary>
        /// SMSC Address get/set result
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyGetSmscAddress([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSmscAddress, uint aTypeOfNumber, uint aNumberPlanIdentification);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyGetSmscAddressFailed(int error);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifySetSmscAddress();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifySetSmscAddressFailed(int error);
	}
	
	/// <summary>nsIMobileMessageCallbackConsts </summary>
	internal class nsIMobileMessageCallbackConsts
	{
		
		// <summary>
        // All SMS related errors.
        // Make sure to keep this list in sync with the list in:
        // mobile/android/base/GeckoSmsManager.java
        // </summary>
		public const ushort SUCCESS_NO_ERROR = 0;
		
		// 
		public const ushort NO_SIGNAL_ERROR = 1;
		
		// 
		public const ushort NOT_FOUND_ERROR = 2;
		
		// 
		public const ushort UNKNOWN_ERROR = 3;
		
		// 
		public const ushort INTERNAL_ERROR = 4;
		
		// 
		public const ushort NO_SIM_CARD_ERROR = 5;
		
		// 
		public const ushort RADIO_DISABLED_ERROR = 6;
		
		// 
		public const ushort INVALID_ADDRESS_ERROR = 7;
		
		// 
		public const ushort FDN_CHECK_ERROR = 8;
		
		// 
		public const ushort NON_ACTIVE_SIM_CARD_ERROR = 9;
		
		// 
		public const ushort STORAGE_FULL_ERROR = 10;
		
		// 
		public const ushort SIM_NOT_MATCHED_ERROR = 11;
		
		// 
		public const ushort NETWORK_PROBLEMS_ERROR = 12;
		
		// 
		public const ushort GENERAL_PROBLEMS_ERROR = 13;
		
		// 
		public const ushort SERVICE_NOT_AVAILABLE_ERROR = 14;
		
		// 
		public const ushort MESSAGE_TOO_LONG_FOR_NETWORK_ERROR = 15;
		
		// 
		public const ushort SERVICE_NOT_SUPPORTED_ERROR = 16;
		
		// 
		public const ushort RETRY_REQUIRED_ERROR = 17;
	}
}
