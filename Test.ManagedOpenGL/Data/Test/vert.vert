uniform vec3 top;

void main()
{
	gl_Position = ftransform();
	
	vec3 eyeDir = (normalize( top - vec3( gl_Vertex ) ) + 1) * 0.5;
	
	gl_FrontColor = vec4( eyeDir, 1.0 );
}