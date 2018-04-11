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
// Generated by IDLImporter from file nsIContentPolicy.idl
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
    /// Interface for content policy mechanism.  Implementations of this
    /// interface can be used to control loading of various types of out-of-line
    /// content, or processing of certain types of in-line content.
    ///
    /// WARNING: do not block the caller from shouldLoad or shouldProcess (e.g.,
    /// by launching a dialog to prompt the user for something).
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("caad4f1f-d047-46ac-ae9d-dc598e4fb91b")]
	internal interface nsIContentPolicy : nsIContentPolicyBase
	{
		
		/// <summary>
        /// Should the resource at this location be loaded?
        /// ShouldLoad will be called before loading the resource at aContentLocation
        /// to determine whether to start the load at all.
        ///
        /// @param aContentType      the type of content being tested. This will be one
        /// one of the TYPE_* constants.
        ///
        /// @param aContentLocation  the location of the content being checked; must
        /// not be null
        ///
        /// @param aRequestOrigin    OPTIONAL. the location of the resource that
        /// initiated this load request; can be null if
        /// inapplicable
        ///
        /// @param aContext          OPTIONAL. the nsIDOMNode or nsIDOMWindow that
        /// initiated the request, or something that can QI
        /// to one of those; can be null if inapplicable.
        /// Note that for navigation events (new windows and
        /// link clicks), this is the NEW window.
        ///
        /// @param aMimeTypeGuess    OPTIONAL. a guess for the requested content's
        /// MIME type, based on information available to
        /// the request initiator (e.g., an OBJECT's type
        /// attribute); does not reliably reflect the
        /// actual MIME type of the requested content
        ///
        /// @param aExtra            an OPTIONAL argument, pass-through for non-Gecko
        /// callers to pass extra data to callees.
        ///
        /// @param aRequestPrincipal an OPTIONAL argument, defines the principal that
        /// caused the load. This is optional only for
        /// non-gecko code: all gecko code should set this
        /// argument.  For navigation events, this is
        /// the principal of the page that caused this load.
        ///
        /// @return ACCEPT or REJECT_*
        ///
        /// @note shouldLoad can be called while the DOM and layout of the document
        /// involved is in an inconsistent state.  This means that implementors of
        /// this method MUST NOT do any of the following:
        /// 1)  Modify the DOM in any way (e.g. setting attributes is a no-no).
        /// 2)  Query any DOM properties that depend on layout (e.g. offset*
        /// properties).
        /// 3)  Query any DOM properties that depend on style (e.g. computed style).
        /// 4)  Query any DOM properties that depend on the current state of the DOM
        /// outside the "context" node (e.g. lengths of node lists).
        /// 5)  [JavaScript implementations only] Access properties of any sort on any
        /// object without using XPCNativeWrapper (either explicitly or
        /// implicitly).  Due to various DOM0 things, this leads to item 4.
        /// If you do any of these things in your shouldLoad implementation, expect
        /// unpredictable behavior, possibly including crashes, content not showing
        /// up, content showing up doubled, etc.  If you need to do any of the things
        /// above, do them off timeout or event.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short ShouldLoad(System.IntPtr aContentType, [MarshalAs(UnmanagedType.Interface)] nsIURI aContentLocation, [MarshalAs(UnmanagedType.Interface)] nsIURI aRequestOrigin, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMimeTypeGuess, [MarshalAs(UnmanagedType.Interface)] nsISupports aExtra, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aRequestPrincipal);
		
		/// <summary>
        /// Should the resource be processed?
        /// ShouldProcess will be called once all the information passed to it has
        /// been determined about the resource, typically after part of the resource
        /// has been loaded.
        ///
        /// @param aContentType      the type of content being tested. This will be one
        /// one of the TYPE_* constants.
        ///
        /// @param aContentLocation  OPTIONAL; the location of the resource being
        /// requested: MAY be, e.g., a post-redirection URI
        /// for the resource.
        ///
        /// @param aRequestOrigin    OPTIONAL. the location of the resource that
        /// initiated this load request; can be null if
        /// inapplicable
        ///
        /// @param aContext          OPTIONAL. the nsIDOMNode or nsIDOMWindow that
        /// initiated the request, or something that can QI
        /// to one of those; can be null if inapplicable.
        ///
        /// @param aMimeType         the MIME type of the requested resource (e.g.,
        /// image/png), as reported by the networking library,
        /// if available (may be empty if inappropriate for
        /// the type, e.g., TYPE_REFRESH).
        ///
        /// @param aExtra            an OPTIONAL argument, pass-through for non-Gecko
        /// callers to pass extra data to callees.
        ///
        /// @return ACCEPT or REJECT_*
        ///
        /// @note shouldProcess can be called while the DOM and layout of the document
        /// involved is in an inconsistent state.  See the note on shouldLoad to see
        /// what this means for implementors of this method.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short ShouldProcess(System.IntPtr aContentType, [MarshalAs(UnmanagedType.Interface)] nsIURI aContentLocation, [MarshalAs(UnmanagedType.Interface)] nsIURI aRequestOrigin, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMimeType, [MarshalAs(UnmanagedType.Interface)] nsISupports aExtra, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aRequestPrincipal);
	}
}
