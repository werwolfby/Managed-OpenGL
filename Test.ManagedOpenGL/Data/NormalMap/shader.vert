uniform vec3 camPosition;

varying vec3 eyeDirection;

void main()
{
	gl_Position = ftransform();
	gl_TexCoord[0] = gl_MultiTexCoord0;
	
	eyeDirection = normalize( camPosition - vec3( gl_Vertex ) );
}