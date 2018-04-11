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
// Generated by IDLImporter from file nsIDocumentEncoder.idl
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
	[Guid("3d9371d8-a2ad-403e-8b0e-8885ad3562e3")]
	internal interface nsIDocumentEncoderNodeFixup
	{
		
		/// <summary>
        /// Create a fixed up version of a node. This method is called before
        /// each node in a document is about to be persisted. The implementor
        /// may return a new node with fixed up attributes or null. If null is
        /// returned the node should be used as-is.
        /// @param aNode Node to fixup.
        /// @param [OUT] aSerializeCloneKids True if the document encoder should
        /// apply recursive serialization to the children of the fixed up node
        /// instead of the children of the original node.
        /// @return The resulting fixed up node.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode FixupNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode, [MarshalAs(UnmanagedType.U1)] ref bool aSerializeCloneKids);
	}
	
	/// <summary>nsIDocumentEncoder </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("21f112df-d96f-47da-bfcb-5331273003d1")]
	internal interface nsIDocumentEncoder
	{
		
		/// <summary>
        /// Initialize with a pointer to the document and the mime type.
        /// @param aDocument Document to encode.
        /// @param aMimeType MimeType to use. May also be set by SetMimeType.
        /// @param aFlags Flags to use while encoding. May also be set by SetFlags.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument aDocument, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMimeType, uint aFlags);
		
		/// <summary>Member NativeInit </summary>
		/// <param name='aDocument'> </param>
		/// <param name='aMimeType'> </param>
		/// <param name='aFlags'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NativeInit(System.IntPtr aDocument, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMimeType, uint aFlags);
		
		/// <summary>
        /// If the selection is set to a non-null value, then the
        /// selection is used for encoding, otherwise the entire
        /// document is encoded.
        /// @param aSelection The selection to encode.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSelection([MarshalAs(UnmanagedType.Interface)] nsISelection aSelection);
		
		/// <summary>
        /// If the range is set to a non-null value, then the
        /// range is used for encoding, otherwise the entire
        /// document or selection is encoded.
        /// @param aRange The range to encode.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRange([MarshalAs(UnmanagedType.Interface)] nsIDOMRange aRange);
		
		/// <summary>
        /// If the node is set to a non-null value, then the
        /// node is used for encoding, otherwise the entire
        /// document or range or selection is encoded.
        /// @param aNode The node to encode.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode);
		
		/// <summary>Member SetNativeNode </summary>
		/// <param name='aNode'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNativeNode(System.IntPtr aNode);
		
		/// <summary>
        /// If the container is set to a non-null value, then its
        /// child nodes are used for encoding, otherwise the entire
        /// document or range or selection or node is encoded.
        /// @param aContainer The node which child nodes will be encoded.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContainerNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aContainer);
		
		/// <summary>Member SetNativeContainerNode </summary>
		/// <param name='aContainer'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNativeContainerNode(System.IntPtr aContainer);
		
		/// <summary>
        /// Documents typically have an intrinsic character set,
        /// but if no intrinsic value is found, the platform character set
        /// is used. This function overrides both the intrinisc and platform
        /// charset.
        /// @param aCharset Overrides the both the intrinsic or platform
        /// character set when encoding the document.
        ///
        /// Possible result codes: NS_ERROR_NO_CHARSET_CONVERTER
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCharset([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aCharset);
		
		/// <summary>
        /// Set a wrap column.  This may have no effect in some types of encoders.
        /// @param aWrapColumn Column to which to wrap.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWrapColumn(uint aWrapColumn);
		
		/// <summary>
        /// The mime type preferred by the encoder.  This piece of api was
        /// added because the copy encoder may need to switch mime types on you
        /// if you ask it to copy html that really represents plaintext content.
        /// Call this AFTER Init() and SetSelection() have both been called.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMimeTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMimeType);
		
		/// <summary>
        /// Encode the document and send the result to the nsIOutputStream.
        ///
        /// Possible result codes are the stream errors which might have
        /// been encountered.
        /// @param aStream Stream into which to encode.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EncodeToStream([MarshalAs(UnmanagedType.Interface)] nsIOutputStream aStream);
		
		/// <summary>
        /// Encode the document into a string.
        ///
        /// @return The document encoded into a string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EncodeToString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// Encode the document into a string. Stores the extra context information
        /// into the two arguments.
        /// @param [OUT] aContextString The string where the parent hierarchy
        /// information will be stored.
        /// @param [OUT] aInfoString The string where extra context info will
        /// be stored.
        /// @return The document encoded as a string.
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EncodeToStringWithContext([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aContextString, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aInfoString, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// Encode the document into a string of limited size.
        /// @param aMaxLength After aMaxLength characters, the encoder will stop
        /// encoding new data.
        /// Only values > 0 will be considered.
        /// The returned string may be slightly larger than
        /// aMaxLength because some serializers (eg. HTML)
        /// may need to close some tags after they stop
        /// encoding new data, or finish a line (72 columns
        /// by default for the plain text serializer).
        ///
        /// @return The document encoded into a string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EncodeToStringWithMaxLength(uint aMaxLength, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// Set the fixup object associated with node persistence.
        /// @param aFixup The fixup object.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNodeFixup([MarshalAs(UnmanagedType.Interface)] nsIDocumentEncoderNodeFixup aFixup);
	}
	
	/// <summary>nsIDocumentEncoderConsts </summary>
	internal class nsIDocumentEncoderConsts
	{
		
		// <summary>
        // Output only the selection (as opposed to the whole document).
        // </summary>
		public const ulong OutputSelectionOnly = (1<<0);
		
		// <summary>
        //Plaintext output: Convert html to plaintext that looks like the html.
        // Implies wrap (except inside <pre>), since html wraps.
        // HTML, XHTML and XML output: do prettyprinting, ignoring existing formatting.
        // XML output : it doesn't implicitly wrap
        // </summary>
		public const ulong OutputFormatted = (1<<1);
		
		// <summary>
        //Don't do prettyprinting. Don't do any wrapping that's not in the existing
        // HTML/XML source. This option overrides OutputFormatted if both are set.
        // HTML/XHTML output: If neither are set, there won't be prettyprinting too, but
        // long lines will be wrapped.
        // Supported also in XML and Plaintext output.
        // @note This option does not affect entity conversion.
        // </summary>
		public const ulong OutputRaw = (1<<2);
		
		// <summary>
        // Do not print html head tags.
        // XHTML/HTML output only.
        // </summary>
		public const ulong OutputBodyOnly = (1<<3);
		
		// <summary>
        // Output as though the content is preformatted
        // (e.g. maybe it's wrapped in a PRE or PRE_WRAP style tag)
        // Plaintext output only.
        // XXXbz How does this interact with
        // OutputFormatted/OutputRaw/OutputPreformatted/OutputFormatFlowed?
        // </summary>
		public const ulong OutputPreformatted = (1<<4);
		
		// <summary>
        // Wrap even if we're not doing formatted output (e.g. for text fields).
        // Supported in XML, XHTML, HTML and Plaintext output.
        // Set implicitly in HTML/XHTML output when no OutputRaw.
        // Ignored when OutputRaw.
        // XXXLJ: set implicitly in HTML/XHTML output, to keep compatible behaviors
        // for old callers of this interface
        // XXXbz How does this interact with OutputFormatFlowed?
        // </summary>
		public const ulong OutputWrap = (1<<5);
		
		// <summary>
        // Output for format flowed (RFC 2646). This is used when converting
        // to text for mail sending. This differs just slightly
        // but in an important way from normal formatted, and that is that
        // lines are space stuffed. This can't (correctly) be done later.
        // PlainText output only.
        // XXXbz How does this interact with
        // OutputFormatted/OutputRaw/OutputPreformatted/OutputWrap?
        // </summary>
		public const ulong OutputFormatFlowed = (1<<6);
		
		// <summary>
        // Convert links, image src, and script src to absolute URLs when possible.
        // XHTML/HTML output only.
        // </summary>
		public const ulong OutputAbsoluteLinks = (1<<7);
		
		// <summary>
        // Attempt to encode entities standardized at W3C (HTML, MathML, etc).
        // This is a catch-all flag for documents with mixed contents. Beware of
        // interoperability issues. See below for other flags which might likely
        // do what you want.
        // HTML output only.
        // </summary>
		public const ulong OutputEncodeW3CEntities = (1<<8);
		
		// <summary>
        // LineBreak processing: if this flag is set than CR line breaks will
        // be written. If neither this nor OutputLFLineBreak is set, then we
        // will use platform line breaks. The combination of the two flags will
        // cause CRLF line breaks to be written.
        // </summary>
		public const ulong OutputCRLineBreak = (1<<9);
		
		// <summary>
        // LineBreak processing: if this flag is set than LF line breaks will
        // be written. If neither this nor OutputCRLineBreak is set, then we
        // will use platform line breaks. The combination of the two flags will
        // cause CRLF line breaks to be written.
        // </summary>
		public const ulong OutputLFLineBreak = (1<<10);
		
		// <summary>
        // Output the content of noscript elements (only for serializing
        // to plaintext).
        // </summary>
		public const ulong OutputNoScriptContent = (1<<11);
		
		// <summary>
        // Output the content of noframes elements (only for serializing
        // to plaintext). (Used only internally in the plain text serializer;
        // ignored if passed by the caller.)
        // </summary>
		public const ulong OutputNoFramesContent = (1<<12);
		
		// <summary>
        // Don't allow any formatting nodes (e.g. <br>, <b>) inside a <pre>.
        // This is used primarily by mail. XHTML/HTML output only.
        // </summary>
		public const ulong OutputNoFormattingInPre = (1<<13);
		
		// <summary>
        // Encode entities when outputting to a string.
        // E.g. If set, we'll output &nbsp; if clear, we'll output 0xa0.
        // The basic set is just &nbsp; &amp; &lt; &gt; &quot; for interoperability
        // with older products that don't support &alpha; and friends.
        // HTML output only.
        // </summary>
		public const ulong OutputEncodeBasicEntities = (1<<14);
		
		// <summary>
        // Encode entities when outputting to a string.
        // The Latin1 entity set additionally includes 8bit accented letters
        // between 128 and 255.
        // HTML output only.
        // </summary>
		public const ulong OutputEncodeLatin1Entities = (1<<15);
		
		// <summary>
        // Encode entities when outputting to a string.
        // The HTML entity set additionally includes accented letters, greek
        // letters, and other special markup symbols as defined in HTML4.
        // HTML output only.
        // </summary>
		public const ulong OutputEncodeHTMLEntities = (1<<16);
		
		// <summary>
        // Normally &nbsp; is replaced with a space character when
        // encoding data as plain text, set this flag if that's
        // not desired.
        // Plaintext output only.
        // </summary>
		public const ulong OutputPersistNBSP = (1<<17);
		
		// <summary>
        // Normally when serializing the whole document using the HTML or
        // XHTML serializer, the encoding declaration is rewritten to match.
        // This flag suppresses that behavior.
        // </summary>
		public const ulong OutputDontRewriteEncodingDeclaration = (1<<18);
		
		// <summary>
        // When using the HTML or XHTML serializer, skip elements that are not
        // visible when this flag is set.  Elements are not visible when they
        // have CSS style display:none or visibility:collapse, for example.
        // </summary>
		public const ulong SkipInvisibleContent = (1<<19);
		
		// <summary>
        // Output for delsp=yes (RFC 3676). This is used with OutputFormatFlowed
        // when converting to text for mail sending.
        // PlainText output only.
        // </summary>
		public const ulong OutputFormatDelSp = (1<<20);
		
		// <summary>
        // Drop <br> elements considered "invisible" by the editor. OutputPreformatted
        // implies this flag.
        // </summary>
		public const ulong OutputDropInvisibleBreak = (1<<21);
		
		// <summary>
        // Don't check for _moz_dirty attributes when deciding whether to
        // pretty-print if this flag is set (bug 599983).
        // </summary>
		public const ulong OutputIgnoreMozDirty = (1<<22);
		
		// <summary>
        // Output the content of non-text elements as the placehodler character
        // U+FFFC (OBJECT REPLACEMENT CHARACTER, only for serializing to plaintext).
        // </summary>
		public const ulong OutputNonTextContentAsPlaceholder = (1<<23);
		
		// <summary>
        // Don't Strip ending spaces from a line (only for serializing to plaintext).
        // </summary>
		public const ulong OutputDontRemoveLineEndingSpaces = (1<<24);
		
		// <summary>
        // Serialize in a way that is suitable for copying a plaintext version of the
        // document to the clipboard.  This can for example cause line endings to be
        // injected at preformatted block element boundaries.
        // </summary>
		public const ulong OutputForPlainTextClipboardCopy = (1<<25);
		
		// <summary>
        // Include ruby annotations and ruby parentheses in the output.
        // PlainText output only.
        // </summary>
		public const ulong OutputRubyAnnotation = (1<<26);
		
		// <summary>
        // Disallow breaking of long character strings. This is important
        // for serializing e-mail which contains CJK strings. These must
        // not be broken just as "normal" longs strings aren't broken.
        // </summary>
		public const ulong OutputDisallowLineBreaking = (1<<27);
	}
}
