uniform vec3 top;
uniform float zoom;
varying vec3 eyeDir;

void main()
{
	gl_Position = ftransform();
	
	eyeDir = normalize( top - vec3( gl_Vertex ) );
	
	gl_FrontColor = vec4( pow((eyeDir + 1) * 0.5, vec3( zoom )), 1.0 );
}