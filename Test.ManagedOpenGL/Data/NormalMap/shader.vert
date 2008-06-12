uniform vec3 camPosition;

varying vec3 eyeDirection;

attribute vec3 tangent;
attribute vec3 binormal;

void main()
{
	gl_Position = ftransform();
	gl_TexCoord[0] = gl_MultiTexCoord0;
	
	vec3 n = normalize( gl_NormalMatrix * gl_Normal );
	vec3 t = normalize( gl_NormalMatrix * tangent );
	vec3 b = normalize( gl_NormalMatrix * binormal );
	
	vec3 eyeD = normalize( vec3( gl_ModelViewMatrix * gl_Vertex ) );
	
	eyeDirection.x = dot( eyeD, t );
	eyeDirection.y = dot( eyeD, b );
	eyeDirection.z = dot( eyeD, n );
	
	eyeDirection.z *= -1;
	
	//eyeDirection = normalize( camPosition - vec3( gl_Vertex ) );
}