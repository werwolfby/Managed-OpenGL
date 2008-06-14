varying vec3 normal;
varying vec3 eyeDirection;

void main()
{
	normal = normalize( gl_NormalMatrix * gl_Normal );
	eyeDirection = normalize( gl_ModelViewMatrix * gl_Vertex ).xyz;
	
	//gl_TexCoord[0] = gl_TextureMatrix[0] * vec4( reflect( eyeDirection, normal ), 1 );
	gl_Position = ftransform();
}