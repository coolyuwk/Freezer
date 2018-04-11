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
// Generated by IDLImporter from file imgIContainer.idl
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
    /// imgIContainer is the interface that represents an image. It allows
    /// access to frames as Thebes surfaces. It also allows drawing of images
    /// onto Thebes contexts.
    ///
    /// Internally, imgIContainer also manages animation of images.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a8dbee24-ff86-4755-b40e-51175caf31af")]
	internal interface imgIContainer
	{
		
		/// <summary>
        /// The width of the container rectangle.  In the case of any error,
        /// zero is returned, and an exception will be thrown.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetWidthAttribute();
		
		/// <summary>
        /// The height of the container rectangle.  In the case of any error,
        /// zero is returned, and an exception will be thrown.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetHeightAttribute();
		
		/// <summary>
        /// The intrinsic size of this image in appunits. If the image has no intrinsic
        /// size in a dimension, -1 will be returned for that dimension. In the case of
        /// any error, an exception will be thrown.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetIntrinsicSizeAttribute();
		
		/// <summary>
        /// The (dimensionless) intrinsic ratio of this image. In the case of any
        /// error, an exception will be thrown.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetIntrinsicRatioAttribute();
		
		/// <summary>
        /// Given a size at which this image will be displayed, and the drawing
        /// parameters affecting how it will be drawn, returns the image size which
        /// should be used to draw to produce the highest quality result. This is the
        /// appropriate size, for example, to use as an input to the pixel snapping
        /// algorithm.
        ///
        /// For best results the size returned by this method should not be cached. It
        /// can change over time due to changes in the internal state of the image.
        ///
        /// @param aDest The size of the destination rect into which this image will be
        /// drawn, in device pixels.
        /// @param aWhichFrame Frame specifier of the FRAME_* variety.
        /// @param aFilter The filter to be used if we're scaling the image.
        /// @param aFlags Flags of the FLAG_* variety
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint OptimalImageSizeForDest(gfxSize aDest, uint aWhichFrame, System.IntPtr aFilter, uint aFlags);
		
		/// <summary>
        /// The type of this image (one of the TYPE_* values above).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetTypeAttribute();
		
		/// <summary>
        /// Whether this image is animated. You can only be guaranteed that querying
        /// this will not throw if STATUS_DECODE_COMPLETE is set on the imgIRequest.
        ///
        /// @throws NS_ERROR_NOT_AVAILABLE if the animated state cannot be determined.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAnimatedAttribute();
		
		/// <summary>
        /// Get a surface for the given frame. This may be a platform-native,
        /// optimized surface, so you cannot inspect its pixel data. If you
        /// need that, use SourceSurface::GetDataSurface.
        ///
        /// @param aWhichFrame Frame specifier of the FRAME_* variety.
        /// @param aFlags Flags of the FLAG_* variety
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetFrame(uint aWhichFrame, uint aFlags);
		
		/// <summary>
        /// Get a surface for the given frame at the specified size. Matching the
        /// requested size is best effort; it's not guaranteed that the surface you get
        /// will be a perfect match. (Some reasons you may get a surface of a different
        /// size include: if you requested upscaling, if downscale-during-decode is
        /// disabled, or if you didn't request the first frame.)
        ///
        /// @param aSize The desired size.
        /// @param aWhichFrame Frame specifier of the FRAME_* variety.
        /// @param aFlags Flags of the FLAG_* variety
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetFrameAtSize(uint aSize, uint aWhichFrame, uint aFlags);
		
		/// <summary>
        /// Whether this image is opaque (i.e., needs a background painted behind it).
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsOpaque();
		
		/// <summary>
        /// @return true if getImageContainer() is expected to return a valid
        /// ImageContainer when passed the given @Manager and @Flags
        /// parameters.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsImageContainerAvailable(System.IntPtr aManager, uint aFlags);
		
		/// <summary>
        /// Attempts to create an ImageContainer (and Image) containing the current
        /// frame.
        ///
        /// Avoid calling this unless you're actually going to layerize this image.
        ///
        /// @param aManager The LayerManager which will be used to create the
        /// ImageContainer.
        /// @param aFlags Decoding / drawing flags (in other words, FLAG_* flags).
        /// Currently only FLAG_SYNC_DECODE and FLAG_SYNC_DECODE_IF_FAST
        /// are supported.
        /// @return An ImageContainer for the current frame, or nullptr if one could
        /// not be created.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetImageContainer(System.IntPtr aManager, uint aFlags);
		
		/// <summary>
        /// Draw the requested frame of this image onto the context specified.
        ///
        /// Drawing an image involves scaling it to a certain size (which may be
        /// implemented as a "smart" scale by substituting an HQ-scaled frame or
        /// rendering at a high DPI), and then selecting a region of that image to
        /// draw. That region is drawn onto the graphics context and in the process
        /// transformed by the context matrix, which determines the final area that is
        /// filled. The basic process looks like this:
        ///
        /// +------------------+
        /// |      Image       |
        /// |                  |
        /// | intrinsic width  |
        /// |        X         |
        /// | intrinsic height |
        /// +------------------+
        /// /                    \
        /// /                      \
        /// /    (scale to aSize)    \
        /// /                          \
        /// +----------------------------+
        /// |                            |
        /// |        Scaled Image        |
        /// | aSize.width X aSize.height |
        /// |                            |
        /// |       +---------+          |
        /// |       | aRegion |          |
        /// |       +---------+          |
        /// +-------(---------(----------+
        /// |         |
        /// /           \
        /// |  (transform |
        /// /  by aContext  \
        /// |     matrix)     |
        /// /                   \
        /// +---------------------+
        /// |                     |
        /// |      Fill Rect      |
        /// |                     |
        /// +---------------------+
        ///
        /// The region may extend outside of the scaled image's boundaries. It's
        /// actually a region in tiled image space, which is formed by tiling the
        /// scaled image infinitely in every direction. Drawing with a region larger
        /// than the scaled image thus causes the filled area to contain multiple tiled
        /// copies of the image, which looks like this:
        ///
        /// ....................................................
        /// :                :                :                :
        /// :      Tile      :      Tile      :      Tile      :
        /// :        +------------[aRegion]------------+       :
        /// :........|.......:................:........|.......:
        /// :        |       :                :        |       :
        /// :      Ti|le     :  Scaled Image  :      Ti|le     :
        /// :        |       :                :        |       :
        /// :........|.......:................:........|.......:
        /// :        +---------------------------------+       :
        /// :      Ti|le     :      Tile      :      Ti|le     :
        /// :       /        :                :         \      :
        /// :......(.........:................:..........).....:
        /// |                                     |
        /// /                                       \
        /// |      (transform by aContext matrix)     |
        /// /                                           \
        /// +---------------------------------------------+
        /// |     :                                 :     |
        /// |.....:.................................:.....|
        /// |     :                                 :     |
        /// |     :           Tiled Fill            :     |
        /// |     :                                 :     |
        /// |.....:.................................:.....|
        /// |     :                                 :     |
        /// +---------------------------------------------+
        ///
        ///
        /// @param aContext The Thebes context to draw the image to.
        /// @param aSize The size to which the image should be scaled before drawing.
        /// This requirement may be satisfied using HQ scaled frames,
        /// selecting from different resolution layers, drawing at a
        /// higher DPI, or just performing additional scaling on the
        /// graphics context. Callers can use optimalImageSizeForDest()
        /// to determine the best choice for this parameter if they have
        /// no special size requirements.
        /// @param aRegion The region in tiled image space which will be drawn onto the
        /// graphics context. aRegion is in the coordinate space of the
        /// image after it has been scaled to aSize - that is, the image
        /// is scaled first, and then aRegion is applied. When aFlags
        /// includes FLAG_CLAMP, the image will be extended to this area
        /// by clamping image sample coordinates. Otherwise, the image
        /// will be automatically tiled as necessary. aRegion can also
        /// optionally contain a second region which restricts the set
        /// of pixels we're allowed to sample from when drawing; this
        /// is only of use to callers which need to draw with pixel
        /// snapping.
        /// @param aWhichFrame Frame specifier of the FRAME_* variety.
        /// @param aFilter The filter to be used if we're scaling the image.
        /// @param aSVGContext If specified, SVG-related rendering context, such as
        /// overridden attributes on the image document's root <svg>
        /// node, and the size of the viewport that the full image
        /// would occupy. Ignored for raster images.
        /// @param aFlags Flags of the FLAG_* variety
        /// @return A DrawResult value indicating whether and to what degree the
        /// drawing operation was successful.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr Draw(gfxContext aContext, uint aSize, System.IntPtr aRegion, uint aWhichFrame, System.IntPtr aFilter, System.IntPtr aSVGContext, uint aFlags);
		
		/// <summary>
        /// Ensures that an image is decoding. Calling this function guarantees that
        /// the image will at some point fire off decode notifications. Images that
        /// can be decoded "quickly" according to some heuristic will be decoded
        /// synchronously.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StartDecoding();
		
		/// <summary>
        /// This method triggers decoding for an image, but unlike startDecoding() it
        /// enables the caller to provide more detailed information about the decode
        /// request.
        ///
        /// @param aSize The size to which the image should be scaled while decoding,
        /// if possible. If the image cannot be scaled to this size while
        /// being decoded, it will be decoded at its intrinsic size.
        /// @param aFlags Flags of the FLAG_* variety. Only the decode flags
        /// (FLAG_DECODE_*) and FLAG_SYNC_DECODE (which will
        /// synchronously decode images that can be decoded "quickly",
        /// just like startDecoding() does) are accepted; others will be
        /// ignored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RequestDecodeForSize(uint aSize, uint aFlags);
		
		/// <summary>
        /// Increments the lock count on the image. An image will not be discarded
        /// as long as the lock count is nonzero. Note that it is still possible for
        /// the image to be undecoded if decode-on-draw is enabled and the image
        /// was never drawn.
        ///
        /// Upon instantiation images have a lock count of zero.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LockImage();
		
		/// <summary>
        /// Decreases the lock count on the image. If the lock count drops to zero,
        /// the image is allowed to discard its frame data to save memory.
        ///
        /// Upon instantiation images have a lock count of zero. It is an error to
        /// call this method without first having made a matching lockImage() call.
        /// In other words, the lock count is not allowed to be negative.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnlockImage();
		
		/// <summary>
        /// If this image is unlocked, discard its decoded data.  If the image is
        /// locked or has already been discarded, do nothing.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RequestDiscard();
		
		/// <summary>
        /// Indicates that this imgIContainer has been triggered to update
        /// its internal animation state. Likely this should only be called
        /// from within nsImageFrame or objects of similar type.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RequestRefresh(ulong aTime);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetAnimationModeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAnimationModeAttribute(ushort aAnimationMode);
		
		/// <summary>
        ///Methods to control animation </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResetAnimation();
		
		/// <summary>
        /// Returns an index for the requested animation frame (either FRAME_FIRST or
        /// FRAME_CURRENT).
        ///
        /// The units of the index aren't specified, and may vary between different
        /// types of images. What you can rely on is that on all occasions when
        /// getFrameIndex(FRAME_CURRENT) returns a certain value,
        /// draw(..FRAME_CURRENT..) will draw the same frame. The same holds for
        /// FRAME_FIRST as well.
        ///
        /// @param aWhichFrame Frame specifier of the FRAME_* variety.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetFrameIndex(uint aWhichFrame);
		
		/// <summary>
        /// Returns the inherent orientation of the image, as described in the image's
        /// metadata (e.g. EXIF).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetOrientation();
		
		/// <summary>
        /// Returns the delay, in ms, between the first and second frame. If this
        /// returns 0, there is no delay between first and second frame (i.e., this
        /// image could render differently whenever it draws).
        ///
        /// If this image is not animated, or not known to be animated (see attribute
        /// animated), returns -1.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetFirstFrameDelay();
		
		/// <summary>
        /// If this is an animated image that hasn't started animating already, this
        /// sets the animation's start time to the indicated time.
        ///
        /// This has no effect if the image isn't animated or it has started animating
        /// already; it also has no effect if the image format doesn't care about
        /// animation start time.
        ///
        /// In all cases, animation does not actually begin until startAnimation(),
        /// resetAnimation(), or requestRefresh() is called for the first time.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAnimationStartTime(ulong aTime);
		
		/// <summary>
        /// Given an invalidation rect in the coordinate system used by the decoder,
        /// returns an invalidation rect in image space.
        ///
        /// This is the identity transformation in most cases, but the result can
        /// differ if the image is wrapped by an ImageWrapper that changes its size
        /// or orientation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetImageSpaceInvalidationRect([MarshalAs(UnmanagedType.Interface)] nsIntRect aRect);
		
		/// <summary>
        /// Removes any ImageWrappers and returns the unwrapped base image.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr Unwrap();
		
		/// <summary>
        /// Propagate the use counters (if any) from this container to the passed in
        /// document.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PropagateUseCounters(System.IntPtr aDocument);
	}
	
	/// <summary>imgIContainerConsts </summary>
	internal class imgIContainerConsts
	{
		
		// <summary>
        // Enumerated values for the 'type' attribute (below).
        // </summary>
		public const ushort TYPE_RASTER = 0;
		
		// 
		public const ushort TYPE_VECTOR = 1;
		
		// <summary>
        // Flags for imgIContainer operations.
        //
        // Meanings:
        //
        // FLAG_NONE: Lack of flags.
        //
        // FLAG_SYNC_DECODE: Forces synchronous/non-progressive decode of all
        // available data before the call returns.
        //
        // FLAG_SYNC_DECODE_IF_FAST: Like FLAG_SYNC_DECODE, but requests a sync decode
        // be performed only if ImageLib estimates it can be completed very quickly.
        //
        // FLAG_ASYNC_NOTIFY: Send notifications asynchronously, even if we decode
        // synchronously beause of FLAG_SYNC_DECODE or FLAG_SYNC_DECODE_IF_FAST.
        //
        // FLAG_DECODE_NO_PREMULTIPLY_ALPHA: Do not premultiply alpha if
        // it's not already premultiplied in the image data.
        //
        // FLAG_DECODE_NO_COLORSPACE_CONVERSION: Do not do any colorspace conversion;
        // ignore any embedded profiles, and don't convert to any particular
        // destination space.
        //
        // FLAG_CLAMP: Extend the image to the fill area by clamping image sample
        // coordinates instead of by tiling. This only affects 'draw'.
        //
        // FLAG_HIGH_QUALITY_SCALING: A hint as to whether this image should be
        // scaled using the high quality scaler. Do not set this if not drawing to
        // a window or not listening to invalidations.
        //
        // FLAG_WANT_DATA_SURFACE: Can be passed to GetFrame when the caller wants a
        // DataSourceSurface instead of a hardware accelerated surface. This can be
        // important for performance (by avoiding an upload to/readback from the GPU)
        // when the caller knows they want a SourceSurface of type DATA.
        //
        // FLAG_BYPASS_SURFACE_CACHE: Forces drawing to happen rather than taking
        // cached rendering from the surface cache. This is used when we are printing,
        // for example, where we want the vector commands from VectorImages to end up
        // in the PDF output rather than a cached rendering at screen resolution.
        // </summary>
		public const ulong FLAG_NONE = 0x0;
		
		// 
		public const ulong FLAG_SYNC_DECODE = 0x1;
		
		// 
		public const ulong FLAG_SYNC_DECODE_IF_FAST = 0x2;
		
		// 
		public const ulong FLAG_ASYNC_NOTIFY = 0x4;
		
		// 
		public const ulong FLAG_DECODE_NO_PREMULTIPLY_ALPHA = 0x8;
		
		// 
		public const ulong FLAG_DECODE_NO_COLORSPACE_CONVERSION = 0x10;
		
		// 
		public const ulong FLAG_CLAMP = 0x20;
		
		// 
		public const ulong FLAG_HIGH_QUALITY_SCALING = 0x40;
		
		// 
		public const ulong FLAG_WANT_DATA_SURFACE = 0x80;
		
		// 
		public const ulong FLAG_BYPASS_SURFACE_CACHE = 0x100;
		
		// <summary>
        // A constant specifying the default set of decode flags (i.e., the default
        // values for FLAG_DECODE_*).
        // </summary>
		public const ulong DECODE_FLAGS_DEFAULT = 0;
		
		// <summary>
        // Constants for specifying various "special" frames.
        //
        // FRAME_FIRST: The first frame
        // FRAME_CURRENT: The current frame
        //
        // FRAME_MAX_VALUE should be set to the value of the maximum constant above,
        // as it is used for ensuring that a valid value was passed in.
        // </summary>
		public const ulong FRAME_FIRST = 0;
		
		// 
		public const ulong FRAME_CURRENT = 1;
		
		// 
		public const ulong FRAME_MAX_VALUE = 1;
		
		// <summary>
        // Animation mode Constants
        // 0 = normal
        // 1 = don't animate
        // 2 = loop once
        // </summary>
		public const short kNormalAnimMode = 0;
		
		// 
		public const short kDontAnimMode = 1;
		
		// 
		public const short kLoopOnceAnimMode = 2;
	}
}
