uniform samplerCube cubeMapTexture; 
uniform sampler2D normalMapTexture; 

varying vec3 eyeDirection;
varying vec3 normal;

varying mat3 tSpace;
varying mat3 inverseTSpace;

void main()
{
	vec4 normalMapPoint = texture2D( normalMapTexture, gl_TexCoord[0].xy );
	vec3 newNormal = vec3( normalMapPoint ) * 2 - 1;

	vec3 texCoord = vec3( gl_TextureMatrix[0] * vec4( inverseTSpace * vec3( reflect( eyeDirection, newNormal ) ), 1 ) );
	//mat3 invertTSpace = inverse( tSpace );
	gl_FragColor = textureCube( cubeMapTexture, texCoord );
	//gl_FragColor = vec4( invertTSpace * tSpace * vec3( 1, 1, 1 ), 1 );
}