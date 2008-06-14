uniform samplerCube cubeMapTexture; 
uniform sampler2D normalMapTexture; 

varying vec3 eyeDirection;
varying vec3 normal;

varying mat3 tSpace;

mat3 transpose( mat3 mat )
{
	return mat3( mat[0][0], mat[1][0], mat[2][0],
	             mat[0][1], mat[1][1], mat[2][1],
	             mat[0][2], mat[1][2], mat[2][2] );
}

float azeDet2x2( float a00, float a01, float a10, float a11)
{
	return (a00*a11 - a01*a10);
}

mat3 inverse( mat3 A )
{
	mat3 C;

	C[0][0] =  azeDet2x2(A[1][1], A[2][2], A[1][2], A[2][1]);
	C[1][0] = -azeDet2x2(A[0][1], A[2][2], A[0][2], A[2][1]);
	C[2][0] =  azeDet2x2(A[0][1], A[1][2], A[0][2], A[1][1]);

	C[0][1] = -azeDet2x2(A[1][0], A[2][2], A[1][2], A[2][0]);
	C[1][1] =  azeDet2x2(A[0][0], A[2][2], A[0][2], A[2][0]);
	C[2][1] = -azeDet2x2(A[0][0], A[1][2], A[0][2], A[1][0]);

	C[0][2] =  azeDet2x2(A[1][0], A[2][1], A[1][1], A[2][0]);
	C[1][2] = -azeDet2x2(A[0][0], A[2][1], A[0][1], A[2][0]);
	C[2][2] =  azeDet2x2(A[0][0], A[1][1], A[0][1], A[1][0]);

	float det = (A[0][0] * C[0][0]) + (A[1][0] * C[0][1]) + (A[2][0] * C[0][2]);

	C /= det;

	return C;
}

void main()
{
	vec4 normalMapPoint = texture2D( normalMapTexture, gl_TexCoord[0].xy );
	vec3 newNormal = vec3( normalMapPoint ) * 2 - 1;

	vec3 texCoord = inverse( tSpace ) * vec3( reflect( eyeDirection, newNormal ) );
	//mat3 invertTSpace = inverse( tSpace );
	gl_FragColor = textureCube( cubeMapTexture, texCoord );
	//gl_FragColor = vec4( invertTSpace * tSpace * vec3( 1, 1, 1 ), 1 );
}