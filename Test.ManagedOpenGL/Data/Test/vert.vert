varying vec3 eyeDir;
varying vec3 vertexLocation;

void main()
{
	gl_Position = ftransform();
	
	vertexLocation = gl_Vertex.xyz;
}