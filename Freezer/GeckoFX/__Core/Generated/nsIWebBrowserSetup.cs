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
// Generated by IDLImporter from file nsIWebBrowserSetup.idl
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
    /// The nsIWebBrowserSetup interface lets you set properties on a browser
    /// object; you can do so at any time during the life cycle of the browser.
    ///
    /// @note Unless stated otherwise, settings are presumed to be enabled by
    /// default.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("F15398A0-8018-11d3-AF70-00A024FFC08C")]
	internal interface nsIWebBrowserSetup
	{
		
		/// <summary>
        /// Sets an integer or boolean property on the new web browser object.
        /// Only PR_TRUE and PR_FALSE are legal boolean values.
        ///
        /// @param aId The identifier of the property to be set.
        /// @param aValue The value of the property.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetProperty(uint aId, uint aValue);
	}
	
	/// <summary>nsIWebBrowserSetupConsts </summary>
	internal class nsIWebBrowserSetupConsts
	{
		
		// <summary>
        // Boolean. Enables/disables plugin support for this browser.
        //
        // @see setProperty
        // </summary>
		public const ulong SETUP_ALLOW_PLUGINS = 1;
		
		// <summary>
        // Boolean. Enables/disables Javascript support for this browser.
        //
        // @see setProperty
        // </summary>
		public const ulong SETUP_ALLOW_JAVASCRIPT = 2;
		
		// <summary>
        // Boolean. Enables/disables meta redirect support for this browser.
        // Meta redirect timers will be ignored if this option is disabled.
        //
        // @see setProperty
        // </summary>
		public const ulong SETUP_ALLOW_META_REDIRECTS = 3;
		
		// <summary>
        // Boolean. Enables/disables subframes within the browser
        //
        // @see setProperty
        // </summary>
		public const ulong SETUP_ALLOW_SUBFRAMES = 4;
		
		// <summary>
        // Boolean. Enables/disables image loading for this browser
        // window. If you disable the images, load a page, then enable the images,
        // the page will *not* automatically load the images for the previously
        // loaded page. This flag controls the state of a webBrowser at load time
        // and does not automatically re-load a page when the state is toggled.
        // Reloading must be done by hand, or by walking through the DOM tree and
        // re-setting the src attributes.
        //
        // @see setProperty
        // </summary>
		public const ulong SETUP_ALLOW_IMAGES = 5;
		
		// <summary>
        // Boolean. Enables/disables whether the document as a whole gets focus before
        // traversing the document's content, or after traversing its content.
        //
        // NOTE: this property is obsolete and now has no effect
        //
        // @see setProperty
        // </summary>
		public const ulong SETUP_FOCUS_DOC_BEFORE_CONTENT = 6;
		
		// <summary>
        // Boolean. Enables/disables the use of global history in the browser. Visited
        // URLs will not be recorded in the global history when it is disabled.
        //
        // @see setProperty
        // </summary>
		public const ulong SETUP_USE_GLOBAL_HISTORY = 256;
		
		// <summary>
        // Boolean. A value of PR_TRUE makes the browser a chrome wrapper.
        // Default is PR_FALSE.
        //
        // @since mozilla1.0
        //
        // @see setProperty
        // </summary>
		public const ulong SETUP_IS_CHROME_WRAPPER = 7;
		
		// <summary>
        // Boolean. Enables/disables DNS prefetch for HTML anchors in this browser.
        // This takes effect starting with the next pageload after the property is
        // set.  The default is to not allow DNS prefetch, for backwards
        // compatibility.
        //
        // @see setProperty
        // </summary>
		public const ulong SETUP_ALLOW_DNS_PREFETCH = 8;
	}
}
