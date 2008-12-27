attribute vec3 tangent;
attribute vec3 binormal;

uniform vec3 eye;

varying vec3 eyeDir;
varying vec3 v;

void main()
{
	vec3 e = gl_NormalMatrix * normalize( eye - gl_Vertex.xyz );
	
	vec3 t = gl_NormalMatrix * tangent;
	vec3 b = gl_NormalMatrix * binormal;
	vec3 n = gl_NormalMatrix * gl_Normal;
	
	eyeDir = vec3( dot( e, t ), dot( e, b ), dot( e, n ) );

	gl_TexCoord[0] = gl_MultiTexCoord0;
	gl_Position = ftransform();
	
	gl_FrontColor = vec4( gl_Normal, 1 );
}