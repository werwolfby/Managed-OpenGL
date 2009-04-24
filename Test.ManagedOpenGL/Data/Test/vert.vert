uniform vec3 top;
uniform float zoom;

void main()
{
	gl_Position = ftransform();
	
	vec3 eyeDir = pow((normalize( top - vec3( gl_Vertex ) ) + 1) * 0.5, vec3(zoom));
	
	gl_FrontColor = vec4( eyeDir, 1.0 );
}