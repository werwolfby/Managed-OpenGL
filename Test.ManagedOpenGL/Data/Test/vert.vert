varying vec3 eyeDir;
varying vec3 vertexLocation;

void main()
{
	gl_Position = ftransform();
	
	vertexLocation = gl_Vertex.xyz;
	
	gl_TexCoord[0] = gl_MultiTexCoord0;
}