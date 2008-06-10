using System;
using System.Runtime.InteropServices;

namespace ManagedOpenGL
{
	public static partial class OpenGLNative
	{	
		static void OpenGLNativeNV_geometry_program4Init()
		{
			_ProgramVertexLimitNV = GetProcAdress< ProgramVertexLimitNVDelegate >( "glProgramVertexLimitNV" );
			_FramebufferTextureEXT = GetProcAdress< FramebufferTextureEXTDelegate >( "glFramebufferTextureEXT" );
			_FramebufferTextureLayerEXT = GetProcAdress< FramebufferTextureLayerEXTDelegate >( "glFramebufferTextureLayerEXT" );
			_FramebufferTextureFaceEXT = GetProcAdress< FramebufferTextureFaceEXTDelegate >( "glFramebufferTextureFaceEXT" );
			
		}
		
	
		public delegate void ProgramVertexLimitNVDelegate( uint target, int limit ); //  extension method
		private static ProgramVertexLimitNVDelegate _ProgramVertexLimitNV;
		
		public static  void ProgramVertexLimitNV( uint target, int limit )
		{
			if (_ProgramVertexLimitNV == null) throw new Exception( "Extension method ProgramVertexLimitNV not found" );
			 _ProgramVertexLimitNV( target, limit );
		}
		public delegate void FramebufferTextureEXTDelegate( uint target, uint attachment, uint texture, int level ); //  extension method
		private static FramebufferTextureEXTDelegate _FramebufferTextureEXT;
		
		public static  void FramebufferTextureEXT( uint target, uint attachment, uint texture, int level )
		{
			if (_FramebufferTextureEXT == null) throw new Exception( "Extension method FramebufferTextureEXT not found" );
			 _FramebufferTextureEXT( target, attachment, texture, level );
		}
		public delegate void FramebufferTextureLayerEXTDelegate( uint target, uint attachment, uint texture, int level, int layer ); //  extension method
		private static FramebufferTextureLayerEXTDelegate _FramebufferTextureLayerEXT;
		
		public static  void FramebufferTextureLayerEXT( uint target, uint attachment, uint texture, int level, int layer )
		{
			if (_FramebufferTextureLayerEXT == null) throw new Exception( "Extension method FramebufferTextureLayerEXT not found" );
			 _FramebufferTextureLayerEXT( target, attachment, texture, level, layer );
		}
		public delegate void FramebufferTextureFaceEXTDelegate( uint target, uint attachment, uint texture, int level, TextureTarget face ); //  extension method
		private static FramebufferTextureFaceEXTDelegate _FramebufferTextureFaceEXT;
		
		public static  void FramebufferTextureFaceEXT( uint target, uint attachment, uint texture, int level, TextureTarget face )
		{
			if (_FramebufferTextureFaceEXT == null) throw new Exception( "Extension method FramebufferTextureFaceEXT not found" );
			 _FramebufferTextureFaceEXT( target, attachment, texture, level, face );
		}
	}
}

