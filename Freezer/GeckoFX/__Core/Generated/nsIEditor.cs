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
// Generated by IDLImporter from file nsIEditor.idl
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
    ///-*- Mode: C++; tab-width: 4; indent-tabs-mode: nil; c-basic-offset: 2 -*-
    ///
    /// This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("094be624-f0bf-400f-89e2-6a84baab9474")]
	internal interface nsIEditor
	{
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISelection GetSelectionAttribute();
		
		/// <summary>
        /// Finalizes selection and caret for the editor.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FinalizeSelection();
		
		/// <summary>
        /// Init is to tell the implementation of nsIEditor to begin its services
        /// @param aDoc          The dom document interface being observed
        /// @param aRoot         This is the root of the editable section of this
        /// document. If it is null then we get root
        /// from document body.
        /// @param aSelCon       this should be used to get the selection location
        /// (will be null for HTML editors)
        /// @param aFlags        A bitmask of flags for specifying the behavior
        /// of the editor.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument doc, System.IntPtr aRoot, [MarshalAs(UnmanagedType.Interface)] nsISelectionController aSelCon, uint aFlags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase initialValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAttributeOrEquivalent([MarshalAs(UnmanagedType.Interface)] nsIDOMElement element, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase sourceAttrName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase sourceAttrValue, [MarshalAs(UnmanagedType.U1)] bool aSuppressTransaction);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveAttributeOrEquivalent([MarshalAs(UnmanagedType.Interface)] nsIDOMElement element, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase sourceAttrName, [MarshalAs(UnmanagedType.U1)] bool aSuppressTransaction);
		
		/// <summary>
        /// postCreate should be called after Init, and is the time that the editor
        /// tells its documentStateObservers that the document has been created.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PostCreate();
		
		/// <summary>
        /// preDestroy is called before the editor goes away, and gives the editor a
        /// chance to tell its documentStateObservers that the document is going away.
        /// @param aDestroyingFrames set to true when the frames being edited
        /// are being destroyed (so there is no need to modify any nsISelections,
        /// nor is it safe to do so)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PreDestroy([MarshalAs(UnmanagedType.U1)] bool aDestroyingFrames);
		
		/// <summary>
        ///edit flags for this editor.  May be set at any time. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetFlagsAttribute();
		
		/// <summary>
        ///edit flags for this editor.  May be set at any time. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFlagsAttribute(uint aFlags);
		
		/// <summary>
        /// the MimeType of the document
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetContentsMIMETypeAttribute();
		
		/// <summary>
        /// the MimeType of the document
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContentsMIMETypeAttribute([MarshalAs(UnmanagedType.LPStr)] string aContentsMIMEType);
		
		/// <summary>
        ///Returns true if we have a document that is not marked read-only </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsDocumentEditableAttribute();
		
		/// <summary>
        ///Returns true if the current selection anchor is editable </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsSelectionEditableAttribute();
		
		/// <summary>
        /// the DOM Document this editor is associated with, refcounted.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocument GetDocumentAttribute();
		
		/// <summary>
        ///the body element, i.e. the root of the editable document.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetRootElementAttribute();
		
		/// <summary>
        /// the selection controller for the current presentation, refcounted.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISelectionController GetSelectionControllerAttribute();
		
		/// <summary>
        /// DeleteSelection removes all nodes in the current selection.
        /// @param aDir  if eNext, delete to the right (for example, the DEL key)
        /// if ePrevious, delete to the left (for example, the BACKSPACE key)
        /// @param stripWrappers If eStrip, strip any empty inline elements left
        /// behind after the deletion; if eNoStrip, don't.  If in
        /// doubt, pass eStrip -- eNoStrip is only for if you're
        /// about to insert text or similar right after.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteSelection(short action, short stripWrappers);
		
		/// <summary>
        ///Returns true if the document has no *meaningful* content </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDocumentIsEmptyAttribute();
		
		/// <summary>
        ///Returns true if the document is modifed and needs saving </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDocumentModifiedAttribute();
		
		/// <summary>
        ///Sets the current 'Save' document character set </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDocumentCharacterSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aDocumentCharacterSet);
		
		/// <summary>
        ///Sets the current 'Save' document character set </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDocumentCharacterSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aDocumentCharacterSet);
		
		/// <summary>
        ///to be used ONLY when we need to override the doc's modification
        /// state (such as when it's saved).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResetModificationCount();
		
		/// <summary>
        ///Gets the modification count of the document we are editing.
        /// @return the modification count of the document being edited.
        /// Zero means unchanged.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetModificationCount();
		
		/// <summary>
        ///called each time we modify the document.
        /// Increments the modification count of the document.
        /// @param  aModCount  the number of modifications by which
        /// to increase or decrease the count
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void IncrementModificationCount(int aModCount);
		
		/// <summary>
        ///transactionManager Get the transaction manager the editor is using.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsITransactionManager GetTransactionManagerAttribute();
		
		/// <summary>
        ///transactionManager Get the transaction manager the editor is using.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTransactionManagerAttribute([MarshalAs(UnmanagedType.Interface)] nsITransactionManager aTransactionManager);
		
		/// <summary>
        ///doTransaction() fires a transaction.
        /// It is provided here so clients can create their own transactions.
        /// If a transaction manager is present, it is used.
        /// Otherwise, the transaction is just executed directly.
        ///
        /// @param aTxn the transaction to execute
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DoTransaction([MarshalAs(UnmanagedType.Interface)] nsITransaction txn);
		
		/// <summary>
        ///turn the undo system on or off
        /// @param aEnable  if PR_TRUE, the undo system is turned on if available
        /// if PR_FALSE the undo system is turned off if it
        /// was previously on
        /// @return         if aEnable is PR_TRUE, returns NS_OK if
        /// the undo system could be initialized properly
        /// if aEnable is PR_FALSE, returns NS_OK.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EnableUndo([MarshalAs(UnmanagedType.U1)] bool enable);
		
		/// <summary>
        /// The number of items on the undo stack.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetNumberOfUndoItemsAttribute();
		
		/// <summary>
        /// The number of items on the redo stack.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetNumberOfRedoItemsAttribute();
		
		/// <summary>
        ///undo reverses the effects of the last Do operation,
        /// if Undo is enabled in the editor.
        /// It is provided here so clients need no knowledge of whether
        /// the editor has a transaction manager or not.
        /// If a transaction manager is present, it is told to undo,
        /// and the result of that undo is returned.
        /// Otherwise, the Undo request is ignored and an
        /// error NS_ERROR_NOT_AVAILABLE is returned.
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Undo(uint count);
		
		/// <summary>
        ///returns state information about the undo system.
        /// @param aIsEnabled [OUT] PR_TRUE if undo is enabled
        /// @param aCanUndo   [OUT] PR_TRUE if at least one transaction is
        /// currently ready to be undone.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CanUndo([MarshalAs(UnmanagedType.U1)] ref bool isEnabled, [MarshalAs(UnmanagedType.U1)] ref bool canUndo);
		
		/// <summary>
        ///redo reverses the effects of the last Undo operation
        /// It is provided here so clients need no knowledge of whether
        /// the editor has a transaction manager or not.
        /// If a transaction manager is present, it is told to redo and the
        /// result of the previously undone transaction is reapplied to the document.
        /// If no transaction is available for Redo, or if the document
        /// has no transaction manager, the Redo request is ignored and an
        /// error NS_ERROR_NOT_AVAILABLE is returned.
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Redo(uint count);
		
		/// <summary>
        ///returns state information about the redo system.
        /// @param aIsEnabled [OUT] PR_TRUE if redo is enabled
        /// @param aCanRedo   [OUT] PR_TRUE if at least one transaction is
        ///                              currently ready to be redone.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CanRedo([MarshalAs(UnmanagedType.U1)] ref bool isEnabled, [MarshalAs(UnmanagedType.U1)] ref bool canRedo);
		
		/// <summary>
        ///beginTransaction is a signal from the caller to the editor that
        /// the caller will execute multiple updates to the content tree
        /// that should be treated as a single logical operation,
        /// in the most efficient way possible.<br>
        /// All transactions executed between a call to beginTransaction and
        /// endTransaction will be undoable as an atomic action.<br>
        /// endTransaction must be called after beginTransaction.<br>
        /// Calls to beginTransaction can be nested, as long as endTransaction
        /// is called once per beginUpdate.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BeginTransaction();
		
		/// <summary>
        ///endTransaction is a signal to the editor that the caller is
        /// finished updating the content model.<br>
        /// beginUpdate must be called before endTransaction is called.<br>
        /// Calls to beginTransaction can be nested, as long as endTransaction
        /// is called once per beginTransaction.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EndTransaction();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BeginPlaceHolderTransaction([MarshalAs(UnmanagedType.Interface)] nsIAtom name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EndPlaceHolderTransaction();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ShouldTxnSetSelection();
		
		/// <summary>
        ///Set the flag that prevents insertElementTxn from changing the selection
        /// @param   should  Set false to suppress changing the selection;
        /// i.e., before using InsertElement() to insert
        /// under <head> element
        /// WARNING: You must be very careful to reset back to PR_TRUE after
        /// setting PR_FALSE, else selection/caret is trashed
        /// for further editing.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetShouldTxnSetSelection([MarshalAs(UnmanagedType.U1)] bool should);
		
		/// <summary>
        ///Returns the inline spell checker associated with this object. The spell
        /// checker is lazily created, so this function may create the object for
        /// you during this call.
        /// @param  autoCreate  If true, this will create a spell checker object
        /// if one does not exist yet for this editor. If false
        /// and the object has not been created, this function
        /// WILL RETURN NULL.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInlineSpellChecker GetInlineSpellChecker([MarshalAs(UnmanagedType.U1)] bool autoCreate);
		
		/// <summary>
        ///Resyncs spellchecking state (enabled/disabled).  This should be called
        /// when anything that affects spellchecking state changes, such as the
        /// spellcheck attribute value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SyncRealTimeSpell();
		
		/// <summary>
        ///Called when the user manually overrides the spellchecking state for this
        /// editor.
        /// @param  enable  The new state of spellchecking in this editor, as
        /// requested by the user.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSpellcheckUserOverride([MarshalAs(UnmanagedType.U1)] bool enable);
		
		/// <summary>
        ///cut the currently selected text, putting it into the OS clipboard
        /// What if no text is selected?
        /// What about mixed selections?
        /// What are the clipboard formats?
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Cut();
		
		/// <summary>
        ///Can we cut? True if the doc is modifiable, and we have a non-
        /// collapsed selection.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool CanCut();
		
		/// <summary>
        ///copy the currently selected text, putting it into the OS clipboard
        /// What if no text is selected?
        /// What about mixed selections?
        /// What are the clipboard formats?
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Copy();
		
		/// <summary>
        ///Can we copy? True if we have a non-collapsed selection.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool CanCopy();
		
		/// <summary>
        ///Can we delete? True if we have a non-collapsed selection.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool CanDelete();
		
		/// <summary>
        ///paste the text in the OS clipboard at the cursor position, replacing
        /// the selected text (if any)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Paste(int aSelectionType);
		
		/// <summary>
        ///Paste the text in |aTransferable| at the cursor position, replacing the
        /// selected text (if any).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PasteTransferable([MarshalAs(UnmanagedType.Interface)] nsITransferable aTransferable);
		
		/// <summary>
        ///Can we paste? True if the doc is modifiable, and we have
        /// pasteable data in the clipboard.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool CanPaste(int aSelectionType);
		
		/// <summary>
        ///Can we paste |aTransferable| or, if |aTransferable| is null, will a call
        /// to pasteTransferable later possibly succeed if given an instance of
        /// nsITransferable then? True if the doc is modifiable, and, if
        /// |aTransfeable| is non-null, we have pasteable data in |aTransfeable|.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool CanPasteTransferable([MarshalAs(UnmanagedType.Interface)] nsITransferable aTransferable);
		
		/// <summary>
        ///sets the document selection to the entire contents of the document </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SelectAll();
		
		/// <summary>
        ///sets the document selection to the beginning of the document </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BeginningOfDocument();
		
		/// <summary>
        ///sets the document selection to the end of the document </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EndOfDocument();
		
		/// <summary>
        /// setAttribute() sets the attribute of aElement.
        /// No checking is done to see if aAttribute is a legal attribute of the node,
        /// or if aValue is a legal value of aAttribute.
        ///
        /// @param aElement    the content element to operate on
        /// @param aAttribute  the string representation of the attribute to set
        /// @param aValue      the value to set aAttribute to
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase attributestr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase attvalue);
		
		/// <summary>
        /// getAttributeValue() retrieves the attribute's value for aElement.
        ///
        /// @param aElement      the content element to operate on
        /// @param aAttribute    the string representation of the attribute to get
        /// @param aResultValue  [OUT] the value of aAttribute.
        /// Only valid if aResultIsSet is PR_TRUE
        /// @return              PR_TRUE if aAttribute is set on the current node,
        /// PR_FALSE if it is not.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAttributeValue([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase attributestr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase resultValue);
		
		/// <summary>
        /// removeAttribute() deletes aAttribute from the attribute list of aElement.
        /// If aAttribute is not an attribute of aElement, nothing is done.
        ///
        /// @param aElement      the content element to operate on
        /// @param aAttribute    the string representation of the attribute to get
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAttribute);
		
		/// <summary>
        /// cloneAttribute() copies the attribute from the source node to
        /// the destination node and delete those not in the source.
        ///
        /// The supplied nodes MUST BE ELEMENTS (most callers are working with nodes)
        /// @param aAttribute    the name of the attribute to copy
        /// @param aDestNode     the destination element to operate on
        /// @param aSourceNode   the source element to copy attributes from
        /// @exception NS_ERROR_NULL_POINTER at least one of the nodes is null
        /// @exception NS_ERROR_NO_INTERFACE at least one of the nodes is not an
        /// element
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CloneAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAttribute, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aDestNode, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aSourceNode);
		
		/// <summary>
        /// cloneAttributes() is similar to nsIDOMNode::cloneNode(),
        /// it assures the attribute nodes of the destination are identical
        /// with the source node by copying all existing attributes from the
        /// source and deleting those not in the source.
        /// This is used when the destination node (element) already exists
        ///
        /// The supplied nodes MUST BE ELEMENTS (most callers are working with nodes)
        /// @param aDestNode     the destination element to operate on
        /// @param aSourceNode   the source element to copy attributes from
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CloneAttributes([MarshalAs(UnmanagedType.Interface)] nsIDOMNode destNode, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode sourceNode);
		
		/// <summary>
        /// createNode instantiates a new element of type aTag and inserts it
        /// into aParent at aPosition.
        /// @param aTag      The type of object to create
        /// @param aParent   The node to insert the new object into
        /// @param aPosition The place in aParent to insert the new node
        /// @return          The node created.  Caller must release aNewNode.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode CreateNode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase tag, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode parent, int position);
		
		/// <summary>
        /// insertNode inserts aNode into aParent at aPosition.
        /// No checking is done to verify the legality of the insertion.
        /// That is the responsibility of the caller.
        /// @param aNode     The DOM Node to insert.
        /// @param aParent   The node to insert the new object into
        /// @param aPosition The place in aParent to insert the new node
        /// 0=first child, 1=second child, etc.
        /// any number > number of current children = last child
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InsertNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode node, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode parent, int aPosition);
		
		/// <summary>
        /// splitNode() creates a new node identical to an existing node,
        /// and split the contents between the two nodes
        /// @param aExistingRightNode   the node to split.
        /// It will become the new node's next sibling.
        /// @param aOffset              the offset of aExistingRightNode's
        /// content|children to do the split at
        /// @param aNewLeftNode         [OUT] the new node resulting from the split,
        /// becomes aExistingRightNode's previous sibling.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SplitNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode existingRightNode, int offset, [MarshalAs(UnmanagedType.Interface)] ref nsIDOMNode newLeftNode);
		
		/// <summary>
        /// joinNodes() takes 2 nodes and merge their content|children.
        /// @param aLeftNode     The left node.  It will be deleted.
        /// @param aRightNode    The right node. It will remain after the join.
        /// @param aParent       The parent of aExistingRightNode
        ///
        /// There is no requirement that the two nodes be
        /// of the same type.  However, a text node can be
        /// merged only with another text node.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void JoinNodes([MarshalAs(UnmanagedType.Interface)] nsIDOMNode leftNode, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode rightNode, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode parent);
		
		/// <summary>
        /// deleteNode removes aChild from aParent.
        /// @param aChild    The node to delete
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode child);
		
		/// <summary>
        /// Returns true if markNodeDirty() has any effect.  Returns false if
        /// markNodeDirty() is a no-op.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool OutputsMozDirty();
		
		/// <summary>
        /// markNodeDirty() sets a special dirty attribute on the node.
        /// Usually this will be called immediately after creating a new node.
        /// @param aNode      The node for which to insert formatting.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MarkNodeDirty([MarshalAs(UnmanagedType.Interface)] nsIDOMNode node);
		
		/// <summary>
        /// Switches the editor element direction; from "Left-to-Right" to
        /// "Right-to-Left", and vice versa.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SwitchTextDirection();
		
		/// <summary>
        /// Output methods:
        /// aFormatType is a mime type, like text/plain.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OutputToString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase formatType, uint flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OutputToStream([MarshalAs(UnmanagedType.Interface)] nsIOutputStream aStream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase formatType, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase charsetOverride, uint flags);
		
		/// <summary>
        ///add an EditorObserver to the editors list of observers. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddEditorObserver([MarshalAs(UnmanagedType.Interface)] nsIEditorObserver observer);
		
		/// <summary>
        ///Remove an EditorObserver from the editor's list of observers. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveEditorObserver([MarshalAs(UnmanagedType.Interface)] nsIEditorObserver observer);
		
		/// <summary>
        ///add an EditActionListener to the editors list of listeners. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddEditActionListener([MarshalAs(UnmanagedType.Interface)] nsIEditActionListener listener);
		
		/// <summary>
        ///Remove an EditActionListener from the editor's list of listeners. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveEditActionListener([MarshalAs(UnmanagedType.Interface)] nsIEditActionListener listener);
		
		/// <summary>
        ///Add a DocumentStateListener to the editors list of doc state listeners. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddDocumentStateListener(System.IntPtr listener);
		
		/// <summary>
        ///Remove a DocumentStateListener to the editors list of doc state listeners. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveDocumentStateListener(System.IntPtr listener);
		
		/// <summary>
        /// And a debug method -- show us what the tree looks like right now
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DumpContentTree();
		
		/// <summary>
        ///Dumps a text representation of the content tree to standard out </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DebugDumpContent();
		
		/// <summary>
        ///Run unit tests. Noop in optimized builds </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DebugUnitTests(ref int outNumTests, ref int outNumTestsFailed);
		
		/// <summary>
        ///checks if a node is read-only or not </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsModifiableNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode);
		
		/// <summary>
        ///Set true if you want to suppress dispatching input event. </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetSuppressDispatchingInputEventAttribute();
		
		/// <summary>
        ///Set true if you want to suppress dispatching input event. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSuppressDispatchingInputEventAttribute([MarshalAs(UnmanagedType.U1)] bool aSuppressDispatchingInputEvent);
		
		/// <summary>
        /// True if an edit action is being handled (in other words, between calls of
        /// nsIEditorObserver::BeforeEditAction() and nsIEditorObserver::EditAction()
        /// or nsIEditorObserver::CancelEditAction().  Otherwise, false.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsInEditActionAttribute();
	}
	
	/// <summary>nsIEditorConsts </summary>
	internal class nsIEditorConsts
	{
		
		// <summary>
        //-*- Mode: C++; tab-width: 4; indent-tabs-mode: nil; c-basic-offset: 2 -*-
        //
        // This Source Code Form is subject to the terms of the Mozilla Public
        // License, v. 2.0. If a copy of the MPL was not distributed with this
        // file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		public const short eNone = 0;
		
		// 
		public const short eNext = 1;
		
		// 
		public const short ePrevious = 2;
		
		// 
		public const short eNextWord = 3;
		
		// 
		public const short ePreviousWord = 4;
		
		// 
		public const short eToBeginningOfLine = 5;
		
		// 
		public const short eToEndOfLine = 6;
		
		// 
		public const short eStrip = 0;
		
		// 
		public const short eNoStrip = 1;
	}
}
