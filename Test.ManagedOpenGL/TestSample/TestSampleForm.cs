/*******************************************************
 *
 * Created by: Alexander Puzynia aka WerWolf
 * Created: 26.12.2008 22:33
 *
 * File: TestSampleForm.cs
 * Remarks:
 * 
 * History:
 *   26.12.2008 22:33 - Create Wireframe
 *
 *******************************************************/

using ManagedOpenGL;
using ManagedOpenGL.Engine.Math;
using ManagedOpenGL.Engine.Render;
using ManagedOpenGL.Engine.Shaders;
using gl=ManagedOpenGL.OpenGLNative;

namespace Test.ManagedOpenGL.TestSample
{
    public class TestSampleForm : SampleOpenGLForm
    {
        private const float size = 25.0f;

        private class TestShader : ShaderProgram
        {
            public Vector3F Top { get; set; }

            public int TopLocation { get; private set; }

            protected override void AfterLink()
            {
                base.AfterLink();

                this.TopLocation = this.GetUniformLocation( "top" );
            }

            public override void Use()
            {
                base.Use();

                gl.Uniform3fv( TopLocation, 3, Top.Data );
            }
        }

        private readonly TestShader shader = ShaderProgram.Create<TestShader>( @"Data\Test\vert.vert",
                                                                               @"Data\Test\frag.frag" );

        private readonly Vector3F[] quad = new[]
                                           {
                                               new Vector3F( -size, -size, 0 ),
                                               new Vector3F( +size, -size, 0 ),
                                               new Vector3F( +size, +size, 0 ),
                                               new Vector3F( -size, +size, 0 ),
                                           };

        private readonly Vector3F topVector;

        #region Constructors
        public TestSampleForm()
        {
            this.camera.Move( 0, 0, 50 );

            this.topVector = new Vector3F( 0, 0, 50 );
            this.shader.Top = this.topVector;

            this.shader.ApplyProgram( itemsManager );
        }
        #endregion

        #region Methods
        protected override void Draw()
        {
            base.Draw();

            //shader.Use();

            gl.Begin(BeginMode.Quads);

            gl.Color3f(1, 1, 1);
            foreach (var quadVertex in quad)
                gl.Vertex3fv( quadVertex.Data );

            gl.End();

            ShaderProgram.UnUse();

            gl.LineWidth(4);
            gl.Enable(EnableCap.LineSmooth);

            gl.Begin( BeginMode.Lines );

            gl.Color3f( 1, 1, 1 );

            //foreach (var quadVertex in quad)
            //{
            //    gl.Vertex3fv( topVector.Data );
            //    gl.Vertex3fv( quadVertex.Data );
            //}

            var length = 10;

            for (var i = 0; i < length; i++)
            {
                var x = -size + (2 * size * i / (length - 1));

                for (var j = 0; j < length; j++)
                {
                    var y = -size + (2 * size * j / (length - 1));

                    var startVect = new Vector3F( x, y, 0 );
                    var vect = topVector - startVect;
                    vect.Normalize();

                    var colorVect = ((vect + new Vector3F( 1, 1, 1 )) * 0.5f);
                    gl.Color3fv( colorVect.Data );

                    vect = startVect + vect;

                    gl.Vertex3fv( startVect.Data );
                    gl.Vertex3fv( vect.Data );
                }
            }

            gl.End();

            Renderer.RenderMode = RenderMode.MODE_2D;
        }
        #endregion
    }
}