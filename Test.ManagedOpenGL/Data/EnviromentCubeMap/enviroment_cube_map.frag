uniform samplerCube cubeMapTexture; 
uniform sampler2D normalMapTexture; 

varying vec3 eyeDirection;
varying vec3 normal;

void main()
{
	vec4 normalMapPoint = texture2D( normalMapTexture, gl_TexCoord[0].xy );	
	vec3 newNormal = vec3( normalMapPoint ) * 2 - 1;

	vec3 texCoord = vec3( vec4( reflect( eyeDirection, newNormal ), 1 ) );	
	gl_FragColor = textureCube( cubeMapTexture, texCoord );
}