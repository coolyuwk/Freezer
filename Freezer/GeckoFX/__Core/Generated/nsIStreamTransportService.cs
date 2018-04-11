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
// Generated by IDLImporter from file nsIStreamTransportService.idl
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
    /// This service read/writes a stream on a background thread.
    ///
    /// Use this service to transform any blocking stream (e.g., file stream)
    /// into a fully asynchronous stream that can be read/written without
    /// blocking the main thread.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5e0adf7d-9785-45c3-a193-04f25a75da8f")]
	internal interface nsIStreamTransportService
	{
		
		/// <summary>
        /// CreateInputTransport
        ///
        /// @param aStream
        /// The input stream that will be read on a background thread.
        /// This stream must implement "blocking" stream semantics.
        /// @param aStartOffset
        /// The input stream will be read starting from this offset.  Pass
        /// -1 to read from the current stream offset.  NOTE: this parameter
        /// is ignored if the stream does not support nsISeekableStream.
        /// @param aReadLimit
        /// This parameter limits the number of bytes that will be read from
        /// the input stream.  Pass -1 to read everything.
        /// @param aCloseWhenDone
        /// Specify this flag to have the input stream closed once its
        /// contents have been completely read.
        ///
        /// @return nsITransport instance.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsITransport CreateInputTransport([MarshalAs(UnmanagedType.Interface)] nsIInputStream aStream, long aStartOffset, long aReadLimit, [MarshalAs(UnmanagedType.U1)] bool aCloseWhenDone);
		
		/// <summary>
        /// CreateOutputTransport
        ///
        /// @param aStream
        /// The output stream that will be written to on a background thread.
        /// This stream must implement "blocking" stream semantics.
        /// @param aStartOffset
        /// The output stream will be written starting at this offset.  Pass
        /// -1 to write to the current stream offset.  NOTE: this parameter
        /// is ignored if the stream does not support nsISeekableStream.
        /// @param aWriteLimit
        /// This parameter limits the number of bytes that will be written to
        /// the output stream.  Pass -1 for unlimited writing.
        /// @param aCloseWhenDone
        /// Specify this flag to have the output stream closed once its
        /// contents have been completely written.
        ///
        /// @return nsITransport instance.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsITransport CreateOutputTransport([MarshalAs(UnmanagedType.Interface)] nsIOutputStream aStream, long aStartOffset, long aWriteLimit, [MarshalAs(UnmanagedType.U1)] bool aCloseWhenDone);
	}
}
