void main()
{
	vec3 normal = ( gl_NormalMatrix * gl_Normal );
	vec3 eyeDirection = ( vec3( gl_ModelViewMatrix * gl_Vertex ) );
	
	gl_TexCoord[0] = gl_TextureMatrix[0] * vec4( reflect( eyeDirection, normal ), 1 );
	gl_Position = ftransform();
}