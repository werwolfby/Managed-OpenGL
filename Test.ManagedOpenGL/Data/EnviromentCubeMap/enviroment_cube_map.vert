varying vec3 eyeDirection;
varying vec3 normal;

attribute vec3 tangent;
attribute vec3 binormal;

void main()
{
	normal = ( gl_NormalMatrix * gl_Normal );
	vec3 eyeD = ( vec3( gl_ModelViewMatrix * gl_Vertex ) );
	
	vec3 t = ( gl_NormalMatrix * tangent );
	vec3 b = ( gl_NormalMatrix * binormal );
	vec3 n = ( gl_NormalMatrix * gl_Normal );
	
	eyeDirection.x = +dot( eyeD, t );
	eyeDirection.y = +dot( eyeD, b );
	eyeDirection.z = -dot( eyeD, n );
	
	//eyeDirection = eyeD;
	
	gl_TexCoord[0] = gl_MultiTexCoord0;
	gl_Position = ftransform();
}