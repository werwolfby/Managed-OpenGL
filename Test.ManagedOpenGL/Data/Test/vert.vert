uniform vec3 top;
uniform float zoom;

varying vec3 eyeDir;
varying vec3 vertexLocation;

void main()
{
	gl_Position = ftransform();
	
	eyeDir = normalize( top - gl_Vertex.xyz );
	vertexLocation = gl_Vertex.xyz;
	
	gl_FrontColor = vec4( pow((eyeDir + 1) * 0.5, vec3( zoom )), 1.0 );
}