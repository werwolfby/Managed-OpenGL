using System;

namespace ManagedOpenGL
{
	[Flags]
	public enum AttribMask : uint
	{
		CurrentBit = 0x00000001,
		PointBit = 0x00000002,
		LineBit = 0x00000004,
		PolygonBit = 0x00000008,
		PolygonStippleBit = 0x00000010,
		PixelModeBit = 0x00000020,
		LightingBit = 0x00000040,
		FogBit = 0x00000080,
		DepthBufferBit = 0x00000100,
		AccumBufferBit = 0x00000200,
		StencilBufferBit = 0x00000400,
		ViewportBit = 0x00000800,
		TransformBit = 0x00001000,
		EnableBit = 0x00002000,
		ColorBufferBit = 0x00004000,
		HintBit = 0x00008000,
		EvalBit = 0x00010000,
		ListBit = 0x00020000,
		TextureBit = 0x00040000,
		ScissorBit = 0x00080000,
		AllAttribBits = 0xFFFFFFFF,
	}
	[Flags]
	public enum ClearBufferMask : uint
	{
		ColorBufferBit = AttribMask.ColorBufferBit,
		AccumBufferBit = AttribMask.AccumBufferBit,
		StencilBufferBit = AttribMask.StencilBufferBit,
		DepthBufferBit = AttribMask.DepthBufferBit,
	}
	[Flags]
	public enum ClientAttribMask : uint
	{
		ClientPixelStoreBit = 0x00000001,
		ClientVertexArrayBit = 0x00000002,
		ClientAllAttribBits = 0xFFFFFFFF,
	}
	public enum Boolean : uint
	{
		False = 0,
		True = 1,
	}
	public enum BeginMode : uint
	{
		Points = 0x0000,
		Lines = 0x0001,
		LineLoop = 0x0002,
		LineStrip = 0x0003,
		Triangles = 0x0004,
		TriangleStrip = 0x0005,
		TriangleFan = 0x0006,
		Quads = 0x0007,
		QuadStrip = 0x0008,
		Polygon = 0x0009,
	}
	public enum AccumOp : uint
	{
		Accum = 0x0100,
		Load = 0x0101,
		Return = 0x0102,
		Mult = 0x0103,
		Add = 0x0104,
	}
	public enum AlphaFunction : uint
	{
		Never = 0x0200,
		Less = 0x0201,
		Equal = 0x0202,
		Lequal = 0x0203,
		Greater = 0x0204,
		Notequal = 0x0205,
		Gequal = 0x0206,
		Always = 0x0207,
	}
	public enum BlendingFactorDest : uint
	{
		Zero = 0,
		One = 1,
		SrcColor = 0x0300,
		OneMinusSrcColor = 0x0301,
		SrcAlpha = 0x0302,
		OneMinusSrcAlpha = 0x0303,
		DstAlpha = 0x0304,
		OneMinusDstAlpha = 0x0305,
		ConstantColorExt = EXT_blend_color.ConstantColorExt,
		OneMinusConstantColorExt = EXT_blend_color.OneMinusConstantColorExt,
		ConstantAlphaExt = EXT_blend_color.ConstantAlphaExt,
		OneMinusConstantAlphaExt = EXT_blend_color.OneMinusConstantAlphaExt,
	}
	public enum BlendingFactorSrc : uint
	{
		Zero = BlendingFactorDest.Zero,
		One = BlendingFactorDest.One,
		DstColor = 0x0306,
		OneMinusDstColor = 0x0307,
		SrcAlphaSaturate = 0x0308,
		SrcAlpha = BlendingFactorDest.SrcAlpha,
		OneMinusSrcAlpha = BlendingFactorDest.OneMinusSrcAlpha,
		DstAlpha = BlendingFactorDest.DstAlpha,
		OneMinusDstAlpha = BlendingFactorDest.OneMinusDstAlpha,
		ConstantColorExt = EXT_blend_color.ConstantColorExt,
		OneMinusConstantColorExt = EXT_blend_color.OneMinusConstantColorExt,
		ConstantAlphaExt = EXT_blend_color.ConstantAlphaExt,
		OneMinusConstantAlphaExt = EXT_blend_color.OneMinusConstantAlphaExt,
	}
	public enum BlendEquationModeEXT : uint
	{
		LogicOp = GetPName.LogicOp,
		FuncAddExt = EXT_blend_minmax.FuncAddExt,
		MinExt = EXT_blend_minmax.MinExt,
		MaxExt = EXT_blend_minmax.MaxExt,
		FuncSubtractExt = EXT_blend_subtract.FuncSubtractExt,
		FuncReverseSubtractExt = EXT_blend_subtract.FuncReverseSubtractExt,
		AlphaMinSgix = SGIX_blend_alpha_minmax.AlphaMinSgix,
		AlphaMaxSgix = SGIX_blend_alpha_minmax.AlphaMaxSgix,
	}
	public enum ColorMaterialFace : uint
	{
		Front = DrawBufferMode.Front,
		Back = DrawBufferMode.Back,
		FrontAndBack = DrawBufferMode.FrontAndBack,
	}
	public enum ColorMaterialParameter : uint
	{
		Ambient = LightParameter.Ambient,
		Diffuse = LightParameter.Diffuse,
		Specular = LightParameter.Specular,
		Emission = MaterialParameter.Emission,
		AmbientAndDiffuse = MaterialParameter.AmbientAndDiffuse,
	}
	public enum ColorPointerType : uint
	{
		Byte = DataType.Byte,
		UnsignedByte = DataType.UnsignedByte,
		Short = DataType.Short,
		UnsignedShort = DataType.UnsignedShort,
		Int = DataType.Int,
		UnsignedInt = DataType.UnsignedInt,
		Float = DataType.Float,
		Double = DataType.Double,
	}
	public enum ColorTableParameterPNameSGI : uint
	{
		ColorTableScaleSgi = SGI_color_table.ColorTableScaleSgi,
		ColorTableBiasSgi = SGI_color_table.ColorTableBiasSgi,
	}
	public enum ColorTableTargetSGI : uint
	{
		ColorTableSgi = SGI_color_table.ColorTableSgi,
		PostConvolutionColorTableSgi = SGI_color_table.PostConvolutionColorTableSgi,
		PostColorMatrixColorTableSgi = SGI_color_table.PostColorMatrixColorTableSgi,
		ProxyColorTableSgi = SGI_color_table.ProxyColorTableSgi,
		ProxyPostConvolutionColorTableSgi = SGI_color_table.ProxyPostConvolutionColorTableSgi,
		ProxyPostColorMatrixColorTableSgi = SGI_color_table.ProxyPostColorMatrixColorTableSgi,
		TextureColorTableSgi = SGI_texture_color_table.TextureColorTableSgi,
		ProxyTextureColorTableSgi = SGI_texture_color_table.ProxyTextureColorTableSgi,
	}
	public enum ConvolutionBorderModeEXT : uint
	{
		ReduceExt = EXT_convolution.ReduceExt,
	}
	public enum ConvolutionParameterEXT : uint
	{
		ConvolutionBorderModeExt = EXT_convolution.ConvolutionBorderModeExt,
		ConvolutionFilterScaleExt = EXT_convolution.ConvolutionFilterScaleExt,
		ConvolutionFilterBiasExt = EXT_convolution.ConvolutionFilterBiasExt,
	}
	public enum ConvolutionTargetEXT : uint
	{
		Convolution1dExt = EXT_convolution.Convolution1dExt,
		Convolution2dExt = EXT_convolution.Convolution2dExt,
	}
	public enum CullFaceMode : uint
	{
		Front = DrawBufferMode.Front,
		Back = DrawBufferMode.Back,
		FrontAndBack = DrawBufferMode.FrontAndBack,
	}
	public enum DepthFunction : uint
	{
		Never = AlphaFunction.Never,
		Less = AlphaFunction.Less,
		Equal = AlphaFunction.Equal,
		Lequal = AlphaFunction.Lequal,
		Greater = AlphaFunction.Greater,
		Notequal = AlphaFunction.Notequal,
		Gequal = AlphaFunction.Gequal,
		Always = AlphaFunction.Always,
	}
	public enum DrawBufferMode : uint
	{
		None = 0,
		FrontLeft = 0x0400,
		FrontRight = 0x0401,
		BackLeft = 0x0402,
		BackRight = 0x0403,
		Front = 0x0404,
		Back = 0x0405,
		Left = 0x0406,
		Right = 0x0407,
		FrontAndBack = 0x0408,
		Aux0 = 0x0409,
		Aux1 = 0x040A,
		Aux2 = 0x040B,
		Aux3 = 0x040C,
	}
	public enum EnableCap : uint
	{
		Fog = GetPName.Fog,
		Lighting = GetPName.Lighting,
		Texture1d = GetPName.Texture1d,
		Texture2d = GetPName.Texture2d,
		LineStipple = GetPName.LineStipple,
		PolygonStipple = GetPName.PolygonStipple,
		CullFace = GetPName.CullFace,
		AlphaTest = GetPName.AlphaTest,
		Blend = GetPName.Blend,
		IndexLogicOp = GetPName.IndexLogicOp,
		ColorLogicOp = GetPName.ColorLogicOp,
		Dither = GetPName.Dither,
		StencilTest = GetPName.StencilTest,
		DepthTest = GetPName.DepthTest,
		ClipPlane0 = GetPName.ClipPlane0,
		ClipPlane1 = GetPName.ClipPlane1,
		ClipPlane2 = GetPName.ClipPlane2,
		ClipPlane3 = GetPName.ClipPlane3,
		ClipPlane4 = GetPName.ClipPlane4,
		ClipPlane5 = GetPName.ClipPlane5,
		Light0 = GetPName.Light0,
		Light1 = GetPName.Light1,
		Light2 = GetPName.Light2,
		Light3 = GetPName.Light3,
		Light4 = GetPName.Light4,
		Light5 = GetPName.Light5,
		Light6 = GetPName.Light6,
		Light7 = GetPName.Light7,
		TextureGenS = GetPName.TextureGenS,
		TextureGenT = GetPName.TextureGenT,
		TextureGenR = GetPName.TextureGenR,
		TextureGenQ = GetPName.TextureGenQ,
		Map1Vertex3 = GetPName.Map1Vertex3,
		Map1Vertex4 = GetPName.Map1Vertex4,
		Map1Color4 = GetPName.Map1Color4,
		Map1Index = GetPName.Map1Index,
		Map1Normal = GetPName.Map1Normal,
		Map1TextureCoord1 = GetPName.Map1TextureCoord1,
		Map1TextureCoord2 = GetPName.Map1TextureCoord2,
		Map1TextureCoord3 = GetPName.Map1TextureCoord3,
		Map1TextureCoord4 = GetPName.Map1TextureCoord4,
		Map2Vertex3 = GetPName.Map2Vertex3,
		Map2Vertex4 = GetPName.Map2Vertex4,
		Map2Color4 = GetPName.Map2Color4,
		Map2Index = GetPName.Map2Index,
		Map2Normal = GetPName.Map2Normal,
		Map2TextureCoord1 = GetPName.Map2TextureCoord1,
		Map2TextureCoord2 = GetPName.Map2TextureCoord2,
		Map2TextureCoord3 = GetPName.Map2TextureCoord3,
		Map2TextureCoord4 = GetPName.Map2TextureCoord4,
		PointSmooth = GetPName.PointSmooth,
		LineSmooth = GetPName.LineSmooth,
		PolygonSmooth = GetPName.PolygonSmooth,
		ScissorTest = GetPName.ScissorTest,
		ColorMaterial = GetPName.ColorMaterial,
		Normalize = GetPName.Normalize,
		AutoNormal = GetPName.AutoNormal,
		PolygonOffsetPoint = GetPName.PolygonOffsetPoint,
		PolygonOffsetLine = GetPName.PolygonOffsetLine,
		PolygonOffsetFill = GetPName.PolygonOffsetFill,
		VertexArray = GetPName.VertexArray,
		NormalArray = GetPName.NormalArray,
		ColorArray = GetPName.ColorArray,
		IndexArray = GetPName.IndexArray,
		TextureCoordArray = GetPName.TextureCoordArray,
		EdgeFlagArray = GetPName.EdgeFlagArray,
		Convolution1dExt = EXT_convolution.Convolution1dExt,
		Convolution2dExt = EXT_convolution.Convolution2dExt,
		Separable2dExt = EXT_convolution.Separable2dExt,
		HistogramExt = EXT_histogram.HistogramExt,
		MinmaxExt = EXT_histogram.MinmaxExt,
		RescaleNormalExt = EXT_rescale_normal.RescaleNormalExt,
		SharedTexturePaletteExt = EXT_shared_texture_palette.SharedTexturePaletteExt,
		Texture3dExt = EXT_texture3D.Texture3dExt,
		MultisampleSgis = SGIS_multisample.MultisampleSgis,
		SampleAlphaToMaskSgis = SGIS_multisample.SampleAlphaToMaskSgis,
		SampleAlphaToOneSgis = SGIS_multisample.SampleAlphaToOneSgis,
		SampleMaskSgis = SGIS_multisample.SampleMaskSgis,
		Texture4dSgis = SGIS_texture4D.Texture4dSgis,
		AsyncHistogramSgix = SGIX_async_histogram.AsyncHistogramSgix,
		AsyncTexImageSgix = SGIX_async_pixel.AsyncTexImageSgix,
		AsyncDrawPixelsSgix = SGIX_async_pixel.AsyncDrawPixelsSgix,
		AsyncReadPixelsSgix = SGIX_async_pixel.AsyncReadPixelsSgix,
		CalligraphicFragmentSgix = SGIX_calligraphic_fragment.CalligraphicFragmentSgix,
		FogOffsetSgix = SGIX_fog_offset.FogOffsetSgix,
		FragmentLightingSgix = SGIX_fragment_lighting.FragmentLightingSgix,
		FragmentColorMaterialSgix = SGIX_fragment_lighting.FragmentColorMaterialSgix,
		FragmentLight0Sgix = SGIX_fragment_lighting.FragmentLight0Sgix,
		FragmentLight1Sgix = SGIX_fragment_lighting.FragmentLight1Sgix,
		FragmentLight2Sgix = SGIX_fragment_lighting.FragmentLight2Sgix,
		FragmentLight3Sgix = SGIX_fragment_lighting.FragmentLight3Sgix,
		FragmentLight4Sgix = SGIX_fragment_lighting.FragmentLight4Sgix,
		FragmentLight5Sgix = SGIX_fragment_lighting.FragmentLight5Sgix,
		FragmentLight6Sgix = SGIX_fragment_lighting.FragmentLight6Sgix,
		FragmentLight7Sgix = SGIX_fragment_lighting.FragmentLight7Sgix,
		FramezoomSgix = SGIX_framezoom.FramezoomSgix,
		InterlaceSgix = SGIX_interlace.InterlaceSgix,
		IrInstrument1Sgix = SGIX_ir_instrument1.IrInstrument1Sgix,
		PixelTexGenSgix = SGIX_pixel_texture.PixelTexGenSgix,
		PixelTextureSgis = SGIS_pixel_texture.PixelTextureSgis,
		ReferencePlaneSgix = SGIX_reference_plane.ReferencePlaneSgix,
		SpriteSgix = SGIX_sprite.SpriteSgix,
		ColorTableSgi = SGI_color_table.ColorTableSgi,
		PostConvolutionColorTableSgi = SGI_color_table.PostConvolutionColorTableSgi,
		PostColorMatrixColorTableSgi = SGI_color_table.PostColorMatrixColorTableSgi,
		TextureColorTableSgi = SGI_texture_color_table.TextureColorTableSgi,
	}
	public enum ErrorCode : uint
	{
		NoError = 0,
		InvalidEnum = 0x0500,
		InvalidValue = 0x0501,
		InvalidOperation = 0x0502,
		StackOverflow = 0x0503,
		StackUnderflow = 0x0504,
		OutOfMemory = 0x0505,
		TableTooLargeExt = EXT_histogram.TableTooLargeExt,
		TextureTooLargeExt = EXT_texture.TextureTooLargeExt,
	}
	public enum FeedbackType : uint
	{
		gl2d = 0x0600,
		gl3d = 0x0601,
		gl3dColor = 0x0602,
		gl3dColorTexture = 0x0603,
		gl4dColorTexture = 0x0604,
	}
	public enum FeedBackToken : uint
	{
		PassThroughToken = 0x0700,
		PointToken = 0x0701,
		LineToken = 0x0702,
		PolygonToken = 0x0703,
		BitmapToken = 0x0704,
		DrawPixelToken = 0x0705,
		CopyPixelToken = 0x0706,
		LineResetToken = 0x0707,
	}
	[Flags]
	public enum FfdMaskSGIX : uint
	{
		TextureDeformationBitSgix = 0x00000001,
		GeometryDeformationBitSgix = 0x00000002,
	}
	public enum FfdTargetSGIX : uint
	{
		GeometryDeformationSgix = SGIX_polynomial_ffd.GeometryDeformationSgix,
		TextureDeformationSgix = SGIX_polynomial_ffd.TextureDeformationSgix,
	}
	public enum FogMode : uint
	{
		Linear = TextureMagFilter.Linear,
		Exp = 0x0800,
		Exp2 = 0x0801,
		FogFuncSgis = SGIS_fog_function.FogFuncSgis,
	}
	public enum FogParameter : uint
	{
		FogColor = GetPName.FogColor,
		FogDensity = GetPName.FogDensity,
		FogEnd = GetPName.FogEnd,
		FogIndex = GetPName.FogIndex,
		FogMode = GetPName.FogMode,
		FogStart = GetPName.FogStart,
		FogOffsetValueSgix = SGIX_fog_offset.FogOffsetValueSgix,
	}
	public enum FragmentLightModelParameterSGIX : uint
	{
		FragmentLightModelLocalViewerSgix = SGIX_fragment_lighting.FragmentLightModelLocalViewerSgix,
		FragmentLightModelTwoSideSgix = SGIX_fragment_lighting.FragmentLightModelTwoSideSgix,
		FragmentLightModelAmbientSgix = SGIX_fragment_lighting.FragmentLightModelAmbientSgix,
		FragmentLightModelNormalInterpolationSgix = SGIX_fragment_lighting.FragmentLightModelNormalInterpolationSgix,
	}
	public enum FrontFaceDirection : uint
	{
		Cw = 0x0900,
		Ccw = 0x0901,
	}
	public enum GetColorTableParameterPNameSGI : uint
	{
		ColorTableScaleSgi = SGI_color_table.ColorTableScaleSgi,
		ColorTableBiasSgi = SGI_color_table.ColorTableBiasSgi,
		ColorTableFormatSgi = SGI_color_table.ColorTableFormatSgi,
		ColorTableWidthSgi = SGI_color_table.ColorTableWidthSgi,
		ColorTableRedSizeSgi = SGI_color_table.ColorTableRedSizeSgi,
		ColorTableGreenSizeSgi = SGI_color_table.ColorTableGreenSizeSgi,
		ColorTableBlueSizeSgi = SGI_color_table.ColorTableBlueSizeSgi,
		ColorTableAlphaSizeSgi = SGI_color_table.ColorTableAlphaSizeSgi,
		ColorTableLuminanceSizeSgi = SGI_color_table.ColorTableLuminanceSizeSgi,
		ColorTableIntensitySizeSgi = SGI_color_table.ColorTableIntensitySizeSgi,
	}
	public enum GetConvolutionParameter : uint
	{
		ConvolutionBorderModeExt = EXT_convolution.ConvolutionBorderModeExt,
		ConvolutionFilterScaleExt = EXT_convolution.ConvolutionFilterScaleExt,
		ConvolutionFilterBiasExt = EXT_convolution.ConvolutionFilterBiasExt,
		ConvolutionFormatExt = EXT_convolution.ConvolutionFormatExt,
		ConvolutionWidthExt = EXT_convolution.ConvolutionWidthExt,
		ConvolutionHeightExt = EXT_convolution.ConvolutionHeightExt,
		MaxConvolutionWidthExt = EXT_convolution.MaxConvolutionWidthExt,
		MaxConvolutionHeightExt = EXT_convolution.MaxConvolutionHeightExt,
	}
	public enum GetHistogramParameterPNameEXT : uint
	{
		HistogramWidthExt = EXT_histogram.HistogramWidthExt,
		HistogramFormatExt = EXT_histogram.HistogramFormatExt,
		HistogramRedSizeExt = EXT_histogram.HistogramRedSizeExt,
		HistogramGreenSizeExt = EXT_histogram.HistogramGreenSizeExt,
		HistogramBlueSizeExt = EXT_histogram.HistogramBlueSizeExt,
		HistogramAlphaSizeExt = EXT_histogram.HistogramAlphaSizeExt,
		HistogramLuminanceSizeExt = EXT_histogram.HistogramLuminanceSizeExt,
		HistogramSinkExt = EXT_histogram.HistogramSinkExt,
	}
	public enum GetMapQuery : uint
	{
		Coeff = 0x0A00,
		Order = 0x0A01,
		Domain = 0x0A02,
	}
	public enum GetMinmaxParameterPNameEXT : uint
	{
		MinmaxFormatExt = EXT_histogram.MinmaxFormatExt,
		MinmaxSinkExt = EXT_histogram.MinmaxSinkExt,
	}
	public enum GetPixelMap : uint
	{
		PixelMapIToI = 0x0C70,
		PixelMapSToS = 0x0C71,
		PixelMapIToR = 0x0C72,
		PixelMapIToG = 0x0C73,
		PixelMapIToB = 0x0C74,
		PixelMapIToA = 0x0C75,
		PixelMapRToR = 0x0C76,
		PixelMapGToG = 0x0C77,
		PixelMapBToB = 0x0C78,
		PixelMapAToA = 0x0C79,
	}
	public enum GetPointervPName : uint
	{
		VertexArrayPointer = 0x808E,
		NormalArrayPointer = 0x808F,
		ColorArrayPointer = 0x8090,
		IndexArrayPointer = 0x8091,
		TextureCoordArrayPointer = 0x8092,
		EdgeFlagArrayPointer = 0x8093,
		FeedbackBufferPointer = 0x0DF0,
		SelectionBufferPointer = 0x0DF3,
		InstrumentBufferPointerSgix = SGIX_instruments.InstrumentBufferPointerSgix,
	}
	public enum GetPName : uint
	{
		CurrentColor = 0x0B00,
		CurrentIndex = 0x0B01,
		CurrentNormal = 0x0B02,
		CurrentTextureCoords = 0x0B03,
		CurrentRasterColor = 0x0B04,
		CurrentRasterIndex = 0x0B05,
		CurrentRasterTextureCoords = 0x0B06,
		CurrentRasterPosition = 0x0B07,
		CurrentRasterPositionValid = 0x0B08,
		CurrentRasterDistance = 0x0B09,
		PointSmooth = 0x0B10,
		PointSize = 0x0B11,
		PointSizeRange = 0x0B12,
		PointSizeGranularity = 0x0B13,
		LineSmooth = 0x0B20,
		LineWidth = 0x0B21,
		LineWidthRange = 0x0B22,
		LineWidthGranularity = 0x0B23,
		LineStipple = 0x0B24,
		LineStipplePattern = 0x0B25,
		LineStippleRepeat = 0x0B26,
		SmoothPointSizeRange = VERSION_1_2.SmoothPointSizeRange,
		SmoothPointSizeGranularity = VERSION_1_2.SmoothPointSizeGranularity,
		SmoothLineWidthRange = VERSION_1_2.SmoothLineWidthRange,
		SmoothLineWidthGranularity = VERSION_1_2.SmoothLineWidthGranularity,
		AliasedPointSizeRange = VERSION_1_2.AliasedPointSizeRange,
		AliasedLineWidthRange = VERSION_1_2.AliasedLineWidthRange,
		ListMode = 0x0B30,
		MaxListNesting = 0x0B31,
		ListBase = 0x0B32,
		ListIndex = 0x0B33,
		PolygonMode = 0x0B40,
		PolygonSmooth = 0x0B41,
		PolygonStipple = 0x0B42,
		EdgeFlag = 0x0B43,
		CullFace = 0x0B44,
		CullFaceMode = 0x0B45,
		FrontFace = 0x0B46,
		Lighting = 0x0B50,
		LightModelLocalViewer = 0x0B51,
		LightModelTwoSide = 0x0B52,
		LightModelAmbient = 0x0B53,
		ShadeModel = 0x0B54,
		ColorMaterialFace = 0x0B55,
		ColorMaterialParameter = 0x0B56,
		ColorMaterial = 0x0B57,
		Fog = 0x0B60,
		FogIndex = 0x0B61,
		FogDensity = 0x0B62,
		FogStart = 0x0B63,
		FogEnd = 0x0B64,
		FogMode = 0x0B65,
		FogColor = 0x0B66,
		DepthRange = 0x0B70,
		DepthTest = 0x0B71,
		DepthWritemask = 0x0B72,
		DepthClearValue = 0x0B73,
		DepthFunc = 0x0B74,
		AccumClearValue = 0x0B80,
		StencilTest = 0x0B90,
		StencilClearValue = 0x0B91,
		StencilFunc = 0x0B92,
		StencilValueMask = 0x0B93,
		StencilFail = 0x0B94,
		StencilPassDepthFail = 0x0B95,
		StencilPassDepthPass = 0x0B96,
		StencilRef = 0x0B97,
		StencilWritemask = 0x0B98,
		MatrixMode = 0x0BA0,
		Normalize = 0x0BA1,
		Viewport = 0x0BA2,
		ModelviewStackDepth = 0x0BA3,
		ProjectionStackDepth = 0x0BA4,
		TextureStackDepth = 0x0BA5,
		ModelviewMatrix = 0x0BA6,
		ProjectionMatrix = 0x0BA7,
		TextureMatrix = 0x0BA8,
		AttribStackDepth = 0x0BB0,
		ClientAttribStackDepth = 0x0BB1,
		AlphaTest = 0x0BC0,
		AlphaTestFunc = 0x0BC1,
		AlphaTestRef = 0x0BC2,
		Dither = 0x0BD0,
		BlendDst = 0x0BE0,
		BlendSrc = 0x0BE1,
		Blend = 0x0BE2,
		LogicOpMode = 0x0BF0,
		IndexLogicOp = 0x0BF1,
		LogicOp = 0x0BF1,
		ColorLogicOp = 0x0BF2,
		AuxBuffers = 0x0C00,
		DrawBuffer = 0x0C01,
		ReadBuffer = 0x0C02,
		ScissorBox = 0x0C10,
		ScissorTest = 0x0C11,
		IndexClearValue = 0x0C20,
		IndexWritemask = 0x0C21,
		ColorClearValue = 0x0C22,
		ColorWritemask = 0x0C23,
		IndexMode = 0x0C30,
		RgbaMode = 0x0C31,
		Doublebuffer = 0x0C32,
		Stereo = 0x0C33,
		RenderMode = 0x0C40,
		PerspectiveCorrectionHint = 0x0C50,
		PointSmoothHint = 0x0C51,
		LineSmoothHint = 0x0C52,
		PolygonSmoothHint = 0x0C53,
		FogHint = 0x0C54,
		TextureGenS = 0x0C60,
		TextureGenT = 0x0C61,
		TextureGenR = 0x0C62,
		TextureGenQ = 0x0C63,
		PixelMapIToISize = 0x0CB0,
		PixelMapSToSSize = 0x0CB1,
		PixelMapIToRSize = 0x0CB2,
		PixelMapIToGSize = 0x0CB3,
		PixelMapIToBSize = 0x0CB4,
		PixelMapIToASize = 0x0CB5,
		PixelMapRToRSize = 0x0CB6,
		PixelMapGToGSize = 0x0CB7,
		PixelMapBToBSize = 0x0CB8,
		PixelMapAToASize = 0x0CB9,
		UnpackSwapBytes = 0x0CF0,
		UnpackLsbFirst = 0x0CF1,
		UnpackRowLength = 0x0CF2,
		UnpackSkipRows = 0x0CF3,
		UnpackSkipPixels = 0x0CF4,
		UnpackAlignment = 0x0CF5,
		PackSwapBytes = 0x0D00,
		PackLsbFirst = 0x0D01,
		PackRowLength = 0x0D02,
		PackSkipRows = 0x0D03,
		PackSkipPixels = 0x0D04,
		PackAlignment = 0x0D05,
		MapColor = 0x0D10,
		MapStencil = 0x0D11,
		IndexShift = 0x0D12,
		IndexOffset = 0x0D13,
		RedScale = 0x0D14,
		RedBias = 0x0D15,
		ZoomX = 0x0D16,
		ZoomY = 0x0D17,
		GreenScale = 0x0D18,
		GreenBias = 0x0D19,
		BlueScale = 0x0D1A,
		BlueBias = 0x0D1B,
		AlphaScale = 0x0D1C,
		AlphaBias = 0x0D1D,
		DepthScale = 0x0D1E,
		DepthBias = 0x0D1F,
		MaxEvalOrder = 0x0D30,
		MaxLights = 0x0D31,
		MaxClipPlanes = 0x0D32,
		MaxTextureSize = 0x0D33,
		MaxPixelMapTable = 0x0D34,
		MaxAttribStackDepth = 0x0D35,
		MaxModelviewStackDepth = 0x0D36,
		MaxNameStackDepth = 0x0D37,
		MaxProjectionStackDepth = 0x0D38,
		MaxTextureStackDepth = 0x0D39,
		MaxViewportDims = 0x0D3A,
		MaxClientAttribStackDepth = 0x0D3B,
		SubpixelBits = 0x0D50,
		IndexBits = 0x0D51,
		RedBits = 0x0D52,
		GreenBits = 0x0D53,
		BlueBits = 0x0D54,
		AlphaBits = 0x0D55,
		DepthBits = 0x0D56,
		StencilBits = 0x0D57,
		AccumRedBits = 0x0D58,
		AccumGreenBits = 0x0D59,
		AccumBlueBits = 0x0D5A,
		AccumAlphaBits = 0x0D5B,
		NameStackDepth = 0x0D70,
		AutoNormal = 0x0D80,
		Map1Color4 = 0x0D90,
		Map1Index = 0x0D91,
		Map1Normal = 0x0D92,
		Map1TextureCoord1 = 0x0D93,
		Map1TextureCoord2 = 0x0D94,
		Map1TextureCoord3 = 0x0D95,
		Map1TextureCoord4 = 0x0D96,
		Map1Vertex3 = 0x0D97,
		Map1Vertex4 = 0x0D98,
		Map2Color4 = 0x0DB0,
		Map2Index = 0x0DB1,
		Map2Normal = 0x0DB2,
		Map2TextureCoord1 = 0x0DB3,
		Map2TextureCoord2 = 0x0DB4,
		Map2TextureCoord3 = 0x0DB5,
		Map2TextureCoord4 = 0x0DB6,
		Map2Vertex3 = 0x0DB7,
		Map2Vertex4 = 0x0DB8,
		Map1GridDomain = 0x0DD0,
		Map1GridSegments = 0x0DD1,
		Map2GridDomain = 0x0DD2,
		Map2GridSegments = 0x0DD3,
		Texture1d = 0x0DE0,
		Texture2d = 0x0DE1,
		FeedbackBufferSize = 0x0DF1,
		FeedbackBufferType = 0x0DF2,
		SelectionBufferSize = 0x0DF4,
		PolygonOffsetUnits = 0x2A00,
		PolygonOffsetPoint = 0x2A01,
		PolygonOffsetLine = 0x2A02,
		PolygonOffsetFill = 0x8037,
		PolygonOffsetFactor = 0x8038,
		TextureBinding1d = 0x8068,
		TextureBinding2d = 0x8069,
		TextureBinding3d = 0x806A,
		VertexArray = 0x8074,
		NormalArray = 0x8075,
		ColorArray = 0x8076,
		IndexArray = 0x8077,
		TextureCoordArray = 0x8078,
		EdgeFlagArray = 0x8079,
		VertexArraySize = 0x807A,
		VertexArrayType = 0x807B,
		VertexArrayStride = 0x807C,
		NormalArrayType = 0x807E,
		NormalArrayStride = 0x807F,
		ColorArraySize = 0x8081,
		ColorArrayType = 0x8082,
		ColorArrayStride = 0x8083,
		IndexArrayType = 0x8085,
		IndexArrayStride = 0x8086,
		TextureCoordArraySize = 0x8088,
		TextureCoordArrayType = 0x8089,
		TextureCoordArrayStride = 0x808A,
		EdgeFlagArrayStride = 0x808C,
		ClipPlane0 = ClipPlaneName.ClipPlane0,
		ClipPlane1 = ClipPlaneName.ClipPlane1,
		ClipPlane2 = ClipPlaneName.ClipPlane2,
		ClipPlane3 = ClipPlaneName.ClipPlane3,
		ClipPlane4 = ClipPlaneName.ClipPlane4,
		ClipPlane5 = ClipPlaneName.ClipPlane5,
		Light0 = LightName.Light0,
		Light1 = LightName.Light1,
		Light2 = LightName.Light2,
		Light3 = LightName.Light3,
		Light4 = LightName.Light4,
		Light5 = LightName.Light5,
		Light6 = LightName.Light6,
		Light7 = LightName.Light7,
		LightModelColorControl = VERSION_1_2.LightModelColorControl,
		BlendColorExt = EXT_blend_color.BlendColorExt,
		BlendEquationExt = EXT_blend_minmax.BlendEquationExt,
		PackCmykHintExt = EXT_cmyka.PackCmykHintExt,
		UnpackCmykHintExt = EXT_cmyka.UnpackCmykHintExt,
		Convolution1dExt = EXT_convolution.Convolution1dExt,
		Convolution2dExt = EXT_convolution.Convolution2dExt,
		Separable2dExt = EXT_convolution.Separable2dExt,
		PostConvolutionRedScaleExt = EXT_convolution.PostConvolutionRedScaleExt,
		PostConvolutionGreenScaleExt = EXT_convolution.PostConvolutionGreenScaleExt,
		PostConvolutionBlueScaleExt = EXT_convolution.PostConvolutionBlueScaleExt,
		PostConvolutionAlphaScaleExt = EXT_convolution.PostConvolutionAlphaScaleExt,
		PostConvolutionRedBiasExt = EXT_convolution.PostConvolutionRedBiasExt,
		PostConvolutionGreenBiasExt = EXT_convolution.PostConvolutionGreenBiasExt,
		PostConvolutionBlueBiasExt = EXT_convolution.PostConvolutionBlueBiasExt,
		PostConvolutionAlphaBiasExt = EXT_convolution.PostConvolutionAlphaBiasExt,
		HistogramExt = EXT_histogram.HistogramExt,
		MinmaxExt = EXT_histogram.MinmaxExt,
		PolygonOffsetBiasExt = EXT_polygon_offset.PolygonOffsetBiasExt,
		RescaleNormalExt = EXT_rescale_normal.RescaleNormalExt,
		SharedTexturePaletteExt = EXT_shared_texture_palette.SharedTexturePaletteExt,
		Texture3dBindingExt = EXT_texture_object.Texture3dBindingExt,
		PackSkipImagesExt = EXT_texture3D.PackSkipImagesExt,
		PackImageHeightExt = EXT_texture3D.PackImageHeightExt,
		UnpackSkipImagesExt = EXT_texture3D.UnpackSkipImagesExt,
		UnpackImageHeightExt = EXT_texture3D.UnpackImageHeightExt,
		Texture3dExt = EXT_texture3D.Texture3dExt,
		Max3dTextureSizeExt = EXT_texture3D.Max3dTextureSizeExt,
		VertexArrayCountExt = EXT_vertex_array.VertexArrayCountExt,
		NormalArrayCountExt = EXT_vertex_array.NormalArrayCountExt,
		ColorArrayCountExt = EXT_vertex_array.ColorArrayCountExt,
		IndexArrayCountExt = EXT_vertex_array.IndexArrayCountExt,
		TextureCoordArrayCountExt = EXT_vertex_array.TextureCoordArrayCountExt,
		EdgeFlagArrayCountExt = EXT_vertex_array.EdgeFlagArrayCountExt,
		DetailTexture2dBindingSgis = SGIS_detail_texture.DetailTexture2dBindingSgis,
		FogFuncPointsSgis = SGIS_fog_function.FogFuncPointsSgis,
		MaxFogFuncPointsSgis = SGIS_fog_function.MaxFogFuncPointsSgis,
		GenerateMipmapHintSgis = SGIS_generate_mipmap.GenerateMipmapHintSgis,
		MultisampleSgis = SGIS_multisample.MultisampleSgis,
		SampleAlphaToMaskSgis = SGIS_multisample.SampleAlphaToMaskSgis,
		SampleAlphaToOneSgis = SGIS_multisample.SampleAlphaToOneSgis,
		SampleMaskSgis = SGIS_multisample.SampleMaskSgis,
		SampleBuffersSgis = SGIS_multisample.SampleBuffersSgis,
		SamplesSgis = SGIS_multisample.SamplesSgis,
		SampleMaskValueSgis = SGIS_multisample.SampleMaskValueSgis,
		SampleMaskInvertSgis = SGIS_multisample.SampleMaskInvertSgis,
		SamplePatternSgis = SGIS_multisample.SamplePatternSgis,
		PixelTextureSgis = SGIS_pixel_texture.PixelTextureSgis,
		PointSizeMinSgis = SGIS_point_parameters.PointSizeMinSgis,
		PointSizeMaxSgis = SGIS_point_parameters.PointSizeMaxSgis,
		PointFadeThresholdSizeSgis = SGIS_point_parameters.PointFadeThresholdSizeSgis,
		DistanceAttenuationSgis = SGIS_point_parameters.DistanceAttenuationSgis,
		PackSkipVolumesSgis = SGIS_texture4D.PackSkipVolumesSgis,
		PackImageDepthSgis = SGIS_texture4D.PackImageDepthSgis,
		UnpackSkipVolumesSgis = SGIS_texture4D.UnpackSkipVolumesSgis,
		UnpackImageDepthSgis = SGIS_texture4D.UnpackImageDepthSgis,
		Texture4dSgis = SGIS_texture4D.Texture4dSgis,
		Max4dTextureSizeSgis = SGIS_texture4D.Max4dTextureSizeSgis,
		Texture4dBindingSgis = SGIS_texture4D.Texture4dBindingSgis,
		AsyncMarkerSgix = SGIX_async.AsyncMarkerSgix,
		AsyncHistogramSgix = SGIX_async_histogram.AsyncHistogramSgix,
		MaxAsyncHistogramSgix = SGIX_async_histogram.MaxAsyncHistogramSgix,
		AsyncTexImageSgix = SGIX_async_pixel.AsyncTexImageSgix,
		AsyncDrawPixelsSgix = SGIX_async_pixel.AsyncDrawPixelsSgix,
		AsyncReadPixelsSgix = SGIX_async_pixel.AsyncReadPixelsSgix,
		MaxAsyncTexImageSgix = SGIX_async_pixel.MaxAsyncTexImageSgix,
		MaxAsyncDrawPixelsSgix = SGIX_async_pixel.MaxAsyncDrawPixelsSgix,
		MaxAsyncReadPixelsSgix = SGIX_async_pixel.MaxAsyncReadPixelsSgix,
		CalligraphicFragmentSgix = SGIX_calligraphic_fragment.CalligraphicFragmentSgix,
		MaxClipmapVirtualDepthSgix = SGIX_clipmap.MaxClipmapVirtualDepthSgix,
		MaxClipmapDepthSgix = SGIX_clipmap.MaxClipmapDepthSgix,
		ConvolutionHintSgix = SGIX_convolution_accuracy.ConvolutionHintSgix,
		FogOffsetSgix = SGIX_fog_offset.FogOffsetSgix,
		FogOffsetValueSgix = SGIX_fog_offset.FogOffsetValueSgix,
		FragmentLightingSgix = SGIX_fragment_lighting.FragmentLightingSgix,
		FragmentColorMaterialSgix = SGIX_fragment_lighting.FragmentColorMaterialSgix,
		FragmentColorMaterialFaceSgix = SGIX_fragment_lighting.FragmentColorMaterialFaceSgix,
		FragmentColorMaterialParameterSgix = SGIX_fragment_lighting.FragmentColorMaterialParameterSgix,
		MaxFragmentLightsSgix = SGIX_fragment_lighting.MaxFragmentLightsSgix,
		MaxActiveLightsSgix = SGIX_fragment_lighting.MaxActiveLightsSgix,
		LightEnvModeSgix = SGIX_fragment_lighting.LightEnvModeSgix,
		FragmentLightModelLocalViewerSgix = SGIX_fragment_lighting.FragmentLightModelLocalViewerSgix,
		FragmentLightModelTwoSideSgix = SGIX_fragment_lighting.FragmentLightModelTwoSideSgix,
		FragmentLightModelAmbientSgix = SGIX_fragment_lighting.FragmentLightModelAmbientSgix,
		FragmentLightModelNormalInterpolationSgix = SGIX_fragment_lighting.FragmentLightModelNormalInterpolationSgix,
		FragmentLight0Sgix = SGIX_fragment_lighting.FragmentLight0Sgix,
		FramezoomSgix = SGIX_framezoom.FramezoomSgix,
		FramezoomFactorSgix = SGIX_framezoom.FramezoomFactorSgix,
		MaxFramezoomFactorSgix = SGIX_framezoom.MaxFramezoomFactorSgix,
		InstrumentMeasurementsSgix = SGIX_instruments.InstrumentMeasurementsSgix,
		InterlaceSgix = SGIX_interlace.InterlaceSgix,
		IrInstrument1Sgix = SGIX_ir_instrument1.IrInstrument1Sgix,
		PixelTexGenSgix = SGIX_pixel_texture.PixelTexGenSgix,
		PixelTexGenModeSgix = SGIX_pixel_texture.PixelTexGenModeSgix,
		PixelTileBestAlignmentSgix = SGIX_pixel_tiles.PixelTileBestAlignmentSgix,
		PixelTileCacheIncrementSgix = SGIX_pixel_tiles.PixelTileCacheIncrementSgix,
		PixelTileWidthSgix = SGIX_pixel_tiles.PixelTileWidthSgix,
		PixelTileHeightSgix = SGIX_pixel_tiles.PixelTileHeightSgix,
		PixelTileGridWidthSgix = SGIX_pixel_tiles.PixelTileGridWidthSgix,
		PixelTileGridHeightSgix = SGIX_pixel_tiles.PixelTileGridHeightSgix,
		PixelTileGridDepthSgix = SGIX_pixel_tiles.PixelTileGridDepthSgix,
		PixelTileCacheSizeSgix = SGIX_pixel_tiles.PixelTileCacheSizeSgix,
		DeformationsMaskSgix = SGIX_polynomial_ffd.DeformationsMaskSgix,
		ReferencePlaneEquationSgix = SGIX_reference_plane.ReferencePlaneEquationSgix,
		ReferencePlaneSgix = SGIX_reference_plane.ReferencePlaneSgix,
		SpriteSgix = SGIX_sprite.SpriteSgix,
		SpriteModeSgix = SGIX_sprite.SpriteModeSgix,
		SpriteAxisSgix = SGIX_sprite.SpriteAxisSgix,
		SpriteTranslationSgix = SGIX_sprite.SpriteTranslationSgix,
		PackSubsampleRateSgix = SGIX_subsample.PackSubsampleRateSgix,
		UnpackSubsampleRateSgix = SGIX_subsample.UnpackSubsampleRateSgix,
		PackResampleSgix = SGIX_resample.PackResampleSgix,
		UnpackResampleSgix = SGIX_resample.UnpackResampleSgix,
		PostTextureFilterBiasRangeSgix = SGIX_texture_scale_bias.PostTextureFilterBiasRangeSgix,
		PostTextureFilterScaleRangeSgix = SGIX_texture_scale_bias.PostTextureFilterScaleRangeSgix,
		VertexPreclipSgix = SGIX_vertex_preclip.VertexPreclipSgix,
		VertexPreclipHintSgix = SGIX_vertex_preclip.VertexPreclipHintSgix,
		ColorMatrixSgi = SGI_color_matrix.ColorMatrixSgi,
		ColorMatrixStackDepthSgi = SGI_color_matrix.ColorMatrixStackDepthSgi,
		MaxColorMatrixStackDepthSgi = SGI_color_matrix.MaxColorMatrixStackDepthSgi,
		PostColorMatrixRedScaleSgi = SGI_color_matrix.PostColorMatrixRedScaleSgi,
		PostColorMatrixGreenScaleSgi = SGI_color_matrix.PostColorMatrixGreenScaleSgi,
		PostColorMatrixBlueScaleSgi = SGI_color_matrix.PostColorMatrixBlueScaleSgi,
		PostColorMatrixAlphaScaleSgi = SGI_color_matrix.PostColorMatrixAlphaScaleSgi,
		PostColorMatrixRedBiasSgi = SGI_color_matrix.PostColorMatrixRedBiasSgi,
		PostColorMatrixGreenBiasSgi = SGI_color_matrix.PostColorMatrixGreenBiasSgi,
		PostColorMatrixBlueBiasSgi = SGI_color_matrix.PostColorMatrixBlueBiasSgi,
		PostColorMatrixAlphaBiasSgi = SGI_color_matrix.PostColorMatrixAlphaBiasSgi,
		ColorTableSgi = SGI_color_table.ColorTableSgi,
		PostConvolutionColorTableSgi = SGI_color_table.PostConvolutionColorTableSgi,
		PostColorMatrixColorTableSgi = SGI_color_table.PostColorMatrixColorTableSgi,
		TextureColorTableSgi = SGI_texture_color_table.TextureColorTableSgi,
	}
	public enum GetTextureParameter : uint
	{
		TextureMagFilter = TextureParameterName.TextureMagFilter,
		TextureMinFilter = TextureParameterName.TextureMinFilter,
		TextureWrapS = TextureParameterName.TextureWrapS,
		TextureWrapT = TextureParameterName.TextureWrapT,
		TextureWidth = 0x1000,
		TextureHeight = 0x1001,
		TextureInternalFormat = 0x1003,
		TextureComponents = 0x1003,
		TextureBorderColor = 0x1004,
		TextureBorder = 0x1005,
		TextureRedSize = 0x805C,
		TextureGreenSize = 0x805D,
		TextureBlueSize = 0x805E,
		TextureAlphaSize = 0x805F,
		TextureLuminanceSize = 0x8060,
		TextureIntensitySize = 0x8061,
		TexturePriority = 0x8066,
		TextureResident = 0x8067,
		TextureDepthExt = EXT_texture3D.TextureDepthExt,
		TextureWrapRExt = EXT_texture3D.TextureWrapRExt,
		DetailTextureLevelSgis = SGIS_detail_texture.DetailTextureLevelSgis,
		DetailTextureModeSgis = SGIS_detail_texture.DetailTextureModeSgis,
		DetailTextureFuncPointsSgis = SGIS_detail_texture.DetailTextureFuncPointsSgis,
		GenerateMipmapSgis = SGIS_generate_mipmap.GenerateMipmapSgis,
		SharpenTextureFuncPointsSgis = SGIS_sharpen_texture.SharpenTextureFuncPointsSgis,
		TextureFilter4SizeSgis = SGIS_texture_filter4.TextureFilter4SizeSgis,
		TextureMinLodSgis = SGIS_texture_lod.TextureMinLodSgis,
		TextureMaxLodSgis = SGIS_texture_lod.TextureMaxLodSgis,
		TextureBaseLevelSgis = SGIS_texture_lod.TextureBaseLevelSgis,
		TextureMaxLevelSgis = SGIS_texture_lod.TextureMaxLevelSgis,
		DualTextureSelectSgis = SGIS_texture_select.DualTextureSelectSgis,
		QuadTextureSelectSgis = SGIS_texture_select.QuadTextureSelectSgis,
		Texture4dsizeSgis = SGIS_texture4D.Texture4dsizeSgis,
		TextureWrapQSgis = SGIS_texture4D.TextureWrapQSgis,
		TextureClipmapCenterSgix = SGIX_clipmap.TextureClipmapCenterSgix,
		TextureClipmapFrameSgix = SGIX_clipmap.TextureClipmapFrameSgix,
		TextureClipmapOffsetSgix = SGIX_clipmap.TextureClipmapOffsetSgix,
		TextureClipmapVirtualDepthSgix = SGIX_clipmap.TextureClipmapVirtualDepthSgix,
		TextureClipmapLodOffsetSgix = SGIX_clipmap.TextureClipmapLodOffsetSgix,
		TextureClipmapDepthSgix = SGIX_clipmap.TextureClipmapDepthSgix,
		TextureCompareSgix = SGIX_shadow.TextureCompareSgix,
		TextureCompareOperatorSgix = SGIX_shadow.TextureCompareOperatorSgix,
		TextureLequalRSgix = SGIX_shadow.TextureLequalRSgix,
		TextureGequalRSgix = SGIX_shadow.TextureGequalRSgix,
		ShadowAmbientSgix = SGIX_shadow_ambient.ShadowAmbientSgix,
		TextureMaxClampSSgix = SGIX_texture_coordinate_clamp.TextureMaxClampSSgix,
		TextureMaxClampTSgix = SGIX_texture_coordinate_clamp.TextureMaxClampTSgix,
		TextureMaxClampRSgix = SGIX_texture_coordinate_clamp.TextureMaxClampRSgix,
		TextureLodBiasSSgix = SGIX_texture_lod_bias.TextureLodBiasSSgix,
		TextureLodBiasTSgix = SGIX_texture_lod_bias.TextureLodBiasTSgix,
		TextureLodBiasRSgix = SGIX_texture_lod_bias.TextureLodBiasRSgix,
		PostTextureFilterBiasSgix = SGIX_texture_scale_bias.PostTextureFilterBiasSgix,
		PostTextureFilterScaleSgix = SGIX_texture_scale_bias.PostTextureFilterScaleSgix,
	}
	public enum HintMode : uint
	{
		DontCare = 0x1100,
		Fastest = 0x1101,
		Nicest = 0x1102,
	}
	public enum HintTarget : uint
	{
		PerspectiveCorrectionHint = GetPName.PerspectiveCorrectionHint,
		PointSmoothHint = GetPName.PointSmoothHint,
		LineSmoothHint = GetPName.LineSmoothHint,
		PolygonSmoothHint = GetPName.PolygonSmoothHint,
		FogHint = GetPName.FogHint,
		PackCmykHintExt = EXT_cmyka.PackCmykHintExt,
		UnpackCmykHintExt = EXT_cmyka.UnpackCmykHintExt,
		GenerateMipmapHintSgis = SGIS_generate_mipmap.GenerateMipmapHintSgis,
		ConvolutionHintSgix = SGIX_convolution_accuracy.ConvolutionHintSgix,
		TextureMultiBufferHintSgix = SGIX_texture_multi_buffer.TextureMultiBufferHintSgix,
		VertexPreclipHintSgix = SGIX_vertex_preclip.VertexPreclipHintSgix,
	}
	public enum HistogramTargetEXT : uint
	{
		HistogramExt = EXT_histogram.HistogramExt,
		ProxyHistogramExt = EXT_histogram.ProxyHistogramExt,
	}
	public enum IndexPointerType : uint
	{
		Short = DataType.Short,
		Int = DataType.Int,
		Float = DataType.Float,
		Double = DataType.Double,
	}
	public enum LightEnvModeSGIX : uint
	{
		Replace = StencilOp.Replace,
		Modulate = TextureEnvMode.Modulate,
		Add = AccumOp.Add,
	}
	public enum LightEnvParameterSGIX : uint
	{
		LightEnvModeSgix = SGIX_fragment_lighting.LightEnvModeSgix,
	}
	public enum LightModelColorControl : uint
	{
		SingleColor = VERSION_1_2.SingleColor,
		SeparateSpecularColor = VERSION_1_2.SeparateSpecularColor,
	}
	public enum LightModelParameter : uint
	{
		LightModelAmbient = GetPName.LightModelAmbient,
		LightModelLocalViewer = GetPName.LightModelLocalViewer,
		LightModelTwoSide = GetPName.LightModelTwoSide,
		LightModelColorControl = VERSION_1_2.LightModelColorControl,
	}
	public enum LightParameter : uint
	{
		Ambient = 0x1200,
		Diffuse = 0x1201,
		Specular = 0x1202,
		Position = 0x1203,
		SpotDirection = 0x1204,
		SpotExponent = 0x1205,
		SpotCutoff = 0x1206,
		ConstantAttenuation = 0x1207,
		LinearAttenuation = 0x1208,
		QuadraticAttenuation = 0x1209,
	}
	public enum ListMode : uint
	{
		Compile = 0x1300,
		CompileAndExecute = 0x1301,
	}
	public enum DataType : uint
	{
		Byte = 0x1400,
		UnsignedByte = 0x1401,
		Short = 0x1402,
		UnsignedShort = 0x1403,
		Int = 0x1404,
		UnsignedInt = 0x1405,
		Float = 0x1406,
		gl2Bytes = 0x1407,
		gl3Bytes = 0x1408,
		gl4Bytes = 0x1409,
		Double = 0x140A,
		DoubleExt = 0x140A,
	}
	public enum ListNameType : uint
	{
		Byte = DataType.Byte,
		UnsignedByte = DataType.UnsignedByte,
		Short = DataType.Short,
		UnsignedShort = DataType.UnsignedShort,
		Int = DataType.Int,
		UnsignedInt = DataType.UnsignedInt,
		Float = DataType.Float,
		gl2Bytes = DataType.gl2Bytes,
		gl3Bytes = DataType.gl3Bytes,
		gl4Bytes = DataType.gl4Bytes,
	}
	public enum ListParameterName : uint
	{
		ListPrioritySgix = SGIX_list_priority.ListPrioritySgix,
	}
	public enum LogicOp : uint
	{
		Clear = 0x1500,
		And = 0x1501,
		AndReverse = 0x1502,
		Copy = 0x1503,
		AndInverted = 0x1504,
		Noop = 0x1505,
		Xor = 0x1506,
		Or = 0x1507,
		Nor = 0x1508,
		Equiv = 0x1509,
		Invert = 0x150A,
		OrReverse = 0x150B,
		CopyInverted = 0x150C,
		OrInverted = 0x150D,
		Nand = 0x150E,
		Set = 0x150F,
	}
	public enum MapTarget : uint
	{
		Map1Color4 = GetPName.Map1Color4,
		Map1Index = GetPName.Map1Index,
		Map1Normal = GetPName.Map1Normal,
		Map1TextureCoord1 = GetPName.Map1TextureCoord1,
		Map1TextureCoord2 = GetPName.Map1TextureCoord2,
		Map1TextureCoord3 = GetPName.Map1TextureCoord3,
		Map1TextureCoord4 = GetPName.Map1TextureCoord4,
		Map1Vertex3 = GetPName.Map1Vertex3,
		Map1Vertex4 = GetPName.Map1Vertex4,
		Map2Color4 = GetPName.Map2Color4,
		Map2Index = GetPName.Map2Index,
		Map2Normal = GetPName.Map2Normal,
		Map2TextureCoord1 = GetPName.Map2TextureCoord1,
		Map2TextureCoord2 = GetPName.Map2TextureCoord2,
		Map2TextureCoord3 = GetPName.Map2TextureCoord3,
		Map2TextureCoord4 = GetPName.Map2TextureCoord4,
		Map2Vertex3 = GetPName.Map2Vertex3,
		Map2Vertex4 = GetPName.Map2Vertex4,
		GeometryDeformationSgix = SGIX_polynomial_ffd.GeometryDeformationSgix,
		TextureDeformationSgix = SGIX_polynomial_ffd.TextureDeformationSgix,
	}
	public enum MaterialFace : uint
	{
		Front = DrawBufferMode.Front,
		Back = DrawBufferMode.Back,
		FrontAndBack = DrawBufferMode.FrontAndBack,
	}
	public enum MaterialParameter : uint
	{
		Emission = 0x1600,
		Shininess = 0x1601,
		AmbientAndDiffuse = 0x1602,
		ColorIndexes = 0x1603,
		Ambient = LightParameter.Ambient,
		Diffuse = LightParameter.Diffuse,
		Specular = LightParameter.Specular,
	}
	public enum MatrixMode : uint
	{
		Modelview = 0x1700,
		Projection = 0x1701,
		Texture = 0x1702,
	}
	public enum MeshMode1 : uint
	{
		Point = PolygonMode.Point,
		Line = PolygonMode.Line,
	}
	public enum MeshMode2 : uint
	{
		Point = PolygonMode.Point,
		Line = PolygonMode.Line,
		Fill = PolygonMode.Fill,
	}
	public enum MinmaxTargetEXT : uint
	{
		MinmaxExt = EXT_histogram.MinmaxExt,
	}
	public enum NormalPointerType : uint
	{
		Byte = DataType.Byte,
		Short = DataType.Short,
		Int = DataType.Int,
		Float = DataType.Float,
		Double = DataType.Double,
	}
	public enum PixelCopyType : uint
	{
		Color = 0x1800,
		Depth = 0x1801,
		Stencil = 0x1802,
	}
	public enum PixelFormat : uint
	{
		ColorIndex = 0x1900,
		StencilIndex = 0x1901,
		DepthComponent = 0x1902,
		Red = 0x1903,
		Green = 0x1904,
		Blue = 0x1905,
		Alpha = 0x1906,
		Rgb = 0x1907,
		Rgba = 0x1908,
		Luminance = 0x1909,
		LuminanceAlpha = 0x190A,
		AbgrExt = EXT_abgr.AbgrExt,
		CmykExt = EXT_cmyka.CmykExt,
		CmykaExt = EXT_cmyka.CmykaExt,
		Ycrcb422Sgix = SGIX_ycrcb.Ycrcb422Sgix,
		Ycrcb444Sgix = SGIX_ycrcb.Ycrcb444Sgix,
	}
	public enum PixelMap : uint
	{
		PixelMapIToI = GetPixelMap.PixelMapIToI,
		PixelMapSToS = GetPixelMap.PixelMapSToS,
		PixelMapIToR = GetPixelMap.PixelMapIToR,
		PixelMapIToG = GetPixelMap.PixelMapIToG,
		PixelMapIToB = GetPixelMap.PixelMapIToB,
		PixelMapIToA = GetPixelMap.PixelMapIToA,
		PixelMapRToR = GetPixelMap.PixelMapRToR,
		PixelMapGToG = GetPixelMap.PixelMapGToG,
		PixelMapBToB = GetPixelMap.PixelMapBToB,
		PixelMapAToA = GetPixelMap.PixelMapAToA,
	}
	public enum PixelStoreParameter : uint
	{
		UnpackSwapBytes = GetPName.UnpackSwapBytes,
		UnpackLsbFirst = GetPName.UnpackLsbFirst,
		UnpackRowLength = GetPName.UnpackRowLength,
		UnpackSkipRows = GetPName.UnpackSkipRows,
		UnpackSkipPixels = GetPName.UnpackSkipPixels,
		UnpackAlignment = GetPName.UnpackAlignment,
		PackSwapBytes = GetPName.PackSwapBytes,
		PackLsbFirst = GetPName.PackLsbFirst,
		PackRowLength = GetPName.PackRowLength,
		PackSkipRows = GetPName.PackSkipRows,
		PackSkipPixels = GetPName.PackSkipPixels,
		PackAlignment = GetPName.PackAlignment,
		PackSkipImagesExt = EXT_texture3D.PackSkipImagesExt,
		PackImageHeightExt = EXT_texture3D.PackImageHeightExt,
		UnpackSkipImagesExt = EXT_texture3D.UnpackSkipImagesExt,
		UnpackImageHeightExt = EXT_texture3D.UnpackImageHeightExt,
		PackSkipVolumesSgis = SGIS_texture4D.PackSkipVolumesSgis,
		PackImageDepthSgis = SGIS_texture4D.PackImageDepthSgis,
		UnpackSkipVolumesSgis = SGIS_texture4D.UnpackSkipVolumesSgis,
		UnpackImageDepthSgis = SGIS_texture4D.UnpackImageDepthSgis,
		PixelTileWidthSgix = SGIX_pixel_tiles.PixelTileWidthSgix,
		PixelTileHeightSgix = SGIX_pixel_tiles.PixelTileHeightSgix,
		PixelTileGridWidthSgix = SGIX_pixel_tiles.PixelTileGridWidthSgix,
		PixelTileGridHeightSgix = SGIX_pixel_tiles.PixelTileGridHeightSgix,
		PixelTileGridDepthSgix = SGIX_pixel_tiles.PixelTileGridDepthSgix,
		PixelTileCacheSizeSgix = SGIX_pixel_tiles.PixelTileCacheSizeSgix,
		PackSubsampleRateSgix = SGIX_subsample.PackSubsampleRateSgix,
		UnpackSubsampleRateSgix = SGIX_subsample.UnpackSubsampleRateSgix,
		PackResampleSgix = SGIX_resample.PackResampleSgix,
		UnpackResampleSgix = SGIX_resample.UnpackResampleSgix,
	}
	public enum PixelStoreResampleMode : uint
	{
		ResampleReplicateSgix = SGIX_resample.ResampleReplicateSgix,
		ResampleZeroFillSgix = SGIX_resample.ResampleZeroFillSgix,
		ResampleDecimateSgix = SGIX_resample.ResampleDecimateSgix,
	}
	public enum PixelStoreSubsampleRate : uint
	{
		PixelSubsample4444Sgix = SGIX_subsample.PixelSubsample4444Sgix,
		PixelSubsample2424Sgix = SGIX_subsample.PixelSubsample2424Sgix,
		PixelSubsample4242Sgix = SGIX_subsample.PixelSubsample4242Sgix,
	}
	public enum PixelTexGenMode : uint
	{
		None = DrawBufferMode.None,
		Rgb = PixelFormat.Rgb,
		Rgba = PixelFormat.Rgba,
		Luminance = PixelFormat.Luminance,
		LuminanceAlpha = PixelFormat.LuminanceAlpha,
		PixelTexGenAlphaReplaceSgix = SGIX_impact_pixel_texture.PixelTexGenAlphaReplaceSgix,
		PixelTexGenAlphaNoReplaceSgix = SGIX_impact_pixel_texture.PixelTexGenAlphaNoReplaceSgix,
		PixelTexGenAlphaMsSgix = SGIX_impact_pixel_texture.PixelTexGenAlphaMsSgix,
		PixelTexGenAlphaLsSgix = SGIX_impact_pixel_texture.PixelTexGenAlphaLsSgix,
	}
	public enum PixelTexGenParameterNameSGIS : uint
	{
		PixelFragmentRgbSourceSgis = SGIS_pixel_texture.PixelFragmentRgbSourceSgis,
		PixelFragmentAlphaSourceSgis = SGIS_pixel_texture.PixelFragmentAlphaSourceSgis,
	}
	public enum PixelTransferParameter : uint
	{
		MapColor = GetPName.MapColor,
		MapStencil = GetPName.MapStencil,
		IndexShift = GetPName.IndexShift,
		IndexOffset = GetPName.IndexOffset,
		RedScale = GetPName.RedScale,
		RedBias = GetPName.RedBias,
		GreenScale = GetPName.GreenScale,
		GreenBias = GetPName.GreenBias,
		BlueScale = GetPName.BlueScale,
		BlueBias = GetPName.BlueBias,
		AlphaScale = GetPName.AlphaScale,
		AlphaBias = GetPName.AlphaBias,
		DepthScale = GetPName.DepthScale,
		DepthBias = GetPName.DepthBias,
		PostConvolutionRedScaleExt = EXT_convolution.PostConvolutionRedScaleExt,
		PostConvolutionGreenScaleExt = EXT_convolution.PostConvolutionGreenScaleExt,
		PostConvolutionBlueScaleExt = EXT_convolution.PostConvolutionBlueScaleExt,
		PostConvolutionAlphaScaleExt = EXT_convolution.PostConvolutionAlphaScaleExt,
		PostConvolutionRedBiasExt = EXT_convolution.PostConvolutionRedBiasExt,
		PostConvolutionGreenBiasExt = EXT_convolution.PostConvolutionGreenBiasExt,
		PostConvolutionBlueBiasExt = EXT_convolution.PostConvolutionBlueBiasExt,
		PostConvolutionAlphaBiasExt = EXT_convolution.PostConvolutionAlphaBiasExt,
		PostColorMatrixRedScaleSgi = SGI_color_matrix.PostColorMatrixRedScaleSgi,
		PostColorMatrixGreenScaleSgi = SGI_color_matrix.PostColorMatrixGreenScaleSgi,
		PostColorMatrixBlueScaleSgi = SGI_color_matrix.PostColorMatrixBlueScaleSgi,
		PostColorMatrixAlphaScaleSgi = SGI_color_matrix.PostColorMatrixAlphaScaleSgi,
		PostColorMatrixRedBiasSgi = SGI_color_matrix.PostColorMatrixRedBiasSgi,
		PostColorMatrixGreenBiasSgi = SGI_color_matrix.PostColorMatrixGreenBiasSgi,
		PostColorMatrixBlueBiasSgi = SGI_color_matrix.PostColorMatrixBlueBiasSgi,
		PostColorMatrixAlphaBiasSgi = SGI_color_matrix.PostColorMatrixAlphaBiasSgi,
	}
	public enum PixelType : uint
	{
		Bitmap = 0x1A00,
		Byte = DataType.Byte,
		UnsignedByte = DataType.UnsignedByte,
		Short = DataType.Short,
		UnsignedShort = DataType.UnsignedShort,
		Int = DataType.Int,
		UnsignedInt = DataType.UnsignedInt,
		Float = DataType.Float,
		UnsignedByte332Ext = EXT_packed_pixels.UnsignedByte332Ext,
		UnsignedShort4444Ext = EXT_packed_pixels.UnsignedShort4444Ext,
		UnsignedShort5551Ext = EXT_packed_pixels.UnsignedShort5551Ext,
		UnsignedInt8888Ext = EXT_packed_pixels.UnsignedInt8888Ext,
		UnsignedInt1010102Ext = EXT_packed_pixels.UnsignedInt1010102Ext,
	}
	public enum PointParameterNameSGIS : uint
	{
		PointSizeMinSgis = SGIS_point_parameters.PointSizeMinSgis,
		PointSizeMaxSgis = SGIS_point_parameters.PointSizeMaxSgis,
		PointFadeThresholdSizeSgis = SGIS_point_parameters.PointFadeThresholdSizeSgis,
		DistanceAttenuationSgis = SGIS_point_parameters.DistanceAttenuationSgis,
	}
	public enum PolygonMode : uint
	{
		Point = 0x1B00,
		Line = 0x1B01,
		Fill = 0x1B02,
	}
	public enum ReadBufferMode : uint
	{
		FrontLeft = DrawBufferMode.FrontLeft,
		FrontRight = DrawBufferMode.FrontRight,
		BackLeft = DrawBufferMode.BackLeft,
		BackRight = DrawBufferMode.BackRight,
		Front = DrawBufferMode.Front,
		Back = DrawBufferMode.Back,
		Left = DrawBufferMode.Left,
		Right = DrawBufferMode.Right,
		Aux0 = DrawBufferMode.Aux0,
		Aux1 = DrawBufferMode.Aux1,
		Aux2 = DrawBufferMode.Aux2,
		Aux3 = DrawBufferMode.Aux3,
	}
	public enum RenderingMode : uint
	{
		Render = 0x1C00,
		Feedback = 0x1C01,
		Select = 0x1C02,
	}
	public enum SamplePatternSGIS : uint
	{
		gl1passSgis = SGIS_multisample.gl1passSgis,
		gl2pass0Sgis = SGIS_multisample.gl2pass0Sgis,
		gl2pass1Sgis = SGIS_multisample.gl2pass1Sgis,
		gl4pass0Sgis = SGIS_multisample.gl4pass0Sgis,
		gl4pass1Sgis = SGIS_multisample.gl4pass1Sgis,
		gl4pass2Sgis = SGIS_multisample.gl4pass2Sgis,
		gl4pass3Sgis = SGIS_multisample.gl4pass3Sgis,
	}
	public enum SeparableTargetEXT : uint
	{
		Separable2dExt = EXT_convolution.Separable2dExt,
	}
	public enum ShadingModel : uint
	{
		Flat = 0x1D00,
		Smooth = 0x1D01,
	}
	public enum StencilFunction : uint
	{
		Never = AlphaFunction.Never,
		Less = AlphaFunction.Less,
		Equal = AlphaFunction.Equal,
		Lequal = AlphaFunction.Lequal,
		Greater = AlphaFunction.Greater,
		Notequal = AlphaFunction.Notequal,
		Gequal = AlphaFunction.Gequal,
		Always = AlphaFunction.Always,
	}
	public enum StencilOp : uint
	{
		Zero = BlendingFactorDest.Zero,
		Keep = 0x1E00,
		Replace = 0x1E01,
		Incr = 0x1E02,
		Decr = 0x1E03,
		Invert = LogicOp.Invert,
	}
	public enum StringName : uint
	{
		Vendor = 0x1F00,
		Renderer = 0x1F01,
		Version = 0x1F02,
		Extensions = 0x1F03,
	}
	public enum TexCoordPointerType : uint
	{
		Short = DataType.Short,
		Int = DataType.Int,
		Float = DataType.Float,
		Double = DataType.Double,
	}
	public enum TextureCoordName : uint
	{
		S = 0x2000,
		T = 0x2001,
		R = 0x2002,
		Q = 0x2003,
	}
	public enum TextureEnvMode : uint
	{
		Modulate = 0x2100,
		Decal = 0x2101,
		Blend = GetPName.Blend,
		ReplaceExt = EXT_texture.ReplaceExt,
		Add = AccumOp.Add,
		TextureEnvBiasSgix = SGIX_texture_add_env.TextureEnvBiasSgix,
	}
	public enum TextureEnvParameter : uint
	{
		TextureEnvMode = 0x2200,
		TextureEnvColor = 0x2201,
	}
	public enum TextureEnvTarget : uint
	{
		TextureEnv = 0x2300,
	}
	public enum TextureFilterFuncSGIS : uint
	{
		Filter4Sgis = SGIS_texture_filter4.Filter4Sgis,
	}
	public enum TextureGenMode : uint
	{
		EyeLinear = 0x2400,
		ObjectLinear = 0x2401,
		SphereMap = 0x2402,
		EyeDistanceToPointSgis = SGIS_point_line_texgen.EyeDistanceToPointSgis,
		ObjectDistanceToPointSgis = SGIS_point_line_texgen.ObjectDistanceToPointSgis,
		EyeDistanceToLineSgis = SGIS_point_line_texgen.EyeDistanceToLineSgis,
		ObjectDistanceToLineSgis = SGIS_point_line_texgen.ObjectDistanceToLineSgis,
	}
	public enum TextureGenParameter : uint
	{
		TextureGenMode = 0x2500,
		ObjectPlane = 0x2501,
		EyePlane = 0x2502,
		EyePointSgis = SGIS_point_line_texgen.EyePointSgis,
		ObjectPointSgis = SGIS_point_line_texgen.ObjectPointSgis,
		EyeLineSgis = SGIS_point_line_texgen.EyeLineSgis,
		ObjectLineSgis = SGIS_point_line_texgen.ObjectLineSgis,
	}
	public enum TextureMagFilter : uint
	{
		Nearest = 0x2600,
		Linear = 0x2601,
		LinearDetailSgis = SGIS_detail_texture.LinearDetailSgis,
		LinearDetailAlphaSgis = SGIS_detail_texture.LinearDetailAlphaSgis,
		LinearDetailColorSgis = SGIS_detail_texture.LinearDetailColorSgis,
		LinearSharpenSgis = SGIS_sharpen_texture.LinearSharpenSgis,
		LinearSharpenAlphaSgis = SGIS_sharpen_texture.LinearSharpenAlphaSgis,
		LinearSharpenColorSgis = SGIS_sharpen_texture.LinearSharpenColorSgis,
		Filter4Sgis = SGIS_texture_filter4.Filter4Sgis,
		PixelTexGenQCeilingSgix = SGIX_impact_pixel_texture.PixelTexGenQCeilingSgix,
		PixelTexGenQRoundSgix = SGIX_impact_pixel_texture.PixelTexGenQRoundSgix,
		PixelTexGenQFloorSgix = SGIX_impact_pixel_texture.PixelTexGenQFloorSgix,
	}
	public enum TextureMinFilter : uint
	{
		Nearest = TextureMagFilter.Nearest,
		Linear = TextureMagFilter.Linear,
		NearestMipmapNearest = 0x2700,
		LinearMipmapNearest = 0x2701,
		NearestMipmapLinear = 0x2702,
		LinearMipmapLinear = 0x2703,
		Filter4Sgis = SGIS_texture_filter4.Filter4Sgis,
		LinearClipmapLinearSgix = SGIX_clipmap.LinearClipmapLinearSgix,
		NearestClipmapNearestSgix = SGIX_clipmap.NearestClipmapNearestSgix,
		NearestClipmapLinearSgix = SGIX_clipmap.NearestClipmapLinearSgix,
		LinearClipmapNearestSgix = SGIX_clipmap.LinearClipmapNearestSgix,
		PixelTexGenQCeilingSgix = SGIX_impact_pixel_texture.PixelTexGenQCeilingSgix,
		PixelTexGenQRoundSgix = SGIX_impact_pixel_texture.PixelTexGenQRoundSgix,
		PixelTexGenQFloorSgix = SGIX_impact_pixel_texture.PixelTexGenQFloorSgix,
	}
	public enum TextureParameterName : uint
	{
		TextureMagFilter = 0x2800,
		TextureMinFilter = 0x2801,
		TextureWrapS = 0x2802,
		TextureWrapT = 0x2803,
		TextureBorderColor = GetTextureParameter.TextureBorderColor,
		TexturePriority = GetTextureParameter.TexturePriority,
		TextureWrapRExt = EXT_texture3D.TextureWrapRExt,
		DetailTextureLevelSgis = SGIS_detail_texture.DetailTextureLevelSgis,
		DetailTextureModeSgis = SGIS_detail_texture.DetailTextureModeSgis,
		GenerateMipmapSgis = SGIS_generate_mipmap.GenerateMipmapSgis,
		DualTextureSelectSgis = SGIS_texture_select.DualTextureSelectSgis,
		QuadTextureSelectSgis = SGIS_texture_select.QuadTextureSelectSgis,
		TextureWrapQSgis = SGIS_texture4D.TextureWrapQSgis,
		TextureClipmapCenterSgix = SGIX_clipmap.TextureClipmapCenterSgix,
		TextureClipmapFrameSgix = SGIX_clipmap.TextureClipmapFrameSgix,
		TextureClipmapOffsetSgix = SGIX_clipmap.TextureClipmapOffsetSgix,
		TextureClipmapVirtualDepthSgix = SGIX_clipmap.TextureClipmapVirtualDepthSgix,
		TextureClipmapLodOffsetSgix = SGIX_clipmap.TextureClipmapLodOffsetSgix,
		TextureClipmapDepthSgix = SGIX_clipmap.TextureClipmapDepthSgix,
		TextureCompareSgix = SGIX_shadow.TextureCompareSgix,
		TextureCompareOperatorSgix = SGIX_shadow.TextureCompareOperatorSgix,
		ShadowAmbientSgix = SGIX_shadow_ambient.ShadowAmbientSgix,
		TextureMaxClampSSgix = SGIX_texture_coordinate_clamp.TextureMaxClampSSgix,
		TextureMaxClampTSgix = SGIX_texture_coordinate_clamp.TextureMaxClampTSgix,
		TextureMaxClampRSgix = SGIX_texture_coordinate_clamp.TextureMaxClampRSgix,
		TextureLodBiasSSgix = SGIX_texture_lod_bias.TextureLodBiasSSgix,
		TextureLodBiasTSgix = SGIX_texture_lod_bias.TextureLodBiasTSgix,
		TextureLodBiasRSgix = SGIX_texture_lod_bias.TextureLodBiasRSgix,
		PostTextureFilterBiasSgix = SGIX_texture_scale_bias.PostTextureFilterBiasSgix,
		PostTextureFilterScaleSgix = SGIX_texture_scale_bias.PostTextureFilterScaleSgix,
	}
	public enum TextureTarget : uint
	{
		Texture1d = GetPName.Texture1d,
		Texture2d = GetPName.Texture2d,
		ProxyTexture1d = 0x8063,
		ProxyTexture2d = 0x8064,
		Texture3dExt = EXT_texture3D.Texture3dExt,
		ProxyTexture3dExt = EXT_texture3D.ProxyTexture3dExt,
		DetailTexture2dSgis = SGIS_detail_texture.DetailTexture2dSgis,
		Texture4dSgis = SGIS_texture4D.Texture4dSgis,
		ProxyTexture4dSgis = SGIS_texture4D.ProxyTexture4dSgis,
		TextureMinLodSgis = SGIS_texture_lod.TextureMinLodSgis,
		TextureMaxLodSgis = SGIS_texture_lod.TextureMaxLodSgis,
		TextureBaseLevelSgis = SGIS_texture_lod.TextureBaseLevelSgis,
		TextureMaxLevelSgis = SGIS_texture_lod.TextureMaxLevelSgis,
	}
	public enum TextureWrapMode : uint
	{
		Clamp = 0x2900,
		Repeat = 0x2901,
		ClampToBorderSgis = SGIS_texture_border_clamp.ClampToBorderSgis,
		ClampToEdgeSgis = SGIS_texture_edge_clamp.ClampToEdgeSgis,
	}
	public enum PixelInternalFormat : uint
	{
		R3G3B2 = 0x2A10,
		Alpha4 = 0x803B,
		Alpha8 = 0x803C,
		Alpha12 = 0x803D,
		Alpha16 = 0x803E,
		Luminance4 = 0x803F,
		Luminance8 = 0x8040,
		Luminance12 = 0x8041,
		Luminance16 = 0x8042,
		Luminance4Alpha4 = 0x8043,
		Luminance6Alpha2 = 0x8044,
		Luminance8Alpha8 = 0x8045,
		Luminance12Alpha4 = 0x8046,
		Luminance12Alpha12 = 0x8047,
		Luminance16Alpha16 = 0x8048,
		Intensity = 0x8049,
		Intensity4 = 0x804A,
		Intensity8 = 0x804B,
		Intensity12 = 0x804C,
		Intensity16 = 0x804D,
		Rgb4 = 0x804F,
		Rgb5 = 0x8050,
		Rgb8 = 0x8051,
		Rgb10 = 0x8052,
		Rgb12 = 0x8053,
		Rgb16 = 0x8054,
		Rgba2 = 0x8055,
		Rgba4 = 0x8056,
		Rgb5A1 = 0x8057,
		Rgba8 = 0x8058,
		Rgb10A2 = 0x8059,
		Rgba12 = 0x805A,
		Rgba16 = 0x805B,
		Rgb2Ext = EXT_texture.Rgb2Ext,
		DualAlpha4Sgis = SGIS_texture_select.DualAlpha4Sgis,
		DualAlpha8Sgis = SGIS_texture_select.DualAlpha8Sgis,
		DualAlpha12Sgis = SGIS_texture_select.DualAlpha12Sgis,
		DualAlpha16Sgis = SGIS_texture_select.DualAlpha16Sgis,
		DualLuminance4Sgis = SGIS_texture_select.DualLuminance4Sgis,
		DualLuminance8Sgis = SGIS_texture_select.DualLuminance8Sgis,
		DualLuminance12Sgis = SGIS_texture_select.DualLuminance12Sgis,
		DualLuminance16Sgis = SGIS_texture_select.DualLuminance16Sgis,
		DualIntensity4Sgis = SGIS_texture_select.DualIntensity4Sgis,
		DualIntensity8Sgis = SGIS_texture_select.DualIntensity8Sgis,
		DualIntensity12Sgis = SGIS_texture_select.DualIntensity12Sgis,
		DualIntensity16Sgis = SGIS_texture_select.DualIntensity16Sgis,
		DualLuminanceAlpha4Sgis = SGIS_texture_select.DualLuminanceAlpha4Sgis,
		DualLuminanceAlpha8Sgis = SGIS_texture_select.DualLuminanceAlpha8Sgis,
		QuadAlpha4Sgis = SGIS_texture_select.QuadAlpha4Sgis,
		QuadAlpha8Sgis = SGIS_texture_select.QuadAlpha8Sgis,
		QuadLuminance4Sgis = SGIS_texture_select.QuadLuminance4Sgis,
		QuadLuminance8Sgis = SGIS_texture_select.QuadLuminance8Sgis,
		QuadIntensity4Sgis = SGIS_texture_select.QuadIntensity4Sgis,
		QuadIntensity8Sgis = SGIS_texture_select.QuadIntensity8Sgis,
		DepthComponent16Sgix = SGIX_depth_texture.DepthComponent16Sgix,
		DepthComponent24Sgix = SGIX_depth_texture.DepthComponent24Sgix,
		DepthComponent32Sgix = SGIX_depth_texture.DepthComponent32Sgix,
	}
	public enum InterleavedArrayFormat : uint
	{
		V2f = 0x2A20,
		V3f = 0x2A21,
		C4ubV2f = 0x2A22,
		C4ubV3f = 0x2A23,
		C3fV3f = 0x2A24,
		N3fV3f = 0x2A25,
		C4fN3fV3f = 0x2A26,
		T2fV3f = 0x2A27,
		T4fV4f = 0x2A28,
		T2fC4ubV3f = 0x2A29,
		T2fC3fV3f = 0x2A2A,
		T2fN3fV3f = 0x2A2B,
		T2fC4fN3fV3f = 0x2A2C,
		T4fC4fN3fV4f = 0x2A2D,
	}
	public enum VertexPointerType : uint
	{
		Short = DataType.Short,
		Int = DataType.Int,
		Float = DataType.Float,
		Double = DataType.Double,
	}
	public enum ClipPlaneName : uint
	{
		ClipPlane0 = 0x3000,
		ClipPlane1 = 0x3001,
		ClipPlane2 = 0x3002,
		ClipPlane3 = 0x3003,
		ClipPlane4 = 0x3004,
		ClipPlane5 = 0x3005,
	}
	public enum LightName : uint
	{
		Light0 = 0x4000,
		Light1 = 0x4001,
		Light2 = 0x4002,
		Light3 = 0x4003,
		Light4 = 0x4004,
		Light5 = 0x4005,
		Light6 = 0x4006,
		Light7 = 0x4007,
		FragmentLight0Sgix = SGIX_fragment_lighting.FragmentLight0Sgix,
		FragmentLight1Sgix = SGIX_fragment_lighting.FragmentLight1Sgix,
		FragmentLight2Sgix = SGIX_fragment_lighting.FragmentLight2Sgix,
		FragmentLight3Sgix = SGIX_fragment_lighting.FragmentLight3Sgix,
		FragmentLight4Sgix = SGIX_fragment_lighting.FragmentLight4Sgix,
		FragmentLight5Sgix = SGIX_fragment_lighting.FragmentLight5Sgix,
		FragmentLight6Sgix = SGIX_fragment_lighting.FragmentLight6Sgix,
		FragmentLight7Sgix = SGIX_fragment_lighting.FragmentLight7Sgix,
	}
	public enum EXT_abgr : uint
	{
		AbgrExt = 0x8000,
	}
	public enum EXT_blend_color : uint
	{
		ConstantColor = 0x8001,
		ConstantColorExt = 0x8001,
		OneMinusConstantColor = 0x8002,
		OneMinusConstantColorExt = 0x8002,
		ConstantAlpha = 0x8003,
		ConstantAlphaExt = 0x8003,
		OneMinusConstantAlpha = 0x8004,
		OneMinusConstantAlphaExt = 0x8004,
		BlendColor = 0x8005,
		BlendColorExt = 0x8005,
	}
	public enum EXT_blend_minmax : uint
	{
		FuncAdd = 0x8006,
		FuncAddExt = 0x8006,
		Min = 0x8007,
		MinExt = 0x8007,
		Max = 0x8008,
		MaxExt = 0x8008,
		BlendEquation = 0x8009,
		BlendEquationExt = 0x8009,
	}
	public enum EXT_blend_subtract : uint
	{
		FuncSubtract = 0x800A,
		FuncSubtractExt = 0x800A,
		FuncReverseSubtract = 0x800B,
		FuncReverseSubtractExt = 0x800B,
	}
	public enum EXT_cmyka : uint
	{
		CmykExt = 0x800C,
		CmykaExt = 0x800D,
		PackCmykHintExt = 0x800E,
		UnpackCmykHintExt = 0x800F,
	}
	public enum EXT_convolution : uint
	{
		Convolution1d = 0x8010,
		Convolution1dExt = 0x8010,
		Convolution2d = 0x8011,
		Convolution2dExt = 0x8011,
		Separable2d = 0x8012,
		Separable2dExt = 0x8012,
		ConvolutionBorderMode = 0x8013,
		ConvolutionBorderModeExt = 0x8013,
		ConvolutionFilterScale = 0x8014,
		ConvolutionFilterScaleExt = 0x8014,
		ConvolutionFilterBias = 0x8015,
		ConvolutionFilterBiasExt = 0x8015,
		Reduce = 0x8016,
		ReduceExt = 0x8016,
		ConvolutionFormat = 0x8017,
		ConvolutionFormatExt = 0x8017,
		ConvolutionWidth = 0x8018,
		ConvolutionWidthExt = 0x8018,
		ConvolutionHeight = 0x8019,
		ConvolutionHeightExt = 0x8019,
		MaxConvolutionWidth = 0x801A,
		MaxConvolutionWidthExt = 0x801A,
		MaxConvolutionHeight = 0x801B,
		MaxConvolutionHeightExt = 0x801B,
		PostConvolutionRedScale = 0x801C,
		PostConvolutionRedScaleExt = 0x801C,
		PostConvolutionGreenScale = 0x801D,
		PostConvolutionGreenScaleExt = 0x801D,
		PostConvolutionBlueScale = 0x801E,
		PostConvolutionBlueScaleExt = 0x801E,
		PostConvolutionAlphaScale = 0x801F,
		PostConvolutionAlphaScaleExt = 0x801F,
		PostConvolutionRedBias = 0x8020,
		PostConvolutionRedBiasExt = 0x8020,
		PostConvolutionGreenBias = 0x8021,
		PostConvolutionGreenBiasExt = 0x8021,
		PostConvolutionBlueBias = 0x8022,
		PostConvolutionBlueBiasExt = 0x8022,
		PostConvolutionAlphaBias = 0x8023,
		PostConvolutionAlphaBiasExt = 0x8023,
	}
	public enum EXT_histogram : uint
	{
		Histogram = 0x8024,
		HistogramExt = 0x8024,
		ProxyHistogram = 0x8025,
		ProxyHistogramExt = 0x8025,
		HistogramWidth = 0x8026,
		HistogramWidthExt = 0x8026,
		HistogramFormat = 0x8027,
		HistogramFormatExt = 0x8027,
		HistogramRedSize = 0x8028,
		HistogramRedSizeExt = 0x8028,
		HistogramGreenSize = 0x8029,
		HistogramGreenSizeExt = 0x8029,
		HistogramBlueSize = 0x802A,
		HistogramBlueSizeExt = 0x802A,
		HistogramAlphaSize = 0x802B,
		HistogramAlphaSizeExt = 0x802B,
		HistogramLuminanceSize = 0x802C,
		HistogramLuminanceSizeExt = 0x802C,
		HistogramSink = 0x802D,
		HistogramSinkExt = 0x802D,
		Minmax = 0x802E,
		MinmaxExt = 0x802E,
		MinmaxFormat = 0x802F,
		MinmaxFormatExt = 0x802F,
		MinmaxSink = 0x8030,
		MinmaxSinkExt = 0x8030,
		TableTooLarge = 0x8031,
		TableTooLargeExt = 0x8031,
	}
	public enum EXT_packed_pixels : uint
	{
		UnsignedByte332 = 0x8032,
		UnsignedByte332Ext = 0x8032,
		UnsignedShort4444 = 0x8033,
		UnsignedShort4444Ext = 0x8033,
		UnsignedShort5551 = 0x8034,
		UnsignedShort5551Ext = 0x8034,
		UnsignedInt8888 = 0x8035,
		UnsignedInt8888Ext = 0x8035,
		UnsignedInt1010102 = 0x8036,
		UnsignedInt1010102Ext = 0x8036,
		UnsignedByte233Rev = 0x8362,
		UnsignedByte233RevExt = 0x8362,
		UnsignedShort565 = 0x8363,
		UnsignedShort565Ext = 0x8363,
		UnsignedShort565Rev = 0x8364,
		UnsignedShort565RevExt = 0x8364,
		UnsignedShort4444Rev = 0x8365,
		UnsignedShort4444RevExt = 0x8365,
		UnsignedShort1555Rev = 0x8366,
		UnsignedShort1555RevExt = 0x8366,
		UnsignedInt8888Rev = 0x8367,
		UnsignedInt8888RevExt = 0x8367,
		UnsignedInt2101010Rev = 0x8368,
		UnsignedInt2101010RevExt = 0x8368,
	}
	public enum EXT_polygon_offset : uint
	{
		PolygonOffsetExt = 0x8037,
		PolygonOffsetFactorExt = 0x8038,
		PolygonOffsetBiasExt = 0x8039,
	}
	public enum EXT_rescale_normal : uint
	{
		RescaleNormal = 0x803A,
		RescaleNormalExt = 0x803A,
	}
	public enum EXT_texture : uint
	{
		Alpha4Ext = 0x803B,
		Alpha8Ext = 0x803C,
		Alpha12Ext = 0x803D,
		Alpha16Ext = 0x803E,
		Luminance4Ext = 0x803F,
		Luminance8Ext = 0x8040,
		Luminance12Ext = 0x8041,
		Luminance16Ext = 0x8042,
		Luminance4Alpha4Ext = 0x8043,
		Luminance6Alpha2Ext = 0x8044,
		Luminance8Alpha8Ext = 0x8045,
		Luminance12Alpha4Ext = 0x8046,
		Luminance12Alpha12Ext = 0x8047,
		Luminance16Alpha16Ext = 0x8048,
		IntensityExt = 0x8049,
		Intensity4Ext = 0x804A,
		Intensity8Ext = 0x804B,
		Intensity12Ext = 0x804C,
		Intensity16Ext = 0x804D,
		Rgb2Ext = 0x804E,
		Rgb4Ext = 0x804F,
		Rgb5Ext = 0x8050,
		Rgb8Ext = 0x8051,
		Rgb10Ext = 0x8052,
		Rgb12Ext = 0x8053,
		Rgb16Ext = 0x8054,
		Rgba2Ext = 0x8055,
		Rgba4Ext = 0x8056,
		Rgb5A1Ext = 0x8057,
		Rgba8Ext = 0x8058,
		Rgb10A2Ext = 0x8059,
		Rgba12Ext = 0x805A,
		Rgba16Ext = 0x805B,
		TextureRedSizeExt = 0x805C,
		TextureGreenSizeExt = 0x805D,
		TextureBlueSizeExt = 0x805E,
		TextureAlphaSizeExt = 0x805F,
		TextureLuminanceSizeExt = 0x8060,
		TextureIntensitySizeExt = 0x8061,
		ReplaceExt = 0x8062,
		ProxyTexture1dExt = 0x8063,
		ProxyTexture2dExt = 0x8064,
		TextureTooLargeExt = 0x8065,
	}
	public enum EXT_texture_object : uint
	{
		TexturePriorityExt = 0x8066,
		TextureResidentExt = 0x8067,
		Texture1dBindingExt = 0x8068,
		Texture2dBindingExt = 0x8069,
		Texture3dBindingExt = 0x806A,
	}
	public enum EXT_texture3D : uint
	{
		PackSkipImages = 0x806B,
		PackSkipImagesExt = 0x806B,
		PackImageHeight = 0x806C,
		PackImageHeightExt = 0x806C,
		UnpackSkipImages = 0x806D,
		UnpackSkipImagesExt = 0x806D,
		UnpackImageHeight = 0x806E,
		UnpackImageHeightExt = 0x806E,
		Texture3d = 0x806F,
		Texture3dExt = 0x806F,
		ProxyTexture3d = 0x8070,
		ProxyTexture3dExt = 0x8070,
		TextureDepth = 0x8071,
		TextureDepthExt = 0x8071,
		TextureWrapR = 0x8072,
		TextureWrapRExt = 0x8072,
		Max3dTextureSize = 0x8073,
		Max3dTextureSizeExt = 0x8073,
	}
	public enum EXT_vertex_array : uint
	{
		VertexArrayExt = 0x8074,
		NormalArrayExt = 0x8075,
		ColorArrayExt = 0x8076,
		IndexArrayExt = 0x8077,
		TextureCoordArrayExt = 0x8078,
		EdgeFlagArrayExt = 0x8079,
		VertexArraySizeExt = 0x807A,
		VertexArrayTypeExt = 0x807B,
		VertexArrayStrideExt = 0x807C,
		VertexArrayCountExt = 0x807D,
		NormalArrayTypeExt = 0x807E,
		NormalArrayStrideExt = 0x807F,
		NormalArrayCountExt = 0x8080,
		ColorArraySizeExt = 0x8081,
		ColorArrayTypeExt = 0x8082,
		ColorArrayStrideExt = 0x8083,
		ColorArrayCountExt = 0x8084,
		IndexArrayTypeExt = 0x8085,
		IndexArrayStrideExt = 0x8086,
		IndexArrayCountExt = 0x8087,
		TextureCoordArraySizeExt = 0x8088,
		TextureCoordArrayTypeExt = 0x8089,
		TextureCoordArrayStrideExt = 0x808A,
		TextureCoordArrayCountExt = 0x808B,
		EdgeFlagArrayStrideExt = 0x808C,
		EdgeFlagArrayCountExt = 0x808D,
		VertexArrayPointerExt = 0x808E,
		NormalArrayPointerExt = 0x808F,
		ColorArrayPointerExt = 0x8090,
		IndexArrayPointerExt = 0x8091,
		TextureCoordArrayPointerExt = 0x8092,
		EdgeFlagArrayPointerExt = 0x8093,
	}
	public enum SGIX_interlace : uint
	{
		InterlaceSgix = 0x8094,
	}
	public enum SGIS_detail_texture : uint
	{
		DetailTexture2dSgis = 0x8095,
		DetailTexture2dBindingSgis = 0x8096,
		LinearDetailSgis = 0x8097,
		LinearDetailAlphaSgis = 0x8098,
		LinearDetailColorSgis = 0x8099,
		DetailTextureLevelSgis = 0x809A,
		DetailTextureModeSgis = 0x809B,
		DetailTextureFuncPointsSgis = 0x809C,
	}
	public enum ARB_multisample : uint
	{
		Multisample = 0x809D,
		MultisampleArb = 0x809D,
		SampleAlphaToCoverage = 0x809E,
		SampleAlphaToCoverageArb = 0x809E,
		SampleAlphaToOne = 0x809F,
		SampleAlphaToOneArb = 0x809F,
		SampleCoverage = 0x80A0,
		SampleCoverageArb = 0x80A0,
		SampleBuffers = 0x80A8,
		SampleBuffersArb = 0x80A8,
		Samples = 0x80A9,
		SamplesArb = 0x80A9,
		SampleCoverageValue = 0x80AA,
		SampleCoverageValueArb = 0x80AA,
		SampleCoverageInvert = 0x80AB,
		SampleCoverageInvertArb = 0x80AB,
		MultisampleBitArb = 0x20000000,
	}
	public enum SGIS_multisample : uint
	{
		MultisampleSgis = 0x809D,
		SampleAlphaToMaskSgis = 0x809E,
		SampleAlphaToOneSgis = 0x809F,
		SampleMaskSgis = 0x80A0,
		gl1passSgis = 0x80A1,
		gl2pass0Sgis = 0x80A2,
		gl2pass1Sgis = 0x80A3,
		gl4pass0Sgis = 0x80A4,
		gl4pass1Sgis = 0x80A5,
		gl4pass2Sgis = 0x80A6,
		gl4pass3Sgis = 0x80A7,
		SampleBuffersSgis = 0x80A8,
		SamplesSgis = 0x80A9,
		SampleMaskValueSgis = 0x80AA,
		SampleMaskInvertSgis = 0x80AB,
		SamplePatternSgis = 0x80AC,
	}
	public enum SGIS_sharpen_texture : uint
	{
		LinearSharpenSgis = 0x80AD,
		LinearSharpenAlphaSgis = 0x80AE,
		LinearSharpenColorSgis = 0x80AF,
		SharpenTextureFuncPointsSgis = 0x80B0,
	}
	public enum SGI_color_matrix : uint
	{
		ColorMatrix = 0x80B1,
		ColorMatrixSgi = 0x80B1,
		ColorMatrixStackDepth = 0x80B2,
		ColorMatrixStackDepthSgi = 0x80B2,
		MaxColorMatrixStackDepth = 0x80B3,
		MaxColorMatrixStackDepthSgi = 0x80B3,
		PostColorMatrixRedScale = 0x80B4,
		PostColorMatrixRedScaleSgi = 0x80B4,
		PostColorMatrixGreenScale = 0x80B5,
		PostColorMatrixGreenScaleSgi = 0x80B5,
		PostColorMatrixBlueScale = 0x80B6,
		PostColorMatrixBlueScaleSgi = 0x80B6,
		PostColorMatrixAlphaScale = 0x80B7,
		PostColorMatrixAlphaScaleSgi = 0x80B7,
		PostColorMatrixRedBias = 0x80B8,
		PostColorMatrixRedBiasSgi = 0x80B8,
		PostColorMatrixGreenBias = 0x80B9,
		PostColorMatrixGreenBiasSgi = 0x80B9,
		PostColorMatrixBlueBias = 0x80BA,
		PostColorMatrixBlueBiasSgi = 0x80BA,
		PostColorMatrixAlphaBias = 0x80BB,
		PostColorMatrixAlphaBiasSgi = 0x80BB,
	}
	public enum SGI_texture_color_table : uint
	{
		TextureColorTableSgi = 0x80BC,
		ProxyTextureColorTableSgi = 0x80BD,
	}
	public enum SGIX_texture_add_env : uint
	{
		TextureEnvBiasSgix = 0x80BE,
	}
	public enum SGIX_shadow_ambient : uint
	{
		ShadowAmbientSgix = 0x80BF,
	}
	public enum SGI_color_table : uint
	{
		ColorTable = 0x80D0,
		ColorTableSgi = 0x80D0,
		PostConvolutionColorTable = 0x80D1,
		PostConvolutionColorTableSgi = 0x80D1,
		PostColorMatrixColorTable = 0x80D2,
		PostColorMatrixColorTableSgi = 0x80D2,
		ProxyColorTable = 0x80D3,
		ProxyColorTableSgi = 0x80D3,
		ProxyPostConvolutionColorTable = 0x80D4,
		ProxyPostConvolutionColorTableSgi = 0x80D4,
		ProxyPostColorMatrixColorTable = 0x80D5,
		ProxyPostColorMatrixColorTableSgi = 0x80D5,
		ColorTableScale = 0x80D6,
		ColorTableScaleSgi = 0x80D6,
		ColorTableBias = 0x80D7,
		ColorTableBiasSgi = 0x80D7,
		ColorTableFormat = 0x80D8,
		ColorTableFormatSgi = 0x80D8,
		ColorTableWidth = 0x80D9,
		ColorTableWidthSgi = 0x80D9,
		ColorTableRedSize = 0x80DA,
		ColorTableRedSizeSgi = 0x80DA,
		ColorTableGreenSize = 0x80DB,
		ColorTableGreenSizeSgi = 0x80DB,
		ColorTableBlueSize = 0x80DC,
		ColorTableBlueSizeSgi = 0x80DC,
		ColorTableAlphaSize = 0x80DD,
		ColorTableAlphaSizeSgi = 0x80DD,
		ColorTableLuminanceSize = 0x80DE,
		ColorTableLuminanceSizeSgi = 0x80DE,
		ColorTableIntensitySize = 0x80DF,
		ColorTableIntensitySizeSgi = 0x80DF,
	}
	public enum EXT_bgra : uint
	{
		Bgr = 0x80E0,
		BgrExt = 0x80E0,
		Bgra = 0x80E1,
		BgraExt = 0x80E1,
	}
	public enum VERSION_1_2 : uint
	{
		MaxElementsVertices = 0x80E8,
		MaxElementsIndices = 0x80E9,
		SmoothPointSizeRange = 0x0B12,
		SmoothPointSizeGranularity = 0x0B13,
		SmoothLineWidthRange = 0x0B22,
		SmoothLineWidthGranularity = 0x0B23,
		AliasedPointSizeRange = 0x846D,
		AliasedLineWidthRange = 0x846E,
		UnsignedByte332 = 0x8032,
		UnsignedShort4444 = 0x8033,
		UnsignedShort5551 = 0x8034,
		UnsignedInt8888 = 0x8035,
		UnsignedInt1010102 = 0x8036,
		RescaleNormal = 0x803A,
		TextureBinding3d = 0x806A,
		PackSkipImages = 0x806B,
		PackImageHeight = 0x806C,
		UnpackSkipImages = 0x806D,
		UnpackImageHeight = 0x806E,
		Texture3d = 0x806F,
		ProxyTexture3d = 0x8070,
		TextureDepth = 0x8071,
		TextureWrapR = 0x8072,
		Max3dTextureSize = 0x8073,
		UnsignedByte233Rev = 0x8362,
		UnsignedShort565 = 0x8363,
		UnsignedShort565Rev = 0x8364,
		UnsignedShort4444Rev = 0x8365,
		UnsignedShort1555Rev = 0x8366,
		UnsignedInt8888Rev = 0x8367,
		UnsignedInt2101010Rev = 0x8368,
		Bgr = 0x80E0,
		Bgra = 0x80E1,
		ClampToEdge = 0x812F,
		TextureMinLod = 0x813A,
		TextureMaxLod = 0x813B,
		TextureBaseLevel = 0x813C,
		TextureMaxLevel = 0x813D,
		LightModelColorControl = 0x81F8,
		SingleColor = 0x81F9,
		SeparateSpecularColor = 0x81FA,
	}
	public enum SGIS_texture_select : uint
	{
		DualAlpha4Sgis = 0x8110,
		DualAlpha8Sgis = 0x8111,
		DualAlpha12Sgis = 0x8112,
		DualAlpha16Sgis = 0x8113,
		DualLuminance4Sgis = 0x8114,
		DualLuminance8Sgis = 0x8115,
		DualLuminance12Sgis = 0x8116,
		DualLuminance16Sgis = 0x8117,
		DualIntensity4Sgis = 0x8118,
		DualIntensity8Sgis = 0x8119,
		DualIntensity12Sgis = 0x811A,
		DualIntensity16Sgis = 0x811B,
		DualLuminanceAlpha4Sgis = 0x811C,
		DualLuminanceAlpha8Sgis = 0x811D,
		QuadAlpha4Sgis = 0x811E,
		QuadAlpha8Sgis = 0x811F,
		QuadLuminance4Sgis = 0x8120,
		QuadLuminance8Sgis = 0x8121,
		QuadIntensity4Sgis = 0x8122,
		QuadIntensity8Sgis = 0x8123,
		DualTextureSelectSgis = 0x8124,
		QuadTextureSelectSgis = 0x8125,
	}
	public enum SGIS_point_parameters : uint
	{
		PointSizeMin = 0x8126,
		PointSizeMinArb = 0x8126,
		PointSizeMinExt = 0x8126,
		PointSizeMinSgis = 0x8126,
		PointSizeMax = 0x8127,
		PointSizeMaxArb = 0x8127,
		PointSizeMaxExt = 0x8127,
		PointSizeMaxSgis = 0x8127,
		PointFadeThresholdSize = 0x8128,
		PointFadeThresholdSizeArb = 0x8128,
		PointFadeThresholdSizeExt = 0x8128,
		PointFadeThresholdSizeSgis = 0x8128,
		PointDistanceAttenuation = 0x8129,
		PointDistanceAttenuationArb = 0x8129,
		DistanceAttenuationExt = 0x8129,
		DistanceAttenuationSgis = 0x8129,
	}
	public enum SGIS_fog_function : uint
	{
		FogFuncSgis = 0x812A,
		FogFuncPointsSgis = 0x812B,
		MaxFogFuncPointsSgis = 0x812C,
	}
	public enum SGIS_texture_border_clamp : uint
	{
		ClampToBorder = 0x812D,
		ClampToBorderArb = 0x812D,
		ClampToBorderSgis = 0x812D,
	}
	public enum SGIX_texture_multi_buffer : uint
	{
		TextureMultiBufferHintSgix = 0x812E,
	}
	public enum SGIS_texture_edge_clamp : uint
	{
		ClampToEdge = 0x812F,
		ClampToEdgeSgis = 0x812F,
	}
	public enum SGIS_texture4D : uint
	{
		PackSkipVolumesSgis = 0x8130,
		PackImageDepthSgis = 0x8131,
		UnpackSkipVolumesSgis = 0x8132,
		UnpackImageDepthSgis = 0x8133,
		Texture4dSgis = 0x8134,
		ProxyTexture4dSgis = 0x8135,
		Texture4dsizeSgis = 0x8136,
		TextureWrapQSgis = 0x8137,
		Max4dTextureSizeSgis = 0x8138,
		Texture4dBindingSgis = 0x814F,
	}
	public enum SGIX_pixel_texture : uint
	{
		PixelTexGenSgix = 0x8139,
		PixelTexGenModeSgix = 0x832B,
	}
	public enum SGIS_texture_lod : uint
	{
		TextureMinLod = 0x813A,
		TextureMinLodSgis = 0x813A,
		TextureMaxLod = 0x813B,
		TextureMaxLodSgis = 0x813B,
		TextureBaseLevel = 0x813C,
		TextureBaseLevelSgis = 0x813C,
		TextureMaxLevel = 0x813D,
		TextureMaxLevelSgis = 0x813D,
	}
	public enum SGIX_pixel_tiles : uint
	{
		PixelTileBestAlignmentSgix = 0x813E,
		PixelTileCacheIncrementSgix = 0x813F,
		PixelTileWidthSgix = 0x8140,
		PixelTileHeightSgix = 0x8141,
		PixelTileGridWidthSgix = 0x8142,
		PixelTileGridHeightSgix = 0x8143,
		PixelTileGridDepthSgix = 0x8144,
		PixelTileCacheSizeSgix = 0x8145,
	}
	public enum SGIS_texture_filter4 : uint
	{
		Filter4Sgis = 0x8146,
		TextureFilter4SizeSgis = 0x8147,
	}
	public enum SGIX_sprite : uint
	{
		SpriteSgix = 0x8148,
		SpriteModeSgix = 0x8149,
		SpriteAxisSgix = 0x814A,
		SpriteTranslationSgix = 0x814B,
		SpriteAxialSgix = 0x814C,
		SpriteObjectAlignedSgix = 0x814D,
		SpriteEyeAlignedSgix = 0x814E,
	}
	public enum HP_convolution_border_modes : uint
	{
		IgnoreBorderHp = 0x8150,
		ConstantBorder = 0x8151,
		ConstantBorderHp = 0x8151,
		ReplicateBorder = 0x8153,
		ReplicateBorderHp = 0x8153,
		ConvolutionBorderColor = 0x8154,
		ConvolutionBorderColorHp = 0x8154,
	}
	public enum SGIX_clipmap : uint
	{
		LinearClipmapLinearSgix = 0x8170,
		TextureClipmapCenterSgix = 0x8171,
		TextureClipmapFrameSgix = 0x8172,
		TextureClipmapOffsetSgix = 0x8173,
		TextureClipmapVirtualDepthSgix = 0x8174,
		TextureClipmapLodOffsetSgix = 0x8175,
		TextureClipmapDepthSgix = 0x8176,
		MaxClipmapDepthSgix = 0x8177,
		MaxClipmapVirtualDepthSgix = 0x8178,
		NearestClipmapNearestSgix = 0x844D,
		NearestClipmapLinearSgix = 0x844E,
		LinearClipmapNearestSgix = 0x844F,
	}
	public enum SGIX_texture_scale_bias : uint
	{
		PostTextureFilterBiasSgix = 0x8179,
		PostTextureFilterScaleSgix = 0x817A,
		PostTextureFilterBiasRangeSgix = 0x817B,
		PostTextureFilterScaleRangeSgix = 0x817C,
	}
	public enum SGIX_reference_plane : uint
	{
		ReferencePlaneSgix = 0x817D,
		ReferencePlaneEquationSgix = 0x817E,
	}
	public enum SGIX_ir_instrument1 : uint
	{
		IrInstrument1Sgix = 0x817F,
	}
	public enum SGIX_instruments : uint
	{
		InstrumentBufferPointerSgix = 0x8180,
		InstrumentMeasurementsSgix = 0x8181,
	}
	public enum SGIX_list_priority : uint
	{
		ListPrioritySgix = 0x8182,
	}
	public enum SGIX_calligraphic_fragment : uint
	{
		CalligraphicFragmentSgix = 0x8183,
	}
	public enum SGIX_impact_pixel_texture : uint
	{
		PixelTexGenQCeilingSgix = 0x8184,
		PixelTexGenQRoundSgix = 0x8185,
		PixelTexGenQFloorSgix = 0x8186,
		PixelTexGenAlphaReplaceSgix = 0x8187,
		PixelTexGenAlphaNoReplaceSgix = 0x8188,
		PixelTexGenAlphaLsSgix = 0x8189,
		PixelTexGenAlphaMsSgix = 0x818A,
	}
	public enum SGIX_framezoom : uint
	{
		FramezoomSgix = 0x818B,
		FramezoomFactorSgix = 0x818C,
		MaxFramezoomFactorSgix = 0x818D,
	}
	public enum SGIX_texture_lod_bias : uint
	{
		TextureLodBiasSSgix = 0x818E,
		TextureLodBiasTSgix = 0x818F,
		TextureLodBiasRSgix = 0x8190,
	}
	public enum SGIS_generate_mipmap : uint
	{
		GenerateMipmap = 0x8191,
		GenerateMipmapSgis = 0x8191,
		GenerateMipmapHint = 0x8192,
		GenerateMipmapHintSgis = 0x8192,
		GeometryDeformationSgix = 0x8194,
		TextureDeformationSgix = 0x8195,
		DeformationsMaskSgix = 0x8196,
		MaxDeformationOrderSgix = 0x8197,
	}
	public enum SGIX_fog_offset : uint
	{
		FogOffsetSgix = 0x8198,
		FogOffsetValueSgix = 0x8199,
	}
	public enum SGIX_shadow : uint
	{
		TextureCompareSgix = 0x819A,
		TextureCompareOperatorSgix = 0x819B,
		TextureLequalRSgix = 0x819C,
		TextureGequalRSgix = 0x819D,
	}
	public enum SGIX_depth_texture : uint
	{
		DepthComponent16 = 0x81A5,
		DepthComponent16Sgix = 0x81A5,
		DepthComponent24 = 0x81A6,
		DepthComponent24Sgix = 0x81A6,
		DepthComponent32 = 0x81A7,
		DepthComponent32Sgix = 0x81A7,
	}
	public enum SGIX_ycrcb : uint
	{
		Ycrcb422Sgix = 0x81BB,
		Ycrcb444Sgix = 0x81BC,
	}
	public enum SGIS_texture_color_mask : uint
	{
		TextureColorWritemaskSgis = 0x81EF,
	}
	public enum SGIS_point_line_texgen : uint
	{
		EyeDistanceToPointSgis = 0x81F0,
		ObjectDistanceToPointSgis = 0x81F1,
		EyeDistanceToLineSgis = 0x81F2,
		ObjectDistanceToLineSgis = 0x81F3,
		EyePointSgis = 0x81F4,
		ObjectPointSgis = 0x81F5,
		EyeLineSgis = 0x81F6,
		ObjectLineSgis = 0x81F7,
	}
	public enum EXT_separate_specular_color : uint
	{
		LightModelColorControl = 0x81F8,
		LightModelColorControlExt = 0x81F8,
		SingleColor = 0x81F9,
		SingleColorExt = 0x81F9,
		SeparateSpecularColor = 0x81FA,
		SeparateSpecularColorExt = 0x81FA,
	}
	public enum EXT_shared_texture_palette : uint
	{
		SharedTexturePaletteExt = 0x81FB,
	}
	public enum SGIX_convolution_accuracy : uint
	{
		ConvolutionHintSgix = 0x8316,
	}
	public enum SGIX_blend_alpha_minmax : uint
	{
		AlphaMinSgix = 0x8320,
		AlphaMaxSgix = 0x8321,
		AsyncMarkerSgix = 0x8329,
	}
	public enum SGIX_async_histogram : uint
	{
		AsyncHistogramSgix = 0x832C,
		MaxAsyncHistogramSgix = 0x832D,
	}
	public enum EXT_pixel_transform : uint
	{
		PixelTransform2dExt = 0x8330,
		PixelMagFilterExt = 0x8331,
		PixelMinFilterExt = 0x8332,
		PixelCubicWeightExt = 0x8333,
		CubicExt = 0x8334,
		AverageExt = 0x8335,
		PixelTransform2dStackDepthExt = 0x8336,
		MaxPixelTransform2dStackDepthExt = 0x8337,
		PixelTransform2dMatrixExt = 0x8338,
	}
	public enum SGIS_pixel_texture : uint
	{
		PixelTextureSgis = 0x8353,
		PixelFragmentRgbSourceSgis = 0x8354,
		PixelFragmentAlphaSourceSgis = 0x8355,
		PixelGroupColorSgis = 0x8356,
	}
	public enum SGIX_async_pixel : uint
	{
		AsyncTexImageSgix = 0x835C,
		AsyncDrawPixelsSgix = 0x835D,
		AsyncReadPixelsSgix = 0x835E,
		MaxAsyncTexImageSgix = 0x835F,
		MaxAsyncDrawPixelsSgix = 0x8360,
		MaxAsyncReadPixelsSgix = 0x8361,
	}
	public enum SGIX_texture_coordinate_clamp : uint
	{
		TextureMaxClampSSgix = 0x8369,
		TextureMaxClampTSgix = 0x836A,
		TextureMaxClampRSgix = 0x836B,
		FogFactorToAlphaSgix = 0x836F,
	}
	public enum SGIX_vertex_preclip : uint
	{
		VertexPreclipSgix = 0x83EE,
		VertexPreclipHintSgix = 0x83EF,
	}
	public enum EXT_texture_compression_s3tc : uint
	{
		CompressedRgbS3tcDxt1Ext = 0x83F0,
		CompressedRgbaS3tcDxt1Ext = 0x83F1,
		CompressedRgbaS3tcDxt3Ext = 0x83F2,
		CompressedRgbaS3tcDxt5Ext = 0x83F3,
	}
	public enum INTEL_parallel_arrays : uint
	{
		ParallelArraysIntel = 0x83F4,
		VertexArrayParallelPointersIntel = 0x83F5,
		NormalArrayParallelPointersIntel = 0x83F6,
		ColorArrayParallelPointersIntel = 0x83F7,
		TextureCoordArrayParallelPointersIntel = 0x83F8,
	}
	public enum SGIX_fragment_lighting : uint
	{
		FragmentLightingSgix = 0x8400,
		FragmentColorMaterialSgix = 0x8401,
		FragmentColorMaterialFaceSgix = 0x8402,
		FragmentColorMaterialParameterSgix = 0x8403,
		MaxFragmentLightsSgix = 0x8404,
		MaxActiveLightsSgix = 0x8405,
		CurrentRasterNormalSgix = 0x8406,
		LightEnvModeSgix = 0x8407,
		FragmentLightModelLocalViewerSgix = 0x8408,
		FragmentLightModelTwoSideSgix = 0x8409,
		FragmentLightModelAmbientSgix = 0x840A,
		FragmentLightModelNormalInterpolationSgix = 0x840B,
		FragmentLight0Sgix = 0x840C,
		FragmentLight1Sgix = 0x840D,
		FragmentLight2Sgix = 0x840E,
		FragmentLight3Sgix = 0x840F,
		FragmentLight4Sgix = 0x8410,
		FragmentLight5Sgix = 0x8411,
		FragmentLight6Sgix = 0x8412,
		FragmentLight7Sgix = 0x8413,
	}
	public enum SGIX_resample : uint
	{
		PackResampleSgix = 0x842C,
		UnpackResampleSgix = 0x842D,
		ResampleReplicateSgix = 0x842E,
		ResampleZeroFillSgix = 0x842F,
		ResampleDecimateSgix = 0x8430,
	}
	public enum SGIX_subsample : uint
	{
		PackSubsampleRateSgix = 0x85A0,
		UnpackSubsampleRateSgix = 0x85A1,
		PixelSubsample4444Sgix = 0x85A2,
		PixelSubsample2424Sgix = 0x85A3,
		PixelSubsample4242Sgix = 0x85A4,
	}
	public enum ARB_imaging : uint
	{
		ConstantColor = 0x8001,
		OneMinusConstantColor = 0x8002,
		ConstantAlpha = 0x8003,
		OneMinusConstantAlpha = 0x8004,
		BlendColor = 0x8005,
		FuncAdd = 0x8006,
		Min = 0x8007,
		Max = 0x8008,
		BlendEquation = 0x8009,
		FuncSubtract = 0x800A,
		FuncReverseSubtract = 0x800B,
		Convolution1d = 0x8010,
		Convolution2d = 0x8011,
		Separable2d = 0x8012,
		ConvolutionBorderMode = 0x8013,
		ConvolutionFilterScale = 0x8014,
		ConvolutionFilterBias = 0x8015,
		Reduce = 0x8016,
		ConvolutionFormat = 0x8017,
		ConvolutionWidth = 0x8018,
		ConvolutionHeight = 0x8019,
		MaxConvolutionWidth = 0x801A,
		MaxConvolutionHeight = 0x801B,
		PostConvolutionRedScale = 0x801C,
		PostConvolutionGreenScale = 0x801D,
		PostConvolutionBlueScale = 0x801E,
		PostConvolutionAlphaScale = 0x801F,
		PostConvolutionRedBias = 0x8020,
		PostConvolutionGreenBias = 0x8021,
		PostConvolutionBlueBias = 0x8022,
		PostConvolutionAlphaBias = 0x8023,
		Histogram = 0x8024,
		ProxyHistogram = 0x8025,
		HistogramWidth = 0x8026,
		HistogramFormat = 0x8027,
		HistogramRedSize = 0x8028,
		HistogramGreenSize = 0x8029,
		HistogramBlueSize = 0x802A,
		HistogramAlphaSize = 0x802B,
		HistogramLuminanceSize = 0x802C,
		HistogramSink = 0x802D,
		Minmax = 0x802E,
		MinmaxFormat = 0x802F,
		MinmaxSink = 0x8030,
		TableTooLarge = 0x8031,
		ColorMatrix = 0x80B1,
		ColorMatrixStackDepth = 0x80B2,
		MaxColorMatrixStackDepth = 0x80B3,
		PostColorMatrixRedScale = 0x80B4,
		PostColorMatrixGreenScale = 0x80B5,
		PostColorMatrixBlueScale = 0x80B6,
		PostColorMatrixAlphaScale = 0x80B7,
		PostColorMatrixRedBias = 0x80B8,
		PostColorMatrixGreenBias = 0x80B9,
		PostColorMatrixBlueBias = 0x80BA,
		PostColorMatrixAlphaBias = 0x80BB,
		ColorTable = 0x80D0,
		PostConvolutionColorTable = 0x80D1,
		PostColorMatrixColorTable = 0x80D2,
		ProxyColorTable = 0x80D3,
		ProxyPostConvolutionColorTable = 0x80D4,
		ProxyPostColorMatrixColorTable = 0x80D5,
		ColorTableScale = 0x80D6,
		ColorTableBias = 0x80D7,
		ColorTableFormat = 0x80D8,
		ColorTableWidth = 0x80D9,
		ColorTableRedSize = 0x80DA,
		ColorTableGreenSize = 0x80DB,
		ColorTableBlueSize = 0x80DC,
		ColorTableAlphaSize = 0x80DD,
		ColorTableLuminanceSize = 0x80DE,
		ColorTableIntensitySize = 0x80DF,
		ConstantBorder = 0x8151,
		ReplicateBorder = 0x8153,
		ConvolutionBorderColor = 0x8154,
	}
	public enum VERSION_1_3 : uint
	{
		Texture0 = 0x84C0,
		Texture1 = 0x84C1,
		Texture2 = 0x84C2,
		Texture3 = 0x84C3,
		Texture4 = 0x84C4,
		Texture5 = 0x84C5,
		Texture6 = 0x84C6,
		Texture7 = 0x84C7,
		Texture8 = 0x84C8,
		Texture9 = 0x84C9,
		Texture10 = 0x84CA,
		Texture11 = 0x84CB,
		Texture12 = 0x84CC,
		Texture13 = 0x84CD,
		Texture14 = 0x84CE,
		Texture15 = 0x84CF,
		Texture16 = 0x84D0,
		Texture17 = 0x84D1,
		Texture18 = 0x84D2,
		Texture19 = 0x84D3,
		Texture20 = 0x84D4,
		Texture21 = 0x84D5,
		Texture22 = 0x84D6,
		Texture23 = 0x84D7,
		Texture24 = 0x84D8,
		Texture25 = 0x84D9,
		Texture26 = 0x84DA,
		Texture27 = 0x84DB,
		Texture28 = 0x84DC,
		Texture29 = 0x84DD,
		Texture30 = 0x84DE,
		Texture31 = 0x84DF,
		ActiveTexture = 0x84E0,
		ClientActiveTexture = 0x84E1,
		MaxTextureUnits = 0x84E2,
		TransposeModelviewMatrix = 0x84E3,
		TransposeProjectionMatrix = 0x84E4,
		TransposeTextureMatrix = 0x84E5,
		TransposeColorMatrix = 0x84E6,
		Multisample = 0x809D,
		SampleAlphaToCoverage = 0x809E,
		SampleAlphaToOne = 0x809F,
		SampleCoverage = 0x80A0,
		SampleBuffers = 0x80A8,
		Samples = 0x80A9,
		SampleCoverageValue = 0x80AA,
		SampleCoverageInvert = 0x80AB,
		MultisampleBit = 0x20000000,
		NormalMap = 0x8511,
		ReflectionMap = 0x8512,
		TextureCubeMap = 0x8513,
		TextureBindingCubeMap = 0x8514,
		TextureCubeMapPositiveX = 0x8515,
		TextureCubeMapNegativeX = 0x8516,
		TextureCubeMapPositiveY = 0x8517,
		TextureCubeMapNegativeY = 0x8518,
		TextureCubeMapPositiveZ = 0x8519,
		TextureCubeMapNegativeZ = 0x851A,
		ProxyTextureCubeMap = 0x851B,
		MaxCubeMapTextureSize = 0x851C,
		CompressedAlpha = 0x84E9,
		CompressedLuminance = 0x84EA,
		CompressedLuminanceAlpha = 0x84EB,
		CompressedIntensity = 0x84EC,
		CompressedRgb = 0x84ED,
		CompressedRgba = 0x84EE,
		TextureCompressionHint = 0x84EF,
		TextureCompressedImageSize = 0x86A0,
		TextureCompressed = 0x86A1,
		NumCompressedTextureFormats = 0x86A2,
		CompressedTextureFormats = 0x86A3,
		ClampToBorder = 0x812D,
		Combine = 0x8570,
		CombineRgb = 0x8571,
		CombineAlpha = 0x8572,
		Source0Rgb = 0x8580,
		Source1Rgb = 0x8581,
		Source2Rgb = 0x8582,
		Source0Alpha = 0x8588,
		Source1Alpha = 0x8589,
		Source2Alpha = 0x858A,
		Operand0Rgb = 0x8590,
		Operand1Rgb = 0x8591,
		Operand2Rgb = 0x8592,
		Operand0Alpha = 0x8598,
		Operand1Alpha = 0x8599,
		Operand2Alpha = 0x859A,
		RgbScale = 0x8573,
		AddSigned = 0x8574,
		Interpolate = 0x8575,
		Subtract = 0x84E7,
		Constant = 0x8576,
		PrimaryColor = 0x8577,
		Previous = 0x8578,
		Dot3Rgb = 0x86AE,
		Dot3Rgba = 0x86AF,
	}
	public enum VERSION_1_4 : uint
	{
		BlendDstRgb = 0x80C8,
		BlendSrcRgb = 0x80C9,
		BlendDstAlpha = 0x80CA,
		BlendSrcAlpha = 0x80CB,
		PointSizeMin = 0x8126,
		PointSizeMax = 0x8127,
		PointFadeThresholdSize = 0x8128,
		PointDistanceAttenuation = 0x8129,
		GenerateMipmap = 0x8191,
		GenerateMipmapHint = 0x8192,
		DepthComponent16 = 0x81A5,
		DepthComponent24 = 0x81A6,
		DepthComponent32 = 0x81A7,
		MirroredRepeat = 0x8370,
		FogCoordinateSource = 0x8450,
		FogCoordinate = 0x8451,
		FragmentDepth = 0x8452,
		CurrentFogCoordinate = 0x8453,
		FogCoordinateArrayType = 0x8454,
		FogCoordinateArrayStride = 0x8455,
		FogCoordinateArrayPointer = 0x8456,
		FogCoordinateArray = 0x8457,
		ColorSum = 0x8458,
		CurrentSecondaryColor = 0x8459,
		SecondaryColorArraySize = 0x845A,
		SecondaryColorArrayType = 0x845B,
		SecondaryColorArrayStride = 0x845C,
		SecondaryColorArrayPointer = 0x845D,
		SecondaryColorArray = 0x845E,
		MaxTextureLodBias = 0x84FD,
		TextureFilterControl = 0x8500,
		TextureLodBias = 0x8501,
		IncrWrap = 0x8507,
		DecrWrap = 0x8508,
		TextureDepthSize = 0x884A,
		DepthTextureMode = 0x884B,
		TextureCompareMode = 0x884C,
		TextureCompareFunc = 0x884D,
		CompareRToTexture = 0x884E,
	}
	public enum VERSION_1_5 : uint
	{
		BufferSize = 0x8764,
		BufferUsage = 0x8765,
		QueryCounterBits = 0x8864,
		CurrentQuery = 0x8865,
		QueryResult = 0x8866,
		QueryResultAvailable = 0x8867,
		ArrayBuffer = 0x8892,
		ElementArrayBuffer = 0x8893,
		ArrayBufferBinding = 0x8894,
		ElementArrayBufferBinding = 0x8895,
		VertexArrayBufferBinding = 0x8896,
		NormalArrayBufferBinding = 0x8897,
		ColorArrayBufferBinding = 0x8898,
		IndexArrayBufferBinding = 0x8899,
		TextureCoordArrayBufferBinding = 0x889A,
		EdgeFlagArrayBufferBinding = 0x889B,
		SecondaryColorArrayBufferBinding = 0x889C,
		FogCoordinateArrayBufferBinding = 0x889D,
		WeightArrayBufferBinding = 0x889E,
		VertexAttribArrayBufferBinding = 0x889F,
		ReadOnly = 0x88B8,
		WriteOnly = 0x88B9,
		ReadWrite = 0x88BA,
		BufferAccess = 0x88BB,
		BufferMapped = 0x88BC,
		BufferMapPointer = 0x88BD,
		StreamDraw = 0x88E0,
		StreamRead = 0x88E1,
		StreamCopy = 0x88E2,
		StaticDraw = 0x88E4,
		StaticRead = 0x88E5,
		StaticCopy = 0x88E6,
		DynamicDraw = 0x88E8,
		DynamicRead = 0x88E9,
		DynamicCopy = 0x88EA,
		SamplesPassed = 0x8914,
	}
	public enum VERSION_2_0 : uint
	{
		VertexAttribArrayEnabled = 0x8622,
		VertexAttribArraySize = 0x8623,
		VertexAttribArrayStride = 0x8624,
		VertexAttribArrayType = 0x8625,
		CurrentVertexAttrib = 0x8626,
		VertexProgramPointSize = 0x8642,
		VertexProgramTwoSide = 0x8643,
		VertexAttribArrayPointer = 0x8645,
		StencilBackFunc = 0x8800,
		StencilBackFail = 0x8801,
		StencilBackPassDepthFail = 0x8802,
		StencilBackPassDepthPass = 0x8803,
		MaxDrawBuffers = 0x8824,
		DrawBuffer0 = 0x8825,
		DrawBuffer1 = 0x8826,
		DrawBuffer2 = 0x8827,
		DrawBuffer3 = 0x8828,
		DrawBuffer4 = 0x8829,
		DrawBuffer5 = 0x882A,
		DrawBuffer6 = 0x882B,
		DrawBuffer7 = 0x882C,
		DrawBuffer8 = 0x882D,
		DrawBuffer9 = 0x882E,
		DrawBuffer10 = 0x882F,
		DrawBuffer11 = 0x8830,
		DrawBuffer12 = 0x8831,
		DrawBuffer13 = 0x8832,
		DrawBuffer14 = 0x8833,
		DrawBuffer15 = 0x8834,
		BlendEquationAlpha = 0x883D,
		PointSprite = 0x8861,
		CoordReplace = 0x8862,
		MaxVertexAttribs = 0x8869,
		VertexAttribArrayNormalized = 0x886A,
		MaxTextureCoords = 0x8871,
		MaxTextureImageUnits = 0x8872,
		FragmentShader = 0x8B30,
		VertexShader = 0x8B31,
		MaxFragmentUniformComponents = 0x8B49,
		MaxVertexUniformComponents = 0x8B4A,
		MaxVaryingFloats = 0x8B4B,
		MaxVertexTextureImageUnits = 0x8B4C,
		MaxCombinedTextureImageUnits = 0x8B4D,
		ShaderType = 0x8B4F,
		FloatVec2 = 0x8B50,
		FloatVec3 = 0x8B51,
		FloatVec4 = 0x8B52,
		IntVec2 = 0x8B53,
		IntVec3 = 0x8B54,
		IntVec4 = 0x8B55,
		Bool = 0x8B56,
		BoolVec2 = 0x8B57,
		BoolVec3 = 0x8B58,
		BoolVec4 = 0x8B59,
		FloatMat2 = 0x8B5A,
		FloatMat3 = 0x8B5B,
		FloatMat4 = 0x8B5C,
		Sampler1d = 0x8B5D,
		Sampler2d = 0x8B5E,
		Sampler3d = 0x8B5F,
		SamplerCube = 0x8B60,
		Sampler1dShadow = 0x8B61,
		Sampler2dShadow = 0x8B62,
		DeleteStatus = 0x8B80,
		CompileStatus = 0x8B81,
		LinkStatus = 0x8B82,
		ValidateStatus = 0x8B83,
		InfoLogLength = 0x8B84,
		AttachedShaders = 0x8B85,
		ActiveUniforms = 0x8B86,
		ActiveUniformMaxLength = 0x8B87,
		ShaderSourceLength = 0x8B88,
		ActiveAttributes = 0x8B89,
		ActiveAttributeMaxLength = 0x8B8A,
		FragmentShaderDerivativeHint = 0x8B8B,
		ShadingLanguageVersion = 0x8B8C,
		CurrentProgram = 0x8B8D,
		PointSpriteCoordOrigin = 0x8CA0,
		LowerLeft = 0x8CA1,
		UpperLeft = 0x8CA2,
		StencilBackRef = 0x8CA3,
		StencilBackValueMask = 0x8CA4,
		StencilBackWritemask = 0x8CA5,
	}
	public enum VERSION_2_1 : uint
	{
		CurrentRasterSecondaryColor = 0x845F,
		PixelPackBuffer = 0x88EB,
		PixelUnpackBuffer = 0x88EC,
		PixelPackBufferBinding = 0x88ED,
		PixelUnpackBufferBinding = 0x88EF,
		FloatMat2x3 = 0x8B65,
		FloatMat2x4 = 0x8B66,
		FloatMat3x2 = 0x8B67,
		FloatMat3x4 = 0x8B68,
		FloatMat4x2 = 0x8B69,
		FloatMat4x3 = 0x8B6A,
		Srgb = 0x8C40,
		Srgb8 = 0x8C41,
		SrgbAlpha = 0x8C42,
		Srgb8Alpha8 = 0x8C43,
		SluminanceAlpha = 0x8C44,
		Sluminance8Alpha8 = 0x8C45,
		Sluminance = 0x8C46,
		Sluminance8 = 0x8C47,
		CompressedSrgb = 0x8C48,
		CompressedSrgbAlpha = 0x8C49,
		CompressedSluminance = 0x8C4A,
		CompressedSluminanceAlpha = 0x8C4B,
	}
	public enum ARB_multitexture : uint
	{
		Texture0Arb = 0x84C0,
		Texture1Arb = 0x84C1,
		Texture2Arb = 0x84C2,
		Texture3Arb = 0x84C3,
		Texture4Arb = 0x84C4,
		Texture5Arb = 0x84C5,
		Texture6Arb = 0x84C6,
		Texture7Arb = 0x84C7,
		Texture8Arb = 0x84C8,
		Texture9Arb = 0x84C9,
		Texture10Arb = 0x84CA,
		Texture11Arb = 0x84CB,
		Texture12Arb = 0x84CC,
		Texture13Arb = 0x84CD,
		Texture14Arb = 0x84CE,
		Texture15Arb = 0x84CF,
		Texture16Arb = 0x84D0,
		Texture17Arb = 0x84D1,
		Texture18Arb = 0x84D2,
		Texture19Arb = 0x84D3,
		Texture20Arb = 0x84D4,
		Texture21Arb = 0x84D5,
		Texture22Arb = 0x84D6,
		Texture23Arb = 0x84D7,
		Texture24Arb = 0x84D8,
		Texture25Arb = 0x84D9,
		Texture26Arb = 0x84DA,
		Texture27Arb = 0x84DB,
		Texture28Arb = 0x84DC,
		Texture29Arb = 0x84DD,
		Texture30Arb = 0x84DE,
		Texture31Arb = 0x84DF,
		ActiveTextureArb = 0x84E0,
		ClientActiveTextureArb = 0x84E1,
		MaxTextureUnitsArb = 0x84E2,
	}
	public enum ARB_transpose_matrix : uint
	{
		TransposeModelviewMatrixArb = 0x84E3,
		TransposeProjectionMatrixArb = 0x84E4,
		TransposeTextureMatrixArb = 0x84E5,
		TransposeColorMatrixArb = 0x84E6,
	}
	public enum ARB_texture_env_add : uint
	{
		}
	public enum ARB_texture_cube_map : uint
	{
		NormalMapArb = 0x8511,
		ReflectionMapArb = 0x8512,
		TextureCubeMapArb = 0x8513,
		TextureBindingCubeMapArb = 0x8514,
		TextureCubeMapPositiveXArb = 0x8515,
		TextureCubeMapNegativeXArb = 0x8516,
		TextureCubeMapPositiveYArb = 0x8517,
		TextureCubeMapNegativeYArb = 0x8518,
		TextureCubeMapPositiveZArb = 0x8519,
		TextureCubeMapNegativeZArb = 0x851A,
		ProxyTextureCubeMapArb = 0x851B,
		MaxCubeMapTextureSizeArb = 0x851C,
	}
	public enum ARB_texture_compression : uint
	{
		CompressedAlphaArb = 0x84E9,
		CompressedLuminanceArb = 0x84EA,
		CompressedLuminanceAlphaArb = 0x84EB,
		CompressedIntensityArb = 0x84EC,
		CompressedRgbArb = 0x84ED,
		CompressedRgbaArb = 0x84EE,
		TextureCompressionHintArb = 0x84EF,
		TextureCompressedImageSizeArb = 0x86A0,
		TextureCompressedArb = 0x86A1,
		NumCompressedTextureFormatsArb = 0x86A2,
		CompressedTextureFormatsArb = 0x86A3,
	}
	public enum ARB_texture_border_clamp : uint
	{
		ClampToBorderArb = 0x812D,
	}
	public enum ARB_point_parameters : uint
	{
		PointSizeMinArb = 0x8126,
		PointSizeMaxArb = 0x8127,
		PointFadeThresholdSizeArb = 0x8128,
		PointDistanceAttenuationArb = 0x8129,
	}
	public enum ARB_vertex_blend : uint
	{
		MaxVertexUnitsArb = 0x86A4,
		ActiveVertexUnitsArb = 0x86A5,
		WeightSumUnityArb = 0x86A6,
		VertexBlendArb = 0x86A7,
		CurrentWeightArb = 0x86A8,
		WeightArrayTypeArb = 0x86A9,
		WeightArrayStrideArb = 0x86AA,
		WeightArraySizeArb = 0x86AB,
		WeightArrayPointerArb = 0x86AC,
		WeightArrayArb = 0x86AD,
		Modelview0Arb = 0x1700,
		Modelview1Arb = 0x850A,
		Modelview2Arb = 0x8722,
		Modelview3Arb = 0x8723,
		Modelview4Arb = 0x8724,
		Modelview5Arb = 0x8725,
		Modelview6Arb = 0x8726,
		Modelview7Arb = 0x8727,
		Modelview8Arb = 0x8728,
		Modelview9Arb = 0x8729,
		Modelview10Arb = 0x872A,
		Modelview11Arb = 0x872B,
		Modelview12Arb = 0x872C,
		Modelview13Arb = 0x872D,
		Modelview14Arb = 0x872E,
		Modelview15Arb = 0x872F,
		Modelview16Arb = 0x8730,
		Modelview17Arb = 0x8731,
		Modelview18Arb = 0x8732,
		Modelview19Arb = 0x8733,
		Modelview20Arb = 0x8734,
		Modelview21Arb = 0x8735,
		Modelview22Arb = 0x8736,
		Modelview23Arb = 0x8737,
		Modelview24Arb = 0x8738,
		Modelview25Arb = 0x8739,
		Modelview26Arb = 0x873A,
		Modelview27Arb = 0x873B,
		Modelview28Arb = 0x873C,
		Modelview29Arb = 0x873D,
		Modelview30Arb = 0x873E,
		Modelview31Arb = 0x873F,
	}
	public enum ARB_matrix_palette : uint
	{
		MatrixPaletteArb = 0x8840,
		MaxMatrixPaletteStackDepthArb = 0x8841,
		MaxPaletteMatricesArb = 0x8842,
		CurrentPaletteMatrixArb = 0x8843,
		MatrixIndexArrayArb = 0x8844,
		CurrentMatrixIndexArb = 0x8845,
		MatrixIndexArraySizeArb = 0x8846,
		MatrixIndexArrayTypeArb = 0x8847,
		MatrixIndexArrayStrideArb = 0x8848,
		MatrixIndexArrayPointerArb = 0x8849,
	}
	public enum ARB_texture_env_combine : uint
	{
		CombineArb = 0x8570,
		CombineRgbArb = 0x8571,
		CombineAlphaArb = 0x8572,
		Source0RgbArb = 0x8580,
		Source1RgbArb = 0x8581,
		Source2RgbArb = 0x8582,
		Source0AlphaArb = 0x8588,
		Source1AlphaArb = 0x8589,
		Source2AlphaArb = 0x858A,
		Operand0RgbArb = 0x8590,
		Operand1RgbArb = 0x8591,
		Operand2RgbArb = 0x8592,
		Operand0AlphaArb = 0x8598,
		Operand1AlphaArb = 0x8599,
		Operand2AlphaArb = 0x859A,
		RgbScaleArb = 0x8573,
		AddSignedArb = 0x8574,
		InterpolateArb = 0x8575,
		SubtractArb = 0x84E7,
		ConstantArb = 0x8576,
		PrimaryColorArb = 0x8577,
		PreviousArb = 0x8578,
	}
	public enum ARB_texture_env_crossbar : uint
	{
		}
	public enum ARB_texture_env_dot3 : uint
	{
		Dot3RgbArb = 0x86AE,
		Dot3RgbaArb = 0x86AF,
	}
	public enum ARB_texture_mirrored_repeat : uint
	{
		MirroredRepeatArb = 0x8370,
	}
	public enum ARB_depth_texture : uint
	{
		DepthComponent16Arb = 0x81A5,
		DepthComponent24Arb = 0x81A6,
		DepthComponent32Arb = 0x81A7,
		TextureDepthSizeArb = 0x884A,
		DepthTextureModeArb = 0x884B,
	}
	public enum ARB_shadow : uint
	{
		TextureCompareModeArb = 0x884C,
		TextureCompareFuncArb = 0x884D,
		CompareRToTextureArb = 0x884E,
	}
	public enum ARB_shadow_ambient : uint
	{
		TextureCompareFailValueArb = 0x80BF,
	}
	public enum ARB_window_pos : uint
	{
		}
	public enum ARB_vertex_program : uint
	{
		ColorSumArb = 0x8458,
		VertexProgramArb = 0x8620,
		VertexAttribArrayEnabledArb = 0x8622,
		VertexAttribArraySizeArb = 0x8623,
		VertexAttribArrayStrideArb = 0x8624,
		VertexAttribArrayTypeArb = 0x8625,
		CurrentVertexAttribArb = 0x8626,
		ProgramLengthArb = 0x8627,
		ProgramStringArb = 0x8628,
		MaxProgramMatrixStackDepthArb = 0x862E,
		MaxProgramMatricesArb = 0x862F,
		CurrentMatrixStackDepthArb = 0x8640,
		CurrentMatrixArb = 0x8641,
		VertexProgramPointSizeArb = 0x8642,
		VertexProgramTwoSideArb = 0x8643,
		VertexAttribArrayPointerArb = 0x8645,
		ProgramErrorPositionArb = 0x864B,
		ProgramBindingArb = 0x8677,
		MaxVertexAttribsArb = 0x8869,
		VertexAttribArrayNormalizedArb = 0x886A,
		ProgramErrorStringArb = 0x8874,
		ProgramFormatAsciiArb = 0x8875,
		ProgramFormatArb = 0x8876,
		ProgramInstructionsArb = 0x88A0,
		MaxProgramInstructionsArb = 0x88A1,
		ProgramNativeInstructionsArb = 0x88A2,
		MaxProgramNativeInstructionsArb = 0x88A3,
		ProgramTemporariesArb = 0x88A4,
		MaxProgramTemporariesArb = 0x88A5,
		ProgramNativeTemporariesArb = 0x88A6,
		MaxProgramNativeTemporariesArb = 0x88A7,
		ProgramParametersArb = 0x88A8,
		MaxProgramParametersArb = 0x88A9,
		ProgramNativeParametersArb = 0x88AA,
		MaxProgramNativeParametersArb = 0x88AB,
		ProgramAttribsArb = 0x88AC,
		MaxProgramAttribsArb = 0x88AD,
		ProgramNativeAttribsArb = 0x88AE,
		MaxProgramNativeAttribsArb = 0x88AF,
		ProgramAddressRegistersArb = 0x88B0,
		MaxProgramAddressRegistersArb = 0x88B1,
		ProgramNativeAddressRegistersArb = 0x88B2,
		MaxProgramNativeAddressRegistersArb = 0x88B3,
		MaxProgramLocalParametersArb = 0x88B4,
		MaxProgramEnvParametersArb = 0x88B5,
		ProgramUnderNativeLimitsArb = 0x88B6,
		TransposeCurrentMatrixArb = 0x88B7,
		Matrix0Arb = 0x88C0,
		Matrix1Arb = 0x88C1,
		Matrix2Arb = 0x88C2,
		Matrix3Arb = 0x88C3,
		Matrix4Arb = 0x88C4,
		Matrix5Arb = 0x88C5,
		Matrix6Arb = 0x88C6,
		Matrix7Arb = 0x88C7,
		Matrix8Arb = 0x88C8,
		Matrix9Arb = 0x88C9,
		Matrix10Arb = 0x88CA,
		Matrix11Arb = 0x88CB,
		Matrix12Arb = 0x88CC,
		Matrix13Arb = 0x88CD,
		Matrix14Arb = 0x88CE,
		Matrix15Arb = 0x88CF,
		Matrix16Arb = 0x88D0,
		Matrix17Arb = 0x88D1,
		Matrix18Arb = 0x88D2,
		Matrix19Arb = 0x88D3,
		Matrix20Arb = 0x88D4,
		Matrix21Arb = 0x88D5,
		Matrix22Arb = 0x88D6,
		Matrix23Arb = 0x88D7,
		Matrix24Arb = 0x88D8,
		Matrix25Arb = 0x88D9,
		Matrix26Arb = 0x88DA,
		Matrix27Arb = 0x88DB,
		Matrix28Arb = 0x88DC,
		Matrix29Arb = 0x88DD,
		Matrix30Arb = 0x88DE,
		Matrix31Arb = 0x88DF,
	}
	public enum ARB_fragment_program : uint
	{
		FragmentProgramArb = 0x8804,
		ProgramAluInstructionsArb = 0x8805,
		ProgramTexInstructionsArb = 0x8806,
		ProgramTexIndirectionsArb = 0x8807,
		ProgramNativeAluInstructionsArb = 0x8808,
		ProgramNativeTexInstructionsArb = 0x8809,
		ProgramNativeTexIndirectionsArb = 0x880A,
		MaxProgramAluInstructionsArb = 0x880B,
		MaxProgramTexInstructionsArb = 0x880C,
		MaxProgramTexIndirectionsArb = 0x880D,
		MaxProgramNativeAluInstructionsArb = 0x880E,
		MaxProgramNativeTexInstructionsArb = 0x880F,
		MaxProgramNativeTexIndirectionsArb = 0x8810,
		MaxTextureCoordsArb = 0x8871,
		MaxTextureImageUnitsArb = 0x8872,
	}
	public enum ARB_vertex_buffer_object : uint
	{
		BufferSizeArb = 0x8764,
		BufferUsageArb = 0x8765,
		ArrayBufferArb = 0x8892,
		ElementArrayBufferArb = 0x8893,
		ArrayBufferBindingArb = 0x8894,
		ElementArrayBufferBindingArb = 0x8895,
		VertexArrayBufferBindingArb = 0x8896,
		NormalArrayBufferBindingArb = 0x8897,
		ColorArrayBufferBindingArb = 0x8898,
		IndexArrayBufferBindingArb = 0x8899,
		TextureCoordArrayBufferBindingArb = 0x889A,
		EdgeFlagArrayBufferBindingArb = 0x889B,
		SecondaryColorArrayBufferBindingArb = 0x889C,
		FogCoordinateArrayBufferBindingArb = 0x889D,
		WeightArrayBufferBindingArb = 0x889E,
		VertexAttribArrayBufferBindingArb = 0x889F,
		ReadOnlyArb = 0x88B8,
		WriteOnlyArb = 0x88B9,
		ReadWriteArb = 0x88BA,
		BufferAccessArb = 0x88BB,
		BufferMappedArb = 0x88BC,
		BufferMapPointerArb = 0x88BD,
		StreamDrawArb = 0x88E0,
		StreamReadArb = 0x88E1,
		StreamCopyArb = 0x88E2,
		StaticDrawArb = 0x88E4,
		StaticReadArb = 0x88E5,
		StaticCopyArb = 0x88E6,
		DynamicDrawArb = 0x88E8,
		DynamicReadArb = 0x88E9,
		DynamicCopyArb = 0x88EA,
	}
	public enum ARB_occlusion_query : uint
	{
		QueryCounterBitsArb = 0x8864,
		CurrentQueryArb = 0x8865,
		QueryResultArb = 0x8866,
		QueryResultAvailableArb = 0x8867,
		SamplesPassedArb = 0x8914,
	}
	public enum ARB_shader_objects : uint
	{
		ProgramObjectArb = 0x8B40,
		ShaderObjectArb = 0x8B48,
		ObjectTypeArb = 0x8B4E,
		ObjectSubtypeArb = 0x8B4F,
		FloatVec2Arb = 0x8B50,
		FloatVec3Arb = 0x8B51,
		FloatVec4Arb = 0x8B52,
		IntVec2Arb = 0x8B53,
		IntVec3Arb = 0x8B54,
		IntVec4Arb = 0x8B55,
		BoolArb = 0x8B56,
		BoolVec2Arb = 0x8B57,
		BoolVec3Arb = 0x8B58,
		BoolVec4Arb = 0x8B59,
		FloatMat2Arb = 0x8B5A,
		FloatMat3Arb = 0x8B5B,
		FloatMat4Arb = 0x8B5C,
		Sampler1dArb = 0x8B5D,
		Sampler2dArb = 0x8B5E,
		Sampler3dArb = 0x8B5F,
		SamplerCubeArb = 0x8B60,
		Sampler1dShadowArb = 0x8B61,
		Sampler2dShadowArb = 0x8B62,
		Sampler2dRectArb = 0x8B63,
		Sampler2dRectShadowArb = 0x8B64,
		ObjectDeleteStatusArb = 0x8B80,
		ObjectCompileStatusArb = 0x8B81,
		ObjectLinkStatusArb = 0x8B82,
		ObjectValidateStatusArb = 0x8B83,
		ObjectInfoLogLengthArb = 0x8B84,
		ObjectAttachedObjectsArb = 0x8B85,
		ObjectActiveUniformsArb = 0x8B86,
		ObjectActiveUniformMaxLengthArb = 0x8B87,
		ObjectShaderSourceLengthArb = 0x8B88,
	}
	public enum ARB_vertex_shader : uint
	{
		VertexShaderArb = 0x8B31,
		MaxVertexUniformComponentsArb = 0x8B4A,
		MaxVaryingFloatsArb = 0x8B4B,
		MaxVertexTextureImageUnitsArb = 0x8B4C,
		MaxCombinedTextureImageUnitsArb = 0x8B4D,
		ObjectActiveAttributesArb = 0x8B89,
		ObjectActiveAttributeMaxLengthArb = 0x8B8A,
	}
	public enum ARB_fragment_shader : uint
	{
		FragmentShaderArb = 0x8B30,
		MaxFragmentUniformComponentsArb = 0x8B49,
		FragmentShaderDerivativeHintArb = 0x8B8B,
	}
	public enum ARB_shading_language_100 : uint
	{
		ShadingLanguageVersionArb = 0x8B8C,
	}
	public enum ARB_texture_non_power_of_two : uint
	{
		}
	public enum ARB_point_sprite : uint
	{
		PointSpriteArb = 0x8861,
		CoordReplaceArb = 0x8862,
	}
	public enum ARB_fragment_program_shadow : uint
	{
		}
	public enum ARB_draw_buffers : uint
	{
		MaxDrawBuffersArb = 0x8824,
		DrawBuffer0Arb = 0x8825,
		DrawBuffer1Arb = 0x8826,
		DrawBuffer2Arb = 0x8827,
		DrawBuffer3Arb = 0x8828,
		DrawBuffer4Arb = 0x8829,
		DrawBuffer5Arb = 0x882A,
		DrawBuffer6Arb = 0x882B,
		DrawBuffer7Arb = 0x882C,
		DrawBuffer8Arb = 0x882D,
		DrawBuffer9Arb = 0x882E,
		DrawBuffer10Arb = 0x882F,
		DrawBuffer11Arb = 0x8830,
		DrawBuffer12Arb = 0x8831,
		DrawBuffer13Arb = 0x8832,
		DrawBuffer14Arb = 0x8833,
		DrawBuffer15Arb = 0x8834,
	}
	public enum ARB_texture_rectangle : uint
	{
		TextureRectangleArb = 0x84F5,
		TextureBindingRectangleArb = 0x84F6,
		ProxyTextureRectangleArb = 0x84F7,
		MaxRectangleTextureSizeArb = 0x84F8,
	}
	public enum ARB_color_buffer_float : uint
	{
		RgbaFloatModeArb = 0x8820,
		ClampVertexColorArb = 0x891A,
		ClampFragmentColorArb = 0x891B,
		ClampReadColorArb = 0x891C,
		FixedOnlyArb = 0x891D,
	}
	public enum ARB_half_float_pixel : uint
	{
		HalfFloatArb = 0x140B,
	}
	public enum ARB_texture_float : uint
	{
		TextureRedTypeArb = 0x8C10,
		TextureGreenTypeArb = 0x8C11,
		TextureBlueTypeArb = 0x8C12,
		TextureAlphaTypeArb = 0x8C13,
		TextureLuminanceTypeArb = 0x8C14,
		TextureIntensityTypeArb = 0x8C15,
		TextureDepthTypeArb = 0x8C16,
		UnsignedNormalizedArb = 0x8C17,
		Rgba32fArb = 0x8814,
		Rgb32fArb = 0x8815,
		Alpha32fArb = 0x8816,
		Intensity32fArb = 0x8817,
		Luminance32fArb = 0x8818,
		LuminanceAlpha32fArb = 0x8819,
		Rgba16fArb = 0x881A,
		Rgb16fArb = 0x881B,
		Alpha16fArb = 0x881C,
		Intensity16fArb = 0x881D,
		Luminance16fArb = 0x881E,
		LuminanceAlpha16fArb = 0x881F,
	}
	public enum ARB_pixel_buffer_object : uint
	{
		PixelPackBufferArb = 0x88EB,
		PixelUnpackBufferArb = 0x88EC,
		PixelPackBufferBindingArb = 0x88ED,
		PixelUnpackBufferBindingArb = 0x88EF,
	}
	public enum EXT_subtexture : uint
	{
		}
	public enum EXT_copy_texture : uint
	{
		}
	public enum EXT_misc_attribute : uint
	{
		}
	public enum EXT_blend_logic_op : uint
	{
		}
	public enum EXT_point_parameters : uint
	{
		PointSizeMinExt = 0x8126,
		PointSizeMaxExt = 0x8127,
		PointFadeThresholdSizeExt = 0x8128,
		DistanceAttenuationExt = 0x8129,
	}
	public enum SGIX_tag_sample_buffer : uint
	{
		}
	public enum SGIX_polynomial_ffd : uint
	{
		GeometryDeformationSgix = 0x8194,
		TextureDeformationSgix = 0x8195,
		DeformationsMaskSgix = 0x8196,
		MaxDeformationOrderSgix = 0x8197,
	}
	public enum SGIX_flush_raster : uint
	{
		}
	public enum HP_image_transform : uint
	{
		ImageScaleXHp = 0x8155,
		ImageScaleYHp = 0x8156,
		ImageTranslateXHp = 0x8157,
		ImageTranslateYHp = 0x8158,
		ImageRotateAngleHp = 0x8159,
		ImageRotateOriginXHp = 0x815A,
		ImageRotateOriginYHp = 0x815B,
		ImageMagFilterHp = 0x815C,
		ImageMinFilterHp = 0x815D,
		ImageCubicWeightHp = 0x815E,
		CubicHp = 0x815F,
		AverageHp = 0x8160,
		ImageTransform2dHp = 0x8161,
		PostImageTransformColorTableHp = 0x8162,
		ProxyPostImageTransformColorTableHp = 0x8163,
	}
	public enum INGR_palette_buffer : uint
	{
		}
	public enum EXT_color_subtable : uint
	{
		}
	public enum PGI_vertex_hints : uint
	{
		VertexDataHintPgi = 0x1A22A,
		VertexConsistentHintPgi = 0x1A22B,
		MaterialSideHintPgi = 0x1A22C,
		MaxVertexHintPgi = 0x1A22D,
		Color3BitPgi = 0x00010000,
		Color4BitPgi = 0x00020000,
		EdgeflagBitPgi = 0x00040000,
		IndexBitPgi = 0x00080000,
		MatAmbientBitPgi = 0x00100000,
		MatAmbientAndDiffuseBitPgi = 0x00200000,
		MatDiffuseBitPgi = 0x00400000,
		MatEmissionBitPgi = 0x00800000,
		MatColorIndexesBitPgi = 0x01000000,
		MatShininessBitPgi = 0x02000000,
		MatSpecularBitPgi = 0x04000000,
		NormalBitPgi = 0x08000000,
		Texcoord1BitPgi = 0x10000000,
		Texcoord2BitPgi = 0x20000000,
		Texcoord3BitPgi = 0x40000000,
		Texcoord4BitPgi = 0x80000000,
		Vertex23BitPgi = 0x00000004,
		Vertex4BitPgi = 0x00000008,
	}
	public enum PGI_misc_hints : uint
	{
		PreferDoublebufferHintPgi = 0x1A1F8,
		ConserveMemoryHintPgi = 0x1A1FD,
		ReclaimMemoryHintPgi = 0x1A1FE,
		NativeGraphicsHandlePgi = 0x1A202,
		NativeGraphicsBeginHintPgi = 0x1A203,
		NativeGraphicsEndHintPgi = 0x1A204,
		AlwaysFastHintPgi = 0x1A20C,
		AlwaysSoftHintPgi = 0x1A20D,
		AllowDrawObjHintPgi = 0x1A20E,
		AllowDrawWinHintPgi = 0x1A20F,
		AllowDrawFrgHintPgi = 0x1A210,
		AllowDrawMemHintPgi = 0x1A211,
		StrictDepthfuncHintPgi = 0x1A216,
		StrictLightingHintPgi = 0x1A217,
		StrictScissorHintPgi = 0x1A218,
		FullStippleHintPgi = 0x1A219,
		ClipNearHintPgi = 0x1A220,
		ClipFarHintPgi = 0x1A221,
		WideLineHintPgi = 0x1A222,
		BackNormalsHintPgi = 0x1A223,
	}
	public enum EXT_paletted_texture : uint
	{
		ColorIndex1Ext = 0x80E2,
		ColorIndex2Ext = 0x80E3,
		ColorIndex4Ext = 0x80E4,
		ColorIndex8Ext = 0x80E5,
		ColorIndex12Ext = 0x80E6,
		ColorIndex16Ext = 0x80E7,
		TextureIndexSizeExt = 0x80ED,
	}
	public enum EXT_clip_volume_hint : uint
	{
		ClipVolumeClippingHintExt = 0x80F0,
	}
	public enum EXT_index_texture : uint
	{
		}
	public enum EXT_index_material : uint
	{
		IndexMaterialExt = 0x81B8,
		IndexMaterialParameterExt = 0x81B9,
		IndexMaterialFaceExt = 0x81BA,
	}
	public enum EXT_index_func : uint
	{
		IndexTestExt = 0x81B5,
		IndexTestFuncExt = 0x81B6,
		IndexTestRefExt = 0x81B7,
	}
	public enum EXT_index_array_formats : uint
	{
		IuiV2fExt = 0x81AD,
		IuiV3fExt = 0x81AE,
		IuiN3fV2fExt = 0x81AF,
		IuiN3fV3fExt = 0x81B0,
		T2fIuiV2fExt = 0x81B1,
		T2fIuiV3fExt = 0x81B2,
		T2fIuiN3fV2fExt = 0x81B3,
		T2fIuiN3fV3fExt = 0x81B4,
	}
	public enum EXT_compiled_vertex_array : uint
	{
		ArrayElementLockFirstExt = 0x81A8,
		ArrayElementLockCountExt = 0x81A9,
	}
	public enum EXT_cull_vertex : uint
	{
		CullVertexExt = 0x81AA,
		CullVertexEyePositionExt = 0x81AB,
		CullVertexObjectPositionExt = 0x81AC,
	}
	public enum IBM_rasterpos_clip : uint
	{
		RasterPositionUnclippedIbm = 0x19262,
	}
	public enum HP_texture_lighting : uint
	{
		TextureLightingModeHp = 0x8167,
		TexturePostSpecularHp = 0x8168,
		TexturePreSpecularHp = 0x8169,
	}
	public enum EXT_draw_range_elements : uint
	{
		MaxElementsVerticesExt = 0x80E8,
		MaxElementsIndicesExt = 0x80E9,
	}
	public enum WIN_phong_shading : uint
	{
		PhongWin = 0x80EA,
		PhongHintWin = 0x80EB,
	}
	public enum WIN_specular_fog : uint
	{
		FogSpecularTextureWin = 0x80EC,
	}
	public enum EXT_light_texture : uint
	{
		FragmentMaterialExt = 0x8349,
		FragmentNormalExt = 0x834A,
		FragmentColorExt = 0x834C,
		AttenuationExt = 0x834D,
		ShadowAttenuationExt = 0x834E,
		TextureApplicationModeExt = 0x834F,
		TextureLightExt = 0x8350,
		TextureMaterialFaceExt = 0x8351,
		TextureMaterialParameterExt = 0x8352,
		FragmentDepthExt = EXT_fog_coord.FragmentDepthExt,
	}
	public enum SGIX_async : uint
	{
		AsyncMarkerSgix = 0x8329,
	}
	public enum INTEL_texture_scissor : uint
	{
		}
	public enum HP_occlusion_test : uint
	{
		OcclusionTestHp = 0x8165,
		OcclusionTestResultHp = 0x8166,
	}
	public enum EXT_pixel_transform_color_table : uint
	{
		}
	public enum EXT_secondary_color : uint
	{
		ColorSumExt = 0x8458,
		CurrentSecondaryColorExt = 0x8459,
		SecondaryColorArraySizeExt = 0x845A,
		SecondaryColorArrayTypeExt = 0x845B,
		SecondaryColorArrayStrideExt = 0x845C,
		SecondaryColorArrayPointerExt = 0x845D,
		SecondaryColorArrayExt = 0x845E,
	}
	public enum EXT_texture_perturb_normal : uint
	{
		PerturbExt = 0x85AE,
		TextureNormalExt = 0x85AF,
	}
	public enum EXT_multi_draw_arrays : uint
	{
		}
	public enum EXT_fog_coord : uint
	{
		FogCoordinateSourceExt = 0x8450,
		FogCoordinateExt = 0x8451,
		FragmentDepthExt = 0x8452,
		CurrentFogCoordinateExt = 0x8453,
		FogCoordinateArrayTypeExt = 0x8454,
		FogCoordinateArrayStrideExt = 0x8455,
		FogCoordinateArrayPointerExt = 0x8456,
		FogCoordinateArrayExt = 0x8457,
	}
	public enum REND_screen_coordinates : uint
	{
		ScreenCoordinatesRend = 0x8490,
		InvertedScreenWRend = 0x8491,
	}
	public enum EXT_coordinate_frame : uint
	{
		TangentArrayExt = 0x8439,
		BinormalArrayExt = 0x843A,
		CurrentTangentExt = 0x843B,
		CurrentBinormalExt = 0x843C,
		TangentArrayTypeExt = 0x843E,
		TangentArrayStrideExt = 0x843F,
		BinormalArrayTypeExt = 0x8440,
		BinormalArrayStrideExt = 0x8441,
		TangentArrayPointerExt = 0x8442,
		BinormalArrayPointerExt = 0x8443,
		Map1TangentExt = 0x8444,
		Map2TangentExt = 0x8445,
		Map1BinormalExt = 0x8446,
		Map2BinormalExt = 0x8447,
	}
	public enum EXT_texture_env_combine : uint
	{
		CombineExt = 0x8570,
		CombineRgbExt = 0x8571,
		CombineAlphaExt = 0x8572,
		RgbScaleExt = 0x8573,
		AddSignedExt = 0x8574,
		InterpolateExt = 0x8575,
		ConstantExt = 0x8576,
		PrimaryColorExt = 0x8577,
		PreviousExt = 0x8578,
		Source0RgbExt = 0x8580,
		Source1RgbExt = 0x8581,
		Source2RgbExt = 0x8582,
		Source0AlphaExt = 0x8588,
		Source1AlphaExt = 0x8589,
		Source2AlphaExt = 0x858A,
		Operand0RgbExt = 0x8590,
		Operand1RgbExt = 0x8591,
		Operand2RgbExt = 0x8592,
		Operand0AlphaExt = 0x8598,
		Operand1AlphaExt = 0x8599,
		Operand2AlphaExt = 0x859A,
	}
	public enum APPLE_specular_vector : uint
	{
		LightModelSpecularVectorApple = 0x85B0,
	}
	public enum APPLE_transform_hint : uint
	{
		TransformHintApple = 0x85B1,
	}
	public enum SGIX_fog_scale : uint
	{
		FogScaleSgix = 0x81FC,
		FogScaleValueSgix = 0x81FD,
	}
	public enum SUNX_constant_data : uint
	{
		UnpackConstantDataSunx = 0x81D5,
		TextureConstantDataSunx = 0x81D6,
	}
	public enum SUN_global_alpha : uint
	{
		GlobalAlphaSun = 0x81D9,
		GlobalAlphaFactorSun = 0x81DA,
	}
	public enum SUN_triangle_list : uint
	{
		RestartSun = 0x0001,
		ReplaceMiddleSun = 0x0002,
		ReplaceOldestSun = 0x0003,
		TriangleListSun = 0x81D7,
		ReplacementCodeSun = 0x81D8,
		ReplacementCodeArraySun = 0x85C0,
		ReplacementCodeArrayTypeSun = 0x85C1,
		ReplacementCodeArrayStrideSun = 0x85C2,
		ReplacementCodeArrayPointerSun = 0x85C3,
		R1uiV3fSun = 0x85C4,
		R1uiC4ubV3fSun = 0x85C5,
		R1uiC3fV3fSun = 0x85C6,
		R1uiN3fV3fSun = 0x85C7,
		R1uiC4fN3fV3fSun = 0x85C8,
		R1uiT2fV3fSun = 0x85C9,
		R1uiT2fN3fV3fSun = 0x85CA,
		R1uiT2fC4fN3fV3fSun = 0x85CB,
	}
	public enum SUN_vertex : uint
	{
		}
	public enum EXT_blend_func_separate : uint
	{
		BlendDstRgbExt = 0x80C8,
		BlendSrcRgbExt = 0x80C9,
		BlendDstAlphaExt = 0x80CA,
		BlendSrcAlphaExt = 0x80CB,
	}
	public enum INGR_color_clamp : uint
	{
		RedMinClampIngr = 0x8560,
		GreenMinClampIngr = 0x8561,
		BlueMinClampIngr = 0x8562,
		AlphaMinClampIngr = 0x8563,
		RedMaxClampIngr = 0x8564,
		GreenMaxClampIngr = 0x8565,
		BlueMaxClampIngr = 0x8566,
		AlphaMaxClampIngr = 0x8567,
	}
	public enum INGR_interlace_read : uint
	{
		InterlaceReadIngr = 0x8568,
	}
	public enum EXT_stencil_wrap : uint
	{
		IncrWrapExt = 0x8507,
		DecrWrapExt = 0x8508,
	}
	public enum EXT_422_pixels : uint
	{
		gl422Ext = 0x80CC,
		gl422RevExt = 0x80CD,
		gl422AverageExt = 0x80CE,
		gl422RevAverageExt = 0x80CF,
	}
	public enum NV_texgen_reflection : uint
	{
		NormalMapNv = 0x8511,
		ReflectionMapNv = 0x8512,
	}
	public enum EXT_texture_cube_map : uint
	{
		NormalMapExt = 0x8511,
		ReflectionMapExt = 0x8512,
		TextureCubeMapExt = 0x8513,
		TextureBindingCubeMapExt = 0x8514,
		TextureCubeMapPositiveXExt = 0x8515,
		TextureCubeMapNegativeXExt = 0x8516,
		TextureCubeMapPositiveYExt = 0x8517,
		TextureCubeMapNegativeYExt = 0x8518,
		TextureCubeMapPositiveZExt = 0x8519,
		TextureCubeMapNegativeZExt = 0x851A,
		ProxyTextureCubeMapExt = 0x851B,
		MaxCubeMapTextureSizeExt = 0x851C,
	}
	public enum SUN_convolution_border_modes : uint
	{
		WrapBorderSun = 0x81D4,
	}
	public enum EXT_texture_env_add : uint
	{
		}
	public enum EXT_texture_lod_bias : uint
	{
		MaxTextureLodBiasExt = 0x84FD,
		TextureFilterControlExt = 0x8500,
		TextureLodBiasExt = 0x8501,
	}
	public enum EXT_texture_filter_anisotropic : uint
	{
		TextureMaxAnisotropyExt = 0x84FE,
		MaxTextureMaxAnisotropyExt = 0x84FF,
	}
	public enum EXT_vertex_weighting : uint
	{
		Modelview1StackDepthExt = 0x8502,
		Modelview1MatrixExt = 0x8506,
		VertexWeightingExt = 0x8509,
		Modelview1Ext = 0x850A,
		CurrentVertexWeightExt = 0x850B,
		VertexWeightArrayExt = 0x850C,
		VertexWeightArraySizeExt = 0x850D,
		VertexWeightArrayTypeExt = 0x850E,
		VertexWeightArrayStrideExt = 0x850F,
		VertexWeightArrayPointerExt = 0x8510,
	}
	public enum NV_light_max_exponent : uint
	{
		MaxShininessNv = 0x8504,
		MaxSpotExponentNv = 0x8505,
	}
	public enum NV_vertex_array_range : uint
	{
		VertexArrayRangeNv = 0x851D,
		VertexArrayRangeLengthNv = 0x851E,
		VertexArrayRangeValidNv = 0x851F,
		MaxVertexArrayRangeElementNv = 0x8520,
		VertexArrayRangePointerNv = 0x8521,
	}
	public enum NV_register_combiners : uint
	{
		RegisterCombinersNv = 0x8522,
		VariableANv = 0x8523,
		VariableBNv = 0x8524,
		VariableCNv = 0x8525,
		VariableDNv = 0x8526,
		VariableENv = 0x8527,
		VariableFNv = 0x8528,
		VariableGNv = 0x8529,
		ConstantColor0Nv = 0x852A,
		ConstantColor1Nv = 0x852B,
		PrimaryColorNv = 0x852C,
		SecondaryColorNv = 0x852D,
		Spare0Nv = 0x852E,
		Spare1Nv = 0x852F,
		DiscardNv = 0x8530,
		ETimesFNv = 0x8531,
		Spare0PlusSecondaryColorNv = 0x8532,
		UnsignedIdentityNv = 0x8536,
		UnsignedInvertNv = 0x8537,
		ExpandNormalNv = 0x8538,
		ExpandNegateNv = 0x8539,
		HalfBiasNormalNv = 0x853A,
		HalfBiasNegateNv = 0x853B,
		SignedIdentityNv = 0x853C,
		SignedNegateNv = 0x853D,
		ScaleByTwoNv = 0x853E,
		ScaleByFourNv = 0x853F,
		ScaleByOneHalfNv = 0x8540,
		BiasByNegativeOneHalfNv = 0x8541,
		CombinerInputNv = 0x8542,
		CombinerMappingNv = 0x8543,
		CombinerComponentUsageNv = 0x8544,
		CombinerAbDotProductNv = 0x8545,
		CombinerCdDotProductNv = 0x8546,
		CombinerMuxSumNv = 0x8547,
		CombinerScaleNv = 0x8548,
		CombinerBiasNv = 0x8549,
		CombinerAbOutputNv = 0x854A,
		CombinerCdOutputNv = 0x854B,
		CombinerSumOutputNv = 0x854C,
		MaxGeneralCombinersNv = 0x854D,
		NumGeneralCombinersNv = 0x854E,
		ColorSumClampNv = 0x854F,
		Combiner0Nv = 0x8550,
		Combiner1Nv = 0x8551,
		Combiner2Nv = 0x8552,
		Combiner3Nv = 0x8553,
		Combiner4Nv = 0x8554,
		Combiner5Nv = 0x8555,
		Combiner6Nv = 0x8556,
		Combiner7Nv = 0x8557,
		Texture0Arb = ARB_multitexture.Texture0Arb,
		Texture1Arb = ARB_multitexture.Texture1Arb,
		Zero = BlendingFactorDest.Zero,
		None = DrawBufferMode.None,
		Fog = GetPName.Fog,
	}
	public enum NV_fog_distance : uint
	{
		FogDistanceModeNv = 0x855A,
		EyeRadialNv = 0x855B,
		EyePlaneAbsoluteNv = 0x855C,
		EyePlane = TextureGenParameter.EyePlane,
	}
	public enum NV_texgen_emboss : uint
	{
		EmbossLightNv = 0x855D,
		EmbossConstantNv = 0x855E,
		EmbossMapNv = 0x855F,
	}
	public enum NV_blend_square : uint
	{
		}
	public enum NV_texture_env_combine4 : uint
	{
		Combine4Nv = 0x8503,
		Source3RgbNv = 0x8583,
		Source3AlphaNv = 0x858B,
		Operand3RgbNv = 0x8593,
		Operand3AlphaNv = 0x859B,
	}
	public enum MESA_resize_buffers : uint
	{
		}
	public enum MESA_window_pos : uint
	{
		}
	public enum IBM_cull_vertex : uint
	{
		CullVertexIbm = 103050,
	}
	public enum IBM_multimode_draw_arrays : uint
	{
		}
	public enum IBM_vertex_array_lists : uint
	{
		VertexArrayListIbm = 103070,
		NormalArrayListIbm = 103071,
		ColorArrayListIbm = 103072,
		IndexArrayListIbm = 103073,
		TextureCoordArrayListIbm = 103074,
		EdgeFlagArrayListIbm = 103075,
		FogCoordinateArrayListIbm = 103076,
		SecondaryColorArrayListIbm = 103077,
		VertexArrayListStrideIbm = 103080,
		NormalArrayListStrideIbm = 103081,
		ColorArrayListStrideIbm = 103082,
		IndexArrayListStrideIbm = 103083,
		TextureCoordArrayListStrideIbm = 103084,
		EdgeFlagArrayListStrideIbm = 103085,
		FogCoordinateArrayListStrideIbm = 103086,
		SecondaryColorArrayListStrideIbm = 103087,
	}
	public enum SGIX_ycrcb_subsample : uint
	{
		PackSubsampleRateSgix = 0x85A0,
		UnpackSubsampleRateSgix = 0x85A1,
		PixelSubsample4444Sgix = 0x85A2,
		PixelSubsample2424Sgix = 0x85A3,
		PixelSubsample4242Sgix = 0x85A4,
	}
	public enum SGIX_ycrcba : uint
	{
		YcrcbSgix = 0x8318,
		YcrcbaSgix = 0x8319,
	}
	public enum SGI_depth_pass_instrument : uint
	{
		DepthPassInstrumentSgix = 0x8310,
		DepthPassInstrumentCountersSgix = 0x8311,
		DepthPassInstrumentMaxSgix = 0x8312,
	}
	public enum Gl3DFX_texture_compression_FXT1 : uint
	{
		CompressedRgbFxt13dfx = 0x86B0,
		CompressedRgbaFxt13dfx = 0x86B1,
	}
	public enum Gl3DFX_multisample : uint
	{
		Multisample3dfx = 0x86B2,
		SampleBuffers3dfx = 0x86B3,
		Samples3dfx = 0x86B4,
		MultisampleBit3dfx = 0x20000000,
	}
	public enum Gl3DFX_tbuffer : uint
	{
		}
	public enum EXT_multisample : uint
	{
		MultisampleExt = 0x809D,
		SampleAlphaToMaskExt = 0x809E,
		SampleAlphaToOneExt = 0x809F,
		SampleMaskExt = 0x80A0,
		gl1passExt = 0x80A1,
		gl2pass0Ext = 0x80A2,
		gl2pass1Ext = 0x80A3,
		gl4pass0Ext = 0x80A4,
		gl4pass1Ext = 0x80A5,
		gl4pass2Ext = 0x80A6,
		gl4pass3Ext = 0x80A7,
		SampleBuffersExt = 0x80A8,
		SamplesExt = 0x80A9,
		SampleMaskValueExt = 0x80AA,
		SampleMaskInvertExt = 0x80AB,
		SamplePatternExt = 0x80AC,
		MultisampleBitExt = 0x20000000,
	}
	public enum EXT_texture_env_dot3 : uint
	{
		Dot3RgbExt = 0x8740,
		Dot3RgbaExt = 0x8741,
	}
	public enum ATI_texture_mirror_once : uint
	{
		MirrorClampAti = 0x8742,
		MirrorClampToEdgeAti = 0x8743,
	}
	public enum NV_fence : uint
	{
		AllCompletedNv = 0x84F2,
		FenceStatusNv = 0x84F3,
		FenceConditionNv = 0x84F4,
	}
	public enum IBM_texture_mirrored_repeat : uint
	{
		MirroredRepeatIbm = 0x8370,
	}
	public enum NV_evaluators : uint
	{
		Eval2dNv = 0x86C0,
		EvalTriangular2dNv = 0x86C1,
		MapTessellationNv = 0x86C2,
		MapAttribUOrderNv = 0x86C3,
		MapAttribVOrderNv = 0x86C4,
		EvalFractionalTessellationNv = 0x86C5,
		EvalVertexAttrib0Nv = 0x86C6,
		EvalVertexAttrib1Nv = 0x86C7,
		EvalVertexAttrib2Nv = 0x86C8,
		EvalVertexAttrib3Nv = 0x86C9,
		EvalVertexAttrib4Nv = 0x86CA,
		EvalVertexAttrib5Nv = 0x86CB,
		EvalVertexAttrib6Nv = 0x86CC,
		EvalVertexAttrib7Nv = 0x86CD,
		EvalVertexAttrib8Nv = 0x86CE,
		EvalVertexAttrib9Nv = 0x86CF,
		EvalVertexAttrib10Nv = 0x86D0,
		EvalVertexAttrib11Nv = 0x86D1,
		EvalVertexAttrib12Nv = 0x86D2,
		EvalVertexAttrib13Nv = 0x86D3,
		EvalVertexAttrib14Nv = 0x86D4,
		EvalVertexAttrib15Nv = 0x86D5,
		MaxMapTessellationNv = 0x86D6,
		MaxRationalEvalOrderNv = 0x86D7,
	}
	public enum NV_packed_depth_stencil : uint
	{
		DepthStencilNv = 0x84F9,
		UnsignedInt248Nv = 0x84FA,
	}
	public enum NV_register_combiners2 : uint
	{
		PerStageConstantsNv = 0x8535,
	}
	public enum NV_texture_compression_vtc : uint
	{
		}
	public enum NV_texture_rectangle : uint
	{
		TextureRectangleNv = 0x84F5,
		TextureBindingRectangleNv = 0x84F6,
		ProxyTextureRectangleNv = 0x84F7,
		MaxRectangleTextureSizeNv = 0x84F8,
	}
	public enum NV_texture_shader : uint
	{
		OffsetTextureRectangleNv = 0x864C,
		OffsetTextureRectangleScaleNv = 0x864D,
		DotProductTextureRectangleNv = 0x864E,
		RgbaUnsignedDotProductMappingNv = 0x86D9,
		UnsignedIntS8S888Nv = 0x86DA,
		UnsignedInt88S8S8RevNv = 0x86DB,
		DsdtMagIntensityNv = 0x86DC,
		ShaderConsistentNv = 0x86DD,
		TextureShaderNv = 0x86DE,
		ShaderOperationNv = 0x86DF,
		CullModesNv = 0x86E0,
		OffsetTextureMatrixNv = 0x86E1,
		OffsetTextureScaleNv = 0x86E2,
		OffsetTextureBiasNv = 0x86E3,
		PreviousTextureInputNv = 0x86E4,
		ConstEyeNv = 0x86E5,
		PassThroughNv = 0x86E6,
		CullFragmentNv = 0x86E7,
		OffsetTexture2dNv = 0x86E8,
		DependentArTexture2dNv = 0x86E9,
		DependentGbTexture2dNv = 0x86EA,
		DotProductNv = 0x86EC,
		DotProductDepthReplaceNv = 0x86ED,
		DotProductTexture2dNv = 0x86EE,
		DotProductTextureCubeMapNv = 0x86F0,
		DotProductDiffuseCubeMapNv = 0x86F1,
		DotProductReflectCubeMapNv = 0x86F2,
		DotProductConstEyeReflectCubeMapNv = 0x86F3,
		HiloNv = 0x86F4,
		DsdtNv = 0x86F5,
		DsdtMagNv = 0x86F6,
		DsdtMagVibNv = 0x86F7,
		Hilo16Nv = 0x86F8,
		SignedHiloNv = 0x86F9,
		SignedHilo16Nv = 0x86FA,
		SignedRgbaNv = 0x86FB,
		SignedRgba8Nv = 0x86FC,
		SignedRgbNv = 0x86FE,
		SignedRgb8Nv = 0x86FF,
		SignedLuminanceNv = 0x8701,
		SignedLuminance8Nv = 0x8702,
		SignedLuminanceAlphaNv = 0x8703,
		SignedLuminance8Alpha8Nv = 0x8704,
		SignedAlphaNv = 0x8705,
		SignedAlpha8Nv = 0x8706,
		SignedIntensityNv = 0x8707,
		SignedIntensity8Nv = 0x8708,
		Dsdt8Nv = 0x8709,
		Dsdt8Mag8Nv = 0x870A,
		Dsdt8Mag8Intensity8Nv = 0x870B,
		SignedRgbUnsignedAlphaNv = 0x870C,
		SignedRgb8UnsignedAlpha8Nv = 0x870D,
		HiScaleNv = 0x870E,
		LoScaleNv = 0x870F,
		DsScaleNv = 0x8710,
		DtScaleNv = 0x8711,
		MagnitudeScaleNv = 0x8712,
		VibranceScaleNv = 0x8713,
		HiBiasNv = 0x8714,
		LoBiasNv = 0x8715,
		DsBiasNv = 0x8716,
		DtBiasNv = 0x8717,
		MagnitudeBiasNv = 0x8718,
		VibranceBiasNv = 0x8719,
		TextureBorderValuesNv = 0x871A,
		TextureHiSizeNv = 0x871B,
		TextureLoSizeNv = 0x871C,
		TextureDsSizeNv = 0x871D,
		TextureDtSizeNv = 0x871E,
		TextureMagSizeNv = 0x871F,
	}
	public enum NV_texture_shader2 : uint
	{
		DotProductTexture3dNv = 0x86EF,
	}
	public enum NV_vertex_array_range2 : uint
	{
		VertexArrayRangeWithoutFlushNv = 0x8533,
	}
	public enum NV_vertex_program : uint
	{
		VertexProgramNv = 0x8620,
		VertexStateProgramNv = 0x8621,
		AttribArraySizeNv = 0x8623,
		AttribArrayStrideNv = 0x8624,
		AttribArrayTypeNv = 0x8625,
		CurrentAttribNv = 0x8626,
		ProgramLengthNv = 0x8627,
		ProgramStringNv = 0x8628,
		ModelviewProjectionNv = 0x8629,
		IdentityNv = 0x862A,
		InverseNv = 0x862B,
		TransposeNv = 0x862C,
		InverseTransposeNv = 0x862D,
		MaxTrackMatrixStackDepthNv = 0x862E,
		MaxTrackMatricesNv = 0x862F,
		Matrix0Nv = 0x8630,
		Matrix1Nv = 0x8631,
		Matrix2Nv = 0x8632,
		Matrix3Nv = 0x8633,
		Matrix4Nv = 0x8634,
		Matrix5Nv = 0x8635,
		Matrix6Nv = 0x8636,
		Matrix7Nv = 0x8637,
		CurrentMatrixStackDepthNv = 0x8640,
		CurrentMatrixNv = 0x8641,
		VertexProgramPointSizeNv = 0x8642,
		VertexProgramTwoSideNv = 0x8643,
		ProgramParameterNv = 0x8644,
		AttribArrayPointerNv = 0x8645,
		ProgramTargetNv = 0x8646,
		ProgramResidentNv = 0x8647,
		TrackMatrixNv = 0x8648,
		TrackMatrixTransformNv = 0x8649,
		VertexProgramBindingNv = 0x864A,
		ProgramErrorPositionNv = 0x864B,
		VertexAttribArray0Nv = 0x8650,
		VertexAttribArray1Nv = 0x8651,
		VertexAttribArray2Nv = 0x8652,
		VertexAttribArray3Nv = 0x8653,
		VertexAttribArray4Nv = 0x8654,
		VertexAttribArray5Nv = 0x8655,
		VertexAttribArray6Nv = 0x8656,
		VertexAttribArray7Nv = 0x8657,
		VertexAttribArray8Nv = 0x8658,
		VertexAttribArray9Nv = 0x8659,
		VertexAttribArray10Nv = 0x865A,
		VertexAttribArray11Nv = 0x865B,
		VertexAttribArray12Nv = 0x865C,
		VertexAttribArray13Nv = 0x865D,
		VertexAttribArray14Nv = 0x865E,
		VertexAttribArray15Nv = 0x865F,
		Map1VertexAttrib04Nv = 0x8660,
		Map1VertexAttrib14Nv = 0x8661,
		Map1VertexAttrib24Nv = 0x8662,
		Map1VertexAttrib34Nv = 0x8663,
		Map1VertexAttrib44Nv = 0x8664,
		Map1VertexAttrib54Nv = 0x8665,
		Map1VertexAttrib64Nv = 0x8666,
		Map1VertexAttrib74Nv = 0x8667,
		Map1VertexAttrib84Nv = 0x8668,
		Map1VertexAttrib94Nv = 0x8669,
		Map1VertexAttrib104Nv = 0x866A,
		Map1VertexAttrib114Nv = 0x866B,
		Map1VertexAttrib124Nv = 0x866C,
		Map1VertexAttrib134Nv = 0x866D,
		Map1VertexAttrib144Nv = 0x866E,
		Map1VertexAttrib154Nv = 0x866F,
		Map2VertexAttrib04Nv = 0x8670,
		Map2VertexAttrib14Nv = 0x8671,
		Map2VertexAttrib24Nv = 0x8672,
		Map2VertexAttrib34Nv = 0x8673,
		Map2VertexAttrib44Nv = 0x8674,
		Map2VertexAttrib54Nv = 0x8675,
		Map2VertexAttrib64Nv = 0x8676,
		Map2VertexAttrib74Nv = 0x8677,
		Map2VertexAttrib84Nv = 0x8678,
		Map2VertexAttrib94Nv = 0x8679,
		Map2VertexAttrib104Nv = 0x867A,
		Map2VertexAttrib114Nv = 0x867B,
		Map2VertexAttrib124Nv = 0x867C,
		Map2VertexAttrib134Nv = 0x867D,
		Map2VertexAttrib144Nv = 0x867E,
		Map2VertexAttrib154Nv = 0x867F,
	}
	public enum SGIX_scalebias_hint : uint
	{
		ScalebiasHintSgix = 0x8322,
	}
	public enum OML_interlace : uint
	{
		InterlaceOml = 0x8980,
		InterlaceReadOml = 0x8981,
	}
	public enum OML_subsample : uint
	{
		FormatSubsample2424Oml = 0x8982,
		FormatSubsample244244Oml = 0x8983,
	}
	public enum OML_resample : uint
	{
		PackResampleOml = 0x8984,
		UnpackResampleOml = 0x8985,
		ResampleReplicateOml = 0x8986,
		ResampleZeroFillOml = 0x8987,
		ResampleAverageOml = 0x8988,
		ResampleDecimateOml = 0x8989,
	}
	public enum NV_copy_depth_to_color : uint
	{
		DepthStencilToRgbaNv = 0x886E,
		DepthStencilToBgraNv = 0x886F,
	}
	public enum ATI_envmap_bumpmap : uint
	{
		BumpRotMatrixAti = 0x8775,
		BumpRotMatrixSizeAti = 0x8776,
		BumpNumTexUnitsAti = 0x8777,
		BumpTexUnitsAti = 0x8778,
		DudvAti = 0x8779,
		Du8dv8Ati = 0x877A,
		BumpEnvmapAti = 0x877B,
		BumpTargetAti = 0x877C,
	}
	public enum ATI_fragment_shader : uint
	{
		FragmentShaderAti = 0x8920,
		Reg0Ati = 0x8921,
		Reg1Ati = 0x8922,
		Reg2Ati = 0x8923,
		Reg3Ati = 0x8924,
		Reg4Ati = 0x8925,
		Reg5Ati = 0x8926,
		Reg6Ati = 0x8927,
		Reg7Ati = 0x8928,
		Reg8Ati = 0x8929,
		Reg9Ati = 0x892A,
		Reg10Ati = 0x892B,
		Reg11Ati = 0x892C,
		Reg12Ati = 0x892D,
		Reg13Ati = 0x892E,
		Reg14Ati = 0x892F,
		Reg15Ati = 0x8930,
		Reg16Ati = 0x8931,
		Reg17Ati = 0x8932,
		Reg18Ati = 0x8933,
		Reg19Ati = 0x8934,
		Reg20Ati = 0x8935,
		Reg21Ati = 0x8936,
		Reg22Ati = 0x8937,
		Reg23Ati = 0x8938,
		Reg24Ati = 0x8939,
		Reg25Ati = 0x893A,
		Reg26Ati = 0x893B,
		Reg27Ati = 0x893C,
		Reg28Ati = 0x893D,
		Reg29Ati = 0x893E,
		Reg30Ati = 0x893F,
		Reg31Ati = 0x8940,
		Con0Ati = 0x8941,
		Con1Ati = 0x8942,
		Con2Ati = 0x8943,
		Con3Ati = 0x8944,
		Con4Ati = 0x8945,
		Con5Ati = 0x8946,
		Con6Ati = 0x8947,
		Con7Ati = 0x8948,
		Con8Ati = 0x8949,
		Con9Ati = 0x894A,
		Con10Ati = 0x894B,
		Con11Ati = 0x894C,
		Con12Ati = 0x894D,
		Con13Ati = 0x894E,
		Con14Ati = 0x894F,
		Con15Ati = 0x8950,
		Con16Ati = 0x8951,
		Con17Ati = 0x8952,
		Con18Ati = 0x8953,
		Con19Ati = 0x8954,
		Con20Ati = 0x8955,
		Con21Ati = 0x8956,
		Con22Ati = 0x8957,
		Con23Ati = 0x8958,
		Con24Ati = 0x8959,
		Con25Ati = 0x895A,
		Con26Ati = 0x895B,
		Con27Ati = 0x895C,
		Con28Ati = 0x895D,
		Con29Ati = 0x895E,
		Con30Ati = 0x895F,
		Con31Ati = 0x8960,
		MovAti = 0x8961,
		AddAti = 0x8963,
		MulAti = 0x8964,
		SubAti = 0x8965,
		Dot3Ati = 0x8966,
		Dot4Ati = 0x8967,
		MadAti = 0x8968,
		LerpAti = 0x8969,
		CndAti = 0x896A,
		Cnd0Ati = 0x896B,
		Dot2AddAti = 0x896C,
		SecondaryInterpolatorAti = 0x896D,
		NumFragmentRegistersAti = 0x896E,
		NumFragmentConstantsAti = 0x896F,
		NumPassesAti = 0x8970,
		NumInstructionsPerPassAti = 0x8971,
		NumInstructionsTotalAti = 0x8972,
		NumInputInterpolatorComponentsAti = 0x8973,
		NumLoopbackComponentsAti = 0x8974,
		ColorAlphaPairingAti = 0x8975,
		SwizzleStrAti = 0x8976,
		SwizzleStqAti = 0x8977,
		SwizzleStrDrAti = 0x8978,
		SwizzleStqDqAti = 0x8979,
		SwizzleStrqAti = 0x897A,
		SwizzleStrqDqAti = 0x897B,
		RedBitAti = 0x00000001,
		GreenBitAti = 0x00000002,
		BlueBitAti = 0x00000004,
		gl2xBitAti = 0x00000001,
		gl4xBitAti = 0x00000002,
		gl8xBitAti = 0x00000004,
		HalfBitAti = 0x00000008,
		QuarterBitAti = 0x00000010,
		EighthBitAti = 0x00000020,
		SaturateBitAti = 0x00000040,
		CompBitAti = 0x00000002,
		NegateBitAti = 0x00000004,
		BiasBitAti = 0x00000008,
	}
	public enum ATI_pn_triangles : uint
	{
		PnTrianglesAti = 0x87F0,
		MaxPnTrianglesTesselationLevelAti = 0x87F1,
		PnTrianglesPointModeAti = 0x87F2,
		PnTrianglesNormalModeAti = 0x87F3,
		PnTrianglesTesselationLevelAti = 0x87F4,
		PnTrianglesPointModeLinearAti = 0x87F5,
		PnTrianglesPointModeCubicAti = 0x87F6,
		PnTrianglesNormalModeLinearAti = 0x87F7,
		PnTrianglesNormalModeQuadraticAti = 0x87F8,
	}
	public enum ATI_vertex_array_object : uint
	{
		StaticAti = 0x8760,
		DynamicAti = 0x8761,
		PreserveAti = 0x8762,
		DiscardAti = 0x8763,
		ObjectBufferSizeAti = 0x8764,
		ObjectBufferUsageAti = 0x8765,
		ArrayObjectBufferAti = 0x8766,
		ArrayObjectOffsetAti = 0x8767,
	}
	public enum EXT_vertex_shader : uint
	{
		VertexShaderExt = 0x8780,
		VertexShaderBindingExt = 0x8781,
		OpIndexExt = 0x8782,
		OpNegateExt = 0x8783,
		OpDot3Ext = 0x8784,
		OpDot4Ext = 0x8785,
		OpMulExt = 0x8786,
		OpAddExt = 0x8787,
		OpMaddExt = 0x8788,
		OpFracExt = 0x8789,
		OpMaxExt = 0x878A,
		OpMinExt = 0x878B,
		OpSetGeExt = 0x878C,
		OpSetLtExt = 0x878D,
		OpClampExt = 0x878E,
		OpFloorExt = 0x878F,
		OpRoundExt = 0x8790,
		OpExpBase2Ext = 0x8791,
		OpLogBase2Ext = 0x8792,
		OpPowerExt = 0x8793,
		OpRecipExt = 0x8794,
		OpRecipSqrtExt = 0x8795,
		OpSubExt = 0x8796,
		OpCrossProductExt = 0x8797,
		OpMultiplyMatrixExt = 0x8798,
		OpMovExt = 0x8799,
		OutputVertexExt = 0x879A,
		OutputColor0Ext = 0x879B,
		OutputColor1Ext = 0x879C,
		OutputTextureCoord0Ext = 0x879D,
		OutputTextureCoord1Ext = 0x879E,
		OutputTextureCoord2Ext = 0x879F,
		OutputTextureCoord3Ext = 0x87A0,
		OutputTextureCoord4Ext = 0x87A1,
		OutputTextureCoord5Ext = 0x87A2,
		OutputTextureCoord6Ext = 0x87A3,
		OutputTextureCoord7Ext = 0x87A4,
		OutputTextureCoord8Ext = 0x87A5,
		OutputTextureCoord9Ext = 0x87A6,
		OutputTextureCoord10Ext = 0x87A7,
		OutputTextureCoord11Ext = 0x87A8,
		OutputTextureCoord12Ext = 0x87A9,
		OutputTextureCoord13Ext = 0x87AA,
		OutputTextureCoord14Ext = 0x87AB,
		OutputTextureCoord15Ext = 0x87AC,
		OutputTextureCoord16Ext = 0x87AD,
		OutputTextureCoord17Ext = 0x87AE,
		OutputTextureCoord18Ext = 0x87AF,
		OutputTextureCoord19Ext = 0x87B0,
		OutputTextureCoord20Ext = 0x87B1,
		OutputTextureCoord21Ext = 0x87B2,
		OutputTextureCoord22Ext = 0x87B3,
		OutputTextureCoord23Ext = 0x87B4,
		OutputTextureCoord24Ext = 0x87B5,
		OutputTextureCoord25Ext = 0x87B6,
		OutputTextureCoord26Ext = 0x87B7,
		OutputTextureCoord27Ext = 0x87B8,
		OutputTextureCoord28Ext = 0x87B9,
		OutputTextureCoord29Ext = 0x87BA,
		OutputTextureCoord30Ext = 0x87BB,
		OutputTextureCoord31Ext = 0x87BC,
		OutputFogExt = 0x87BD,
		ScalarExt = 0x87BE,
		VectorExt = 0x87BF,
		MatrixExt = 0x87C0,
		VariantExt = 0x87C1,
		InvariantExt = 0x87C2,
		LocalConstantExt = 0x87C3,
		LocalExt = 0x87C4,
		MaxVertexShaderInstructionsExt = 0x87C5,
		MaxVertexShaderVariantsExt = 0x87C6,
		MaxVertexShaderInvariantsExt = 0x87C7,
		MaxVertexShaderLocalConstantsExt = 0x87C8,
		MaxVertexShaderLocalsExt = 0x87C9,
		MaxOptimizedVertexShaderInstructionsExt = 0x87CA,
		MaxOptimizedVertexShaderVariantsExt = 0x87CB,
		MaxOptimizedVertexShaderLocalConstantsExt = 0x87CC,
		MaxOptimizedVertexShaderInvariantsExt = 0x87CD,
		MaxOptimizedVertexShaderLocalsExt = 0x87CE,
		VertexShaderInstructionsExt = 0x87CF,
		VertexShaderVariantsExt = 0x87D0,
		VertexShaderInvariantsExt = 0x87D1,
		VertexShaderLocalConstantsExt = 0x87D2,
		VertexShaderLocalsExt = 0x87D3,
		VertexShaderOptimizedExt = 0x87D4,
		XExt = 0x87D5,
		YExt = 0x87D6,
		ZExt = 0x87D7,
		WExt = 0x87D8,
		NegativeXExt = 0x87D9,
		NegativeYExt = 0x87DA,
		NegativeZExt = 0x87DB,
		NegativeWExt = 0x87DC,
		ZeroExt = 0x87DD,
		OneExt = 0x87DE,
		NegativeOneExt = 0x87DF,
		NormalizedRangeExt = 0x87E0,
		FullRangeExt = 0x87E1,
		CurrentVertexExt = 0x87E2,
		MvpMatrixExt = 0x87E3,
		VariantValueExt = 0x87E4,
		VariantDatatypeExt = 0x87E5,
		VariantArrayStrideExt = 0x87E6,
		VariantArrayTypeExt = 0x87E7,
		VariantArrayExt = 0x87E8,
		VariantArrayPointerExt = 0x87E9,
		InvariantValueExt = 0x87EA,
		InvariantDatatypeExt = 0x87EB,
		LocalConstantValueExt = 0x87EC,
		LocalConstantDatatypeExt = 0x87ED,
	}
	public enum ATI_vertex_streams : uint
	{
		MaxVertexStreamsAti = 0x876B,
		VertexStream0Ati = 0x876C,
		VertexStream1Ati = 0x876D,
		VertexStream2Ati = 0x876E,
		VertexStream3Ati = 0x876F,
		VertexStream4Ati = 0x8770,
		VertexStream5Ati = 0x8771,
		VertexStream6Ati = 0x8772,
		VertexStream7Ati = 0x8773,
		VertexSourceAti = 0x8774,
	}
	public enum ATI_element_array : uint
	{
		ElementArrayAti = 0x8768,
		ElementArrayTypeAti = 0x8769,
		ElementArrayPointerAti = 0x876A,
	}
	public enum SUN_mesh_array : uint
	{
		QuadMeshSun = 0x8614,
		TriangleMeshSun = 0x8615,
	}
	public enum SUN_slice_accum : uint
	{
		SliceAccumSun = 0x85CC,
	}
	public enum NV_multisample_filter_hint : uint
	{
		MultisampleFilterHintNv = 0x8534,
	}
	public enum NV_depth_clamp : uint
	{
		DepthClampNv = 0x864F,
	}
	public enum NV_occlusion_query : uint
	{
		PixelCounterBitsNv = 0x8864,
		CurrentOcclusionQueryIdNv = 0x8865,
		PixelCountNv = 0x8866,
		PixelCountAvailableNv = 0x8867,
	}
	public enum NV_point_sprite : uint
	{
		PointSpriteNv = 0x8861,
		CoordReplaceNv = 0x8862,
		PointSpriteRModeNv = 0x8863,
	}
	public enum NV_texture_shader3 : uint
	{
		OffsetProjectiveTexture2dNv = 0x8850,
		OffsetProjectiveTexture2dScaleNv = 0x8851,
		OffsetProjectiveTextureRectangleNv = 0x8852,
		OffsetProjectiveTextureRectangleScaleNv = 0x8853,
		OffsetHiloTexture2dNv = 0x8854,
		OffsetHiloTextureRectangleNv = 0x8855,
		OffsetHiloProjectiveTexture2dNv = 0x8856,
		OffsetHiloProjectiveTextureRectangleNv = 0x8857,
		DependentHiloTexture2dNv = 0x8858,
		DependentRgbTexture3dNv = 0x8859,
		DependentRgbTextureCubeMapNv = 0x885A,
		DotProductPassThroughNv = 0x885B,
		DotProductTexture1dNv = 0x885C,
		DotProductAffineDepthReplaceNv = 0x885D,
		Hilo8Nv = 0x885E,
		SignedHilo8Nv = 0x885F,
		ForceBlueToOneNv = 0x8860,
	}
	public enum NV_vertex_program1_1 : uint
	{
		}
	public enum EXT_shadow_funcs : uint
	{
		}
	public enum EXT_stencil_two_side : uint
	{
		StencilTestTwoSideExt = 0x8910,
		ActiveStencilFaceExt = 0x8911,
	}
	public enum ATI_text_fragment_shader : uint
	{
		TextFragmentShaderAti = 0x8200,
	}
	public enum APPLE_client_storage : uint
	{
		UnpackClientStorageApple = 0x85B2,
	}
	public enum APPLE_element_array : uint
	{
		ElementArrayApple = 0x8768,
		ElementArrayTypeApple = 0x8769,
		ElementArrayPointerApple = 0x876A,
	}
	public enum APPLE_fence : uint
	{
		DrawPixelsApple = 0x8A0A,
		FenceApple = 0x8A0B,
	}
	public enum APPLE_vertex_array_object : uint
	{
		VertexArrayBindingApple = 0x85B5,
	}
	public enum APPLE_vertex_array_range : uint
	{
		VertexArrayRangeApple = 0x851D,
		VertexArrayRangeLengthApple = 0x851E,
		VertexArrayStorageHintApple = 0x851F,
		VertexArrayRangePointerApple = 0x8521,
		StorageCachedApple = 0x85BE,
		StorageSharedApple = 0x85BF,
	}
	public enum APPLE_ycbcr_422 : uint
	{
		Ycbcr422Apple = 0x85B9,
		UnsignedShort88Apple = 0x85BA,
		UnsignedShort88RevApple = 0x85BB,
	}
	public enum S3_s3tc : uint
	{
		RgbS3tc = 0x83A0,
		Rgb4S3tc = 0x83A1,
		RgbaS3tc = 0x83A2,
		Rgba4S3tc = 0x83A3,
	}
	public enum ATI_draw_buffers : uint
	{
		MaxDrawBuffersAti = 0x8824,
		DrawBuffer0Ati = 0x8825,
		DrawBuffer1Ati = 0x8826,
		DrawBuffer2Ati = 0x8827,
		DrawBuffer3Ati = 0x8828,
		DrawBuffer4Ati = 0x8829,
		DrawBuffer5Ati = 0x882A,
		DrawBuffer6Ati = 0x882B,
		DrawBuffer7Ati = 0x882C,
		DrawBuffer8Ati = 0x882D,
		DrawBuffer9Ati = 0x882E,
		DrawBuffer10Ati = 0x882F,
		DrawBuffer11Ati = 0x8830,
		DrawBuffer12Ati = 0x8831,
		DrawBuffer13Ati = 0x8832,
		DrawBuffer14Ati = 0x8833,
		DrawBuffer15Ati = 0x8834,
	}
	public enum ATI_pixel_format_float : uint
	{
		TypeRgbaFloatAti = 0x8820,
		ColorClearUnclampedValueAti = 0x8835,
	}
	public enum ATI_texture_env_combine3 : uint
	{
		ModulateAddAti = 0x8744,
		ModulateSignedAddAti = 0x8745,
		ModulateSubtractAti = 0x8746,
	}
	public enum ATI_texture_float : uint
	{
		RgbaFloat32Ati = 0x8814,
		RgbFloat32Ati = 0x8815,
		AlphaFloat32Ati = 0x8816,
		IntensityFloat32Ati = 0x8817,
		LuminanceFloat32Ati = 0x8818,
		LuminanceAlphaFloat32Ati = 0x8819,
		RgbaFloat16Ati = 0x881A,
		RgbFloat16Ati = 0x881B,
		AlphaFloat16Ati = 0x881C,
		IntensityFloat16Ati = 0x881D,
		LuminanceFloat16Ati = 0x881E,
		LuminanceAlphaFloat16Ati = 0x881F,
	}
	public enum NV_float_buffer : uint
	{
		FloatRNv = 0x8880,
		FloatRgNv = 0x8881,
		FloatRgbNv = 0x8882,
		FloatRgbaNv = 0x8883,
		FloatR16Nv = 0x8884,
		FloatR32Nv = 0x8885,
		FloatRg16Nv = 0x8886,
		FloatRg32Nv = 0x8887,
		FloatRgb16Nv = 0x8888,
		FloatRgb32Nv = 0x8889,
		FloatRgba16Nv = 0x888A,
		FloatRgba32Nv = 0x888B,
		TextureFloatComponentsNv = 0x888C,
		FloatClearColorValueNv = 0x888D,
		FloatRgbaModeNv = 0x888E,
	}
	public enum NV_fragment_program : uint
	{
		MaxFragmentProgramLocalParametersNv = 0x8868,
		FragmentProgramNv = 0x8870,
		MaxTextureCoordsNv = 0x8871,
		MaxTextureImageUnitsNv = 0x8872,
		FragmentProgramBindingNv = 0x8873,
		ProgramErrorStringNv = 0x8874,
	}
	public enum NV_half_float : uint
	{
		HalfFloatNv = 0x140B,
	}
	public enum NV_pixel_data_range : uint
	{
		WritePixelDataRangeNv = 0x8878,
		ReadPixelDataRangeNv = 0x8879,
		WritePixelDataRangeLengthNv = 0x887A,
		ReadPixelDataRangeLengthNv = 0x887B,
		WritePixelDataRangePointerNv = 0x887C,
		ReadPixelDataRangePointerNv = 0x887D,
	}
	public enum NV_primitive_restart : uint
	{
		PrimitiveRestartNv = 0x8558,
		PrimitiveRestartIndexNv = 0x8559,
	}
	public enum NV_texture_expand_normal : uint
	{
		TextureUnsignedRemapModeNv = 0x888F,
	}
	public enum NV_vertex_program2 : uint
	{
		}
	public enum ATI_map_object_buffer : uint
	{
		}
	public enum ATI_separate_stencil : uint
	{
		StencilBackFuncAti = 0x8800,
		StencilBackFailAti = 0x8801,
		StencilBackPassDepthFailAti = 0x8802,
		StencilBackPassDepthPassAti = 0x8803,
	}
	public enum ATI_vertex_attrib_array_object : uint
	{
		}
	public enum OES_read_format : uint
	{
		ImplementationColorReadTypeOes = 0x8B9A,
		ImplementationColorReadFormatOes = 0x8B9B,
	}
	public enum EXT_depth_bounds_test : uint
	{
		DepthBoundsTestExt = 0x8890,
		DepthBoundsExt = 0x8891,
	}
	public enum EXT_texture_mirror_clamp : uint
	{
		MirrorClampExt = 0x8742,
		MirrorClampToEdgeExt = 0x8743,
		MirrorClampToBorderExt = 0x8912,
	}
	public enum EXT_blend_equation_separate : uint
	{
		BlendEquationAlphaExt = 0x883D,
	}
	public enum MESA_pack_invert : uint
	{
		PackInvertMesa = 0x8758,
	}
	public enum MESA_ycbcr_texture : uint
	{
		UnsignedShort88Mesa = 0x85BA,
		UnsignedShort88RevMesa = 0x85BB,
		YcbcrMesa = 0x8757,
	}
	public enum EXT_pixel_buffer_object : uint
	{
		PixelPackBufferExt = 0x88EB,
		PixelUnpackBufferExt = 0x88EC,
		PixelPackBufferBindingExt = 0x88ED,
		PixelUnpackBufferBindingExt = 0x88EF,
	}
	public enum NV_fragment_program_option : uint
	{
		}
	public enum NV_fragment_program2 : uint
	{
		MaxProgramExecInstructionsNv = 0x88F4,
		MaxProgramCallDepthNv = 0x88F5,
		MaxProgramIfDepthNv = 0x88F6,
		MaxProgramLoopDepthNv = 0x88F7,
		MaxProgramLoopCountNv = 0x88F8,
	}
	public enum NV_vertex_program2_option : uint
	{
		MaxProgramExecInstructionsNv = NV_fragment_program2.MaxProgramExecInstructionsNv,
		MaxProgramCallDepthNv = NV_fragment_program2.MaxProgramCallDepthNv,
	}
	public enum NV_vertex_program3 : uint
	{
		MaxVertexTextureImageUnitsArb = ARB_vertex_shader.MaxVertexTextureImageUnitsArb,
	}
	public enum EXT_framebuffer_object : uint
	{
		InvalidFramebufferOperationExt = 0x0506,
		MaxRenderbufferSizeExt = 0x84E8,
		FramebufferBindingExt = 0x8CA6,
		RenderbufferBindingExt = 0x8CA7,
		FramebufferAttachmentObjectTypeExt = 0x8CD0,
		FramebufferAttachmentObjectNameExt = 0x8CD1,
		FramebufferAttachmentTextureLevelExt = 0x8CD2,
		FramebufferAttachmentTextureCubeMapFaceExt = 0x8CD3,
		FramebufferAttachmentTexture3dZoffsetExt = 0x8CD4,
		FramebufferCompleteExt = 0x8CD5,
		FramebufferIncompleteAttachmentExt = 0x8CD6,
		FramebufferIncompleteMissingAttachmentExt = 0x8CD7,
		FramebufferIncompleteDimensionsExt = 0x8CD9,
		FramebufferIncompleteFormatsExt = 0x8CDA,
		FramebufferIncompleteDrawBufferExt = 0x8CDB,
		FramebufferIncompleteReadBufferExt = 0x8CDC,
		FramebufferUnsupportedExt = 0x8CDD,
		MaxColorAttachmentsExt = 0x8CDF,
		ColorAttachment0Ext = 0x8CE0,
		ColorAttachment1Ext = 0x8CE1,
		ColorAttachment2Ext = 0x8CE2,
		ColorAttachment3Ext = 0x8CE3,
		ColorAttachment4Ext = 0x8CE4,
		ColorAttachment5Ext = 0x8CE5,
		ColorAttachment6Ext = 0x8CE6,
		ColorAttachment7Ext = 0x8CE7,
		ColorAttachment8Ext = 0x8CE8,
		ColorAttachment9Ext = 0x8CE9,
		ColorAttachment10Ext = 0x8CEA,
		ColorAttachment11Ext = 0x8CEB,
		ColorAttachment12Ext = 0x8CEC,
		ColorAttachment13Ext = 0x8CED,
		ColorAttachment14Ext = 0x8CEE,
		ColorAttachment15Ext = 0x8CEF,
		DepthAttachmentExt = 0x8D00,
		StencilAttachmentExt = 0x8D20,
		FramebufferExt = 0x8D40,
		RenderbufferExt = 0x8D41,
		RenderbufferWidthExt = 0x8D42,
		RenderbufferHeightExt = 0x8D43,
		RenderbufferInternalFormatExt = 0x8D44,
		StencilIndex1Ext = 0x8D46,
		StencilIndex4Ext = 0x8D47,
		StencilIndex8Ext = 0x8D48,
		StencilIndex16Ext = 0x8D49,
		RenderbufferRedSizeExt = 0x8D50,
		RenderbufferGreenSizeExt = 0x8D51,
		RenderbufferBlueSizeExt = 0x8D52,
		RenderbufferAlphaSizeExt = 0x8D53,
		RenderbufferDepthSizeExt = 0x8D54,
		RenderbufferStencilSizeExt = 0x8D55,
	}
	public enum GREMEDY_string_marker : uint
	{
		}
	public enum EXT_packed_depth_stencil : uint
	{
		DepthStencilExt = 0x84F9,
		UnsignedInt248Ext = 0x84FA,
		Depth24Stencil8Ext = 0x88F0,
		TextureStencilSizeExt = 0x88F1,
	}
	public enum EXT_stencil_clear_tag : uint
	{
		StencilTagBitsExt = 0x88F2,
		StencilClearTagValueExt = 0x88F3,
	}
	public enum EXT_texture_sRGB : uint
	{
		SrgbExt = 0x8C40,
		Srgb8Ext = 0x8C41,
		SrgbAlphaExt = 0x8C42,
		Srgb8Alpha8Ext = 0x8C43,
		SluminanceAlphaExt = 0x8C44,
		Sluminance8Alpha8Ext = 0x8C45,
		SluminanceExt = 0x8C46,
		Sluminance8Ext = 0x8C47,
		CompressedSrgbExt = 0x8C48,
		CompressedSrgbAlphaExt = 0x8C49,
		CompressedSluminanceExt = 0x8C4A,
		CompressedSluminanceAlphaExt = 0x8C4B,
		CompressedSrgbS3tcDxt1Ext = 0x8C4C,
		CompressedSrgbAlphaS3tcDxt1Ext = 0x8C4D,
		CompressedSrgbAlphaS3tcDxt3Ext = 0x8C4E,
		CompressedSrgbAlphaS3tcDxt5Ext = 0x8C4F,
	}
	public enum EXT_framebuffer_blit : uint
	{
		ReadFramebufferExt = 0x8CA8,
		DrawFramebufferExt = 0x8CA9,
		ReadFramebufferBindingExt = 0x8CAA,
	}
	public enum EXT_framebuffer_multisample : uint
	{
		RenderbufferSamplesExt = 0x8CAB,
		FramebufferIncompleteMultisampleExt = 0x8D56,
		MaxSamplesExt = 0x8D57,
	}
	public enum MESAX_texture_stack : uint
	{
		Texture1dStackMesax = 0x8759,
		Texture2dStackMesax = 0x875A,
		ProxyTexture1dStackMesax = 0x875B,
		ProxyTexture2dStackMesax = 0x875C,
		Texture1dStackBindingMesax = 0x875D,
		Texture2dStackBindingMesax = 0x875E,
	}
	public enum EXT_timer_query : uint
	{
		TimeElapsedExt = 0x88BF,
	}
	public enum EXT_gpu_program_parameters : uint
	{
		}
	public enum APPLE_flush_buffer_range : uint
	{
		BufferSerializedModifyApple = 0x8A12,
		BufferFlushingUnmapApple = 0x8A13,
	}
	public enum NV_gpu_program4 : uint
	{
		MinProgramTexelOffsetNv = 0x8904,
		MaxProgramTexelOffsetNv = 0x8905,
		ProgramAttribComponentsNv = 0x8906,
		ProgramResultComponentsNv = 0x8907,
		MaxProgramAttribComponentsNv = 0x8908,
		MaxProgramResultComponentsNv = 0x8909,
		MaxProgramGenericAttribsNv = 0x8DA5,
		MaxProgramGenericResultsNv = 0x8DA6,
	}
	public enum NV_geometry_program4 : uint
	{
		LinesAdjacencyExt = 0x000A,
		LineStripAdjacencyExt = 0x000B,
		TrianglesAdjacencyExt = 0x000C,
		TriangleStripAdjacencyExt = 0x000D,
		GeometryProgramNv = 0x8C26,
		MaxProgramOutputVerticesNv = 0x8C27,
		MaxProgramTotalOutputComponentsNv = 0x8C28,
		GeometryVerticesOutExt = 0x8DDA,
		GeometryInputTypeExt = 0x8DDB,
		GeometryOutputTypeExt = 0x8DDC,
		MaxGeometryTextureImageUnitsExt = 0x8C29,
		FramebufferAttachmentLayeredExt = 0x8DA7,
		FramebufferIncompleteLayerTargetsExt = 0x8DA8,
		FramebufferIncompleteLayerCountExt = 0x8DA9,
		FramebufferAttachmentTextureLayerExt = 0x8CD4,
		ProgramPointSizeExt = 0x8642,
	}
	public enum EXT_geometry_shader4 : uint
	{
		GeometryShaderExt = 0x8DD9,
		GeometryVerticesOutExt = NV_geometry_program4.GeometryVerticesOutExt,
		GeometryInputTypeExt = NV_geometry_program4.GeometryInputTypeExt,
		GeometryOutputTypeExt = NV_geometry_program4.GeometryOutputTypeExt,
		MaxGeometryTextureImageUnitsExt = NV_geometry_program4.MaxGeometryTextureImageUnitsExt,
		MaxGeometryVaryingComponentsExt = 0x8DDD,
		MaxVertexVaryingComponentsExt = 0x8DDE,
		MaxVaryingComponentsExt = 0x8B4B,
		MaxGeometryUniformComponentsExt = 0x8DDF,
		MaxGeometryOutputVerticesExt = 0x8DE0,
		MaxGeometryTotalOutputComponentsExt = 0x8DE1,
		LinesAdjacencyExt = NV_geometry_program4.LinesAdjacencyExt,
		LineStripAdjacencyExt = NV_geometry_program4.LineStripAdjacencyExt,
		TrianglesAdjacencyExt = NV_geometry_program4.TrianglesAdjacencyExt,
		TriangleStripAdjacencyExt = NV_geometry_program4.TriangleStripAdjacencyExt,
		FramebufferIncompleteLayerTargetsExt = NV_geometry_program4.FramebufferIncompleteLayerTargetsExt,
		FramebufferIncompleteLayerCountExt = NV_geometry_program4.FramebufferIncompleteLayerCountExt,
		FramebufferAttachmentLayeredExt = NV_geometry_program4.FramebufferAttachmentLayeredExt,
		FramebufferAttachmentTextureLayerExt = NV_geometry_program4.FramebufferAttachmentTextureLayerExt,
		ProgramPointSizeExt = NV_geometry_program4.ProgramPointSizeExt,
	}
	public enum NV_vertex_program4 : uint
	{
		VertexAttribArrayIntegerNv = 0x88FD,
	}
	public enum EXT_gpu_shader4 : uint
	{
		Sampler1dArrayExt = 0x8DC0,
		Sampler2dArrayExt = 0x8DC1,
		SamplerBufferExt = 0x8DC2,
		Sampler1dArrayShadowExt = 0x8DC3,
		Sampler2dArrayShadowExt = 0x8DC4,
		SamplerCubeShadowExt = 0x8DC5,
		UnsignedIntVec2Ext = 0x8DC6,
		UnsignedIntVec3Ext = 0x8DC7,
		UnsignedIntVec4Ext = 0x8DC8,
		IntSampler1dExt = 0x8DC9,
		IntSampler2dExt = 0x8DCA,
		IntSampler3dExt = 0x8DCB,
		IntSamplerCubeExt = 0x8DCC,
		IntSampler2dRectExt = 0x8DCD,
		IntSampler1dArrayExt = 0x8DCE,
		IntSampler2dArrayExt = 0x8DCF,
		IntSamplerBufferExt = 0x8DD0,
		UnsignedIntSampler1dExt = 0x8DD1,
		UnsignedIntSampler2dExt = 0x8DD2,
		UnsignedIntSampler3dExt = 0x8DD3,
		UnsignedIntSamplerCubeExt = 0x8DD4,
		UnsignedIntSampler2dRectExt = 0x8DD5,
		UnsignedIntSampler1dArrayExt = 0x8DD6,
		UnsignedIntSampler2dArrayExt = 0x8DD7,
		UnsignedIntSamplerBufferExt = 0x8DD8,
	}
	public enum EXT_draw_instanced : uint
	{
		}
	public enum EXT_packed_float : uint
	{
		R11fG11fB10fExt = 0x8C3A,
		UnsignedInt10f11f11fRevExt = 0x8C3B,
		RgbaSignedComponentsExt = 0x8C3C,
	}
	public enum EXT_texture_array : uint
	{
		Texture1dArrayExt = 0x8C18,
		ProxyTexture1dArrayExt = 0x8C19,
		Texture2dArrayExt = 0x8C1A,
		ProxyTexture2dArrayExt = 0x8C1B,
		TextureBinding1dArrayExt = 0x8C1C,
		TextureBinding2dArrayExt = 0x8C1D,
		MaxArrayTextureLayersExt = 0x88FF,
		CompareRefDepthToTextureExt = 0x884E,
		FramebufferAttachmentTextureLayerExt = NV_geometry_program4.FramebufferAttachmentTextureLayerExt,
	}
	public enum EXT_texture_buffer_object : uint
	{
		TextureBufferExt = 0x8C2A,
		MaxTextureBufferSizeExt = 0x8C2B,
		TextureBindingBufferExt = 0x8C2C,
		TextureBufferDataStoreBindingExt = 0x8C2D,
		TextureBufferFormatExt = 0x8C2E,
	}
	public enum EXT_texture_compression_latc : uint
	{
		CompressedLuminanceLatc1Ext = 0x8C70,
		CompressedSignedLuminanceLatc1Ext = 0x8C71,
		CompressedLuminanceAlphaLatc2Ext = 0x8C72,
		CompressedSignedLuminanceAlphaLatc2Ext = 0x8C73,
	}
	public enum EXT_texture_compression_rgtc : uint
	{
		CompressedRedRgtc1Ext = 0x8DBB,
		CompressedSignedRedRgtc1Ext = 0x8DBC,
		CompressedRedGreenRgtc2Ext = 0x8DBD,
		CompressedSignedRedGreenRgtc2Ext = 0x8DBE,
	}
	public enum EXT_texture_shared_exponent : uint
	{
		Rgb9E5Ext = 0x8C3D,
		UnsignedInt5999RevExt = 0x8C3E,
		TextureSharedSizeExt = 0x8C3F,
	}
	public enum NV_depth_buffer_float : uint
	{
		DepthComponent32fNv = 0x8DAB,
		Depth32fStencil8Nv = 0x8DAC,
		Float32UnsignedInt248RevNv = 0x8DAD,
		DepthBufferFloatModeNv = 0x8DAF,
	}
	public enum NV_fragment_program4 : uint
	{
		}
	public enum NV_framebuffer_multisample_coverage : uint
	{
		RenderbufferCoverageSamplesNv = 0x8CAB,
		RenderbufferColorSamplesNv = 0x8E10,
		MaxMultisampleCoverageModesNv = 0x8E11,
		MultisampleCoverageModesNv = 0x8E12,
	}
	public enum EXT_framebuffer_sRGB : uint
	{
		FramebufferSrgbExt = 0x8DB9,
		FramebufferSrgbCapableExt = 0x8DBA,
	}
	public enum NV_geometry_shader4 : uint
	{
		}
	public enum NV_parameter_buffer_object : uint
	{
		MaxProgramParameterBufferBindingsNv = 0x8DA0,
		MaxProgramParameterBufferSizeNv = 0x8DA1,
		VertexProgramParameterBufferNv = 0x8DA2,
		GeometryProgramParameterBufferNv = 0x8DA3,
		FragmentProgramParameterBufferNv = 0x8DA4,
	}
	public enum EXT_draw_buffers2 : uint
	{
		}
	public enum NV_transform_feedback : uint
	{
		BackPrimaryColorNv = 0x8C77,
		BackSecondaryColorNv = 0x8C78,
		TextureCoordNv = 0x8C79,
		ClipDistanceNv = 0x8C7A,
		VertexIdNv = 0x8C7B,
		PrimitiveIdNv = 0x8C7C,
		GenericAttribNv = 0x8C7D,
		TransformFeedbackAttribsNv = 0x8C7E,
		TransformFeedbackBufferModeNv = 0x8C7F,
		MaxTransformFeedbackSeparateComponentsNv = 0x8C80,
		ActiveVaryingsNv = 0x8C81,
		ActiveVaryingMaxLengthNv = 0x8C82,
		TransformFeedbackVaryingsNv = 0x8C83,
		TransformFeedbackBufferStartNv = 0x8C84,
		TransformFeedbackBufferSizeNv = 0x8C85,
		TransformFeedbackRecordNv = 0x8C86,
		PrimitivesGeneratedNv = 0x8C87,
		TransformFeedbackPrimitivesWrittenNv = 0x8C88,
		RasterizerDiscardNv = 0x8C89,
		MaxTransformFeedbackInterleavedAttribsNv = 0x8C8A,
		MaxTransformFeedbackSeparateAttribsNv = 0x8C8B,
		InterleavedAttribsNv = 0x8C8C,
		SeparateAttribsNv = 0x8C8D,
		TransformFeedbackBufferNv = 0x8C8E,
		TransformFeedbackBufferBindingNv = 0x8C8F,
	}
	public enum EXT_bindable_uniform : uint
	{
		MaxVertexBindableUniformsExt = 0x8DE2,
		MaxFragmentBindableUniformsExt = 0x8DE3,
		MaxGeometryBindableUniformsExt = 0x8DE4,
		MaxBindableUniformSizeExt = 0x8DED,
		UniformBufferExt = 0x8DEE,
		UniformBufferBindingExt = 0x8DEF,
	}
	public enum EXT_texture_integer : uint
	{
		Rgba32uiExt = 0x8D70,
		Rgb32uiExt = 0x8D71,
		Alpha32uiExt = 0x8D72,
		Intensity32uiExt = 0x8D73,
		Luminance32uiExt = 0x8D74,
		LuminanceAlpha32uiExt = 0x8D75,
		Rgba16uiExt = 0x8D76,
		Rgb16uiExt = 0x8D77,
		Alpha16uiExt = 0x8D78,
		Intensity16uiExt = 0x8D79,
		Luminance16uiExt = 0x8D7A,
		LuminanceAlpha16uiExt = 0x8D7B,
		Rgba8uiExt = 0x8D7C,
		Rgb8uiExt = 0x8D7D,
		Alpha8uiExt = 0x8D7E,
		Intensity8uiExt = 0x8D7F,
		Luminance8uiExt = 0x8D80,
		LuminanceAlpha8uiExt = 0x8D81,
		Rgba32iExt = 0x8D82,
		Rgb32iExt = 0x8D83,
		Alpha32iExt = 0x8D84,
		Intensity32iExt = 0x8D85,
		Luminance32iExt = 0x8D86,
		LuminanceAlpha32iExt = 0x8D87,
		Rgba16iExt = 0x8D88,
		Rgb16iExt = 0x8D89,
		Alpha16iExt = 0x8D8A,
		Intensity16iExt = 0x8D8B,
		Luminance16iExt = 0x8D8C,
		LuminanceAlpha16iExt = 0x8D8D,
		Rgba8iExt = 0x8D8E,
		Rgb8iExt = 0x8D8F,
		Alpha8iExt = 0x8D90,
		Intensity8iExt = 0x8D91,
		Luminance8iExt = 0x8D92,
		LuminanceAlpha8iExt = 0x8D93,
		RedIntegerExt = 0x8D94,
		GreenIntegerExt = 0x8D95,
		BlueIntegerExt = 0x8D96,
		AlphaIntegerExt = 0x8D97,
		RgbIntegerExt = 0x8D98,
		RgbaIntegerExt = 0x8D99,
		BgrIntegerExt = 0x8D9A,
		BgraIntegerExt = 0x8D9B,
		LuminanceIntegerExt = 0x8D9C,
		LuminanceAlphaIntegerExt = 0x8D9D,
		RgbaIntegerModeExt = 0x8D9E,
	}
	public enum GREMEDY_frame_terminator : uint
	{
		}
}

