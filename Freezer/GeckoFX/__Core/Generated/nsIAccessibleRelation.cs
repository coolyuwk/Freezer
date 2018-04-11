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
// Generated by IDLImporter from file nsIAccessibleRelation.idl
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
    /// This interface gives access to an accessible's set of relations.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("55b308c4-2ae4-46bc-b4cd-4d4370e0a660")]
	internal interface nsIAccessibleRelation
	{
		
		/// <summary>
        /// Returns the type of the relation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetRelationTypeAttribute();
		
		/// <summary>
        /// Returns the number of targets for this relation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetTargetsCountAttribute();
		
		/// <summary>
        /// Returns one accessible relation target.
        /// @param index - 0 based index of relation target.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessible GetTarget(uint index);
		
		/// <summary>
        /// Returns multiple accessible relation targets.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetTargets();
	}
	
	/// <summary>nsIAccessibleRelationConsts </summary>
	internal class nsIAccessibleRelationConsts
	{
		
		// <summary>
        // This object is labelled by a target object.
        // </summary>
		public const ulong RELATION_LABELLED_BY = 0x00;
		
		// <summary>
        // This object is label for a target object.
        // </summary>
		public const ulong RELATION_LABEL_FOR = 0x01;
		
		// <summary>
        // This object is described by the target object.
        // </summary>
		public const ulong RELATION_DESCRIBED_BY = 0x02;
		
		// <summary>
        // This object is describes the target object.
        // </summary>
		public const ulong RELATION_DESCRIPTION_FOR = 0x3;
		
		// <summary>
        // This object is a child of a target object.
        // </summary>
		public const ulong RELATION_NODE_CHILD_OF = 0x4;
		
		// <summary>
        // This object is a parent of a target object. A dual relation to
        // RELATION_NODE_CHILD_OF
        // </summary>
		public const ulong RELATION_NODE_PARENT_OF = 0x5;
		
		// <summary>
        // Some attribute of this object is affected by a target object.
        // </summary>
		public const ulong RELATION_CONTROLLED_BY = 0x06;
		
		// <summary>
        // This object is interactive and controls some attribute of a target object.
        // </summary>
		public const ulong RELATION_CONTROLLER_FOR = 0x07;
		
		// <summary>
        // Content flows from this object to a target object, i.e. has content that
        // flows logically to another object in a sequential way, e.g. text flow.
        // </summary>
		public const ulong RELATION_FLOWS_TO = 0x08;
		
		// <summary>
        // Content flows to this object from a target object, i.e. has content that
        // flows logically from another object in a sequential way, e.g. text flow.
        // </summary>
		public const ulong RELATION_FLOWS_FROM = 0x09;
		
		// <summary>
        // This object is a member of a group of one or more objects. When there is
        // more than one object in the group each member may have one and the same
        // target, e.g. a grouping object.  It is also possible that each member has
        // multiple additional targets, e.g. one for every other member in the group.
        // </summary>
		public const ulong RELATION_MEMBER_OF = 0x0a;
		
		// <summary>
        // This object is a sub window of a target object.
        // </summary>
		public const ulong RELATION_SUBWINDOW_OF = 0x0b;
		
		// <summary>
        // This object embeds a target object. This relation can be used on the
        // OBJID_CLIENT accessible for a top level window to show where the content
        // areas are.
        // </summary>
		public const ulong RELATION_EMBEDS = 0x0c;
		
		// <summary>
        // This object is embedded by a target object.
        // </summary>
		public const ulong RELATION_EMBEDDED_BY = 0x0d;
		
		// <summary>
        // This object is a transient component related to the target object. When
        // this object is activated the target object doesn't lose focus.
        // </summary>
		public const ulong RELATION_POPUP_FOR = 0x0e;
		
		// <summary>
        // This object is a parent window of the target object.
        // </summary>
		public const ulong RELATION_PARENT_WINDOW_OF = 0x0f;
		
		// <summary>
        // Part of a form/dialog with a related default button. It is used for
        // MSAA/XPCOM, it isn't for IA2 or ATK.
        // </summary>
		public const ulong RELATION_DEFAULT_BUTTON = 0x10;
		
		// <summary>
        // The target object is the containing document object.
        // </summary>
		public const ulong RELATION_CONTAINING_DOCUMENT = 0x11;
		
		// <summary>
        // The target object is the topmost containing document object in the tab pane.
        // </summary>
		public const ulong RELATION_CONTAINING_TAB_PANE = 0x12;
		
		// <summary>
        // The target object is the containing application object.
        // </summary>
		public const ulong RELATION_CONTAINING_APPLICATION = 0x14;
	}
}
