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
// Generated by IDLImporter from file inIDOMUtils.idl
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
	[Guid("ec3dc3d5-41d1-4d08-ace5-7e944de6614d")]
	internal interface inIDOMUtils
	{
		
		/// <summary>
        /// CSS utilities
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAllStyleSheets([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument aDoc, ref uint aLength, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ref nsISupports[] aSheets);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupportsArray GetCSSStyleRules([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPseudo);
		
		/// <summary>
        /// Get the line number of a rule.
        ///
        /// @param nsIDOMCSSRule aRule The rule.
        /// @return The rule's line number.  Line numbers are 1-based.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetRuleLine([MarshalAs(UnmanagedType.Interface)] nsIDOMCSSRule aRule);
		
		/// <summary>
        /// Get the column number of a rule.
        ///
        /// @param nsIDOMCSSRule aRule The rule.
        /// @return The rule's column number.  Column numbers are 1-based.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetRuleColumn([MarshalAs(UnmanagedType.Interface)] nsIDOMCSSRule aRule);
		
		/// <summary>
        /// Like getRuleLine, but if the rule is in a <style> element,
        /// returns a line number relative to the start of the element.
        ///
        /// @param nsIDOMCSSRule aRule the rule to examine
        /// @return the line number of the rule, possibly relative to the
        /// <style> element
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetRelativeRuleLine([MarshalAs(UnmanagedType.Interface)] nsIDOMCSSRule aRule);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetCSSLexer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aText, System.IntPtr jsContext);
		
		/// <summary>
        /// should consider using [ChromeOnly] APIs on that.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetSelectorCount([MarshalAs(UnmanagedType.Interface)] nsIDOMCSSStyleRule aRule);
		
		/// <summary>
        /// For all three functions below, aSelectorIndex is 0-based
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSelectorText([MarshalAs(UnmanagedType.Interface)] nsIDOMCSSStyleRule aRule, uint aSelectorIndex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetSpecificity([MarshalAs(UnmanagedType.Interface)] nsIDOMCSSStyleRule aRule, uint aSelectorIndex);
		
		/// <summary>
        /// idea what the right scope is.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool SelectorMatchesElement([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, [MarshalAs(UnmanagedType.Interface)] nsIDOMCSSStyleRule aRule, uint aSelectorIndex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPseudo);
		
		/// <summary>
        /// Returns true if the string names a property that is inherited by default.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsInheritedProperty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPropertyName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCSSPropertyNames(uint aFlags, ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ref System.IntPtr[] aProps);
		
		/// <summary>
        /// Get a list of all valid keywords and colors for aProperty.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCSSValuesForProperty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aProperty, ref uint aLength, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ref System.IntPtr[] aValues);
		
		/// <summary>
        /// Utilities for working with CSS colors
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal ColorNameToRGB([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aColorName, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RgbToColorName(System.IntPtr aR, System.IntPtr aG, System.IntPtr aB, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// formats e.g. CMYK.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal ColorToRGBA([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aColorString, System.IntPtr jsContext);
		
		/// <summary>
        /// Check whether a given color is a valid CSS color.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsValidCSSColor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aColorString);
		
		/// <summary>
        /// aPropertyValue: A property value e.g. "red" or "red !important"
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool CssPropertyIsValid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPropertyName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPropertyValue);
		
		/// <summary>
        /// Throws on unsupported property names.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSubpropertiesForCSSProperty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aProperty, ref uint aLength, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ref System.IntPtr[] aValues);
		
		/// <summary>
        /// property names.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool CssPropertyIsShorthand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aProperty);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool CssPropertySupportsType([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aProperty, uint type);
		
		/// <summary>
        /// DOM Node utilities
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsIgnorableWhitespace([MarshalAs(UnmanagedType.Interface)] nsIDOMCharacterData aDataNode);
		
		/// <summary>
        /// whether we are showing anonymous content.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetParentForNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode, [MarshalAs(UnmanagedType.U1)] bool aShowingAnonymousContent);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList GetChildrenForNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode, [MarshalAs(UnmanagedType.U1)] bool aShowingAnonymousContent);
		
		/// <summary>
        /// XBL utilities
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetBindingURLs([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);
		
		/// <summary>
        /// content state utilities
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetContentState([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContentState([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, ulong aState);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMFontFaceList GetUsedFontFaces([MarshalAs(UnmanagedType.Interface)] nsIDOMRange aRange);
		
		/// <summary>
        /// Get the names of all the supported pseudo-elements.
        /// Pseudo-elements which are only accepted in UA style sheets are
        /// not included.
        ///
        /// @param {unsigned long} aCount the number of items returned
        /// @param {wstring[]} aNames the names
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCSSPseudoElementNames(ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref System.IntPtr[] aNames);
		
		/// <summary>
        /// pseudo-classes are ignored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddPseudoClassLock([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPseudoClass);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemovePseudoClassLock([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPseudoClass);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasPseudoClassLock([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPseudoClass);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearPseudoClassLocks([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);
		
		/// <summary>
        /// Parse CSS and update the style sheet in place.
        ///
        /// @param DOMCSSStyleSheet aSheet
        /// @param DOMString aInput
        /// The new source string for the style sheet.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ParseStyleSheet([MarshalAs(UnmanagedType.Interface)] nsIDOMCSSStyleSheet aSheet, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aInput);
		
		/// <summary>
        /// Scroll an element completely into view, if possible.
        /// This is similar to ensureElementIsVisible but for all ancestors.
        ///
        /// @param DOMElement aElement
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollElementIntoView([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);
	}
	
	/// <summary>inIDOMUtilsConsts </summary>
	internal class inIDOMUtilsConsts
	{
		
		// <summary>
        // shorthands can be excluded or property aliases included.
        // </summary>
		public const ulong EXCLUDE_SHORTHANDS = (1<<0);
		
		// 
		public const ulong INCLUDE_ALIASES = (1<<1);
		
		// <summary>
        // unknown types.
        // </summary>
		public const ulong TYPE_LENGTH = 0;
		
		// 
		public const ulong TYPE_PERCENTAGE = 1;
		
		// 
		public const ulong TYPE_COLOR = 2;
		
		// 
		public const ulong TYPE_URL = 3;
		
		// 
		public const ulong TYPE_ANGLE = 4;
		
		// 
		public const ulong TYPE_FREQUENCY = 5;
		
		// 
		public const ulong TYPE_TIME = 6;
		
		// 
		public const ulong TYPE_GRADIENT = 7;
		
		// 
		public const ulong TYPE_TIMING_FUNCTION = 8;
		
		// 
		public const ulong TYPE_IMAGE_RECT = 9;
		
		// 
		public const ulong TYPE_NUMBER = 10;
	}
}
