uniform samplerCube cubeMapTexture; 
uniform bool isNormalize = true;

varying vec3 normal;
varying vec3 eyeDirection;

void main()
{
	vec3 _eyeDirection;
	vec3 _normal;
	
	if (isNormalize == true) _eyeDirection = normalize( eyeDirection );
	else _eyeDirection = eyeDirection;
	if (isNormalize == true) _normal = normalize( normal );
	_normal = normal;
	
	vec3 rf = reflect( eyeDirection, normal );
	
	vec3 texCoord = vec3( gl_TextureMatrix[0] * vec4( reflect( _eyeDirection, _normal ), 1 ) );

	// Номализация происходит внутри алогритма выборки текстуры так что
	// баги наверное в самом алгоритме
	gl_FragColor = textureCube( cubeMapTexture, texCoord * 5 );
	//gl_FragColor = vec4( pow( abs( rf - normalize( rf ) ), vec3( 0.3 ) ), 1 );
}