uniform sampler2D texture;
uniform sampler2D normalMap;

varying vec3 eyeDirection;

void main()
{
	vec3 textureNormal = vec3( texture2D( normalMap, gl_TexCoord[0].st ) );

	vec3 normal = (textureNormal - vec3(0.5)) * 2;
	
	float delta = max( dot( normal, normalize(eyeDirection) ), 0.0 );
	
	//delta = pow( delta, 12.0 );

	gl_FragColor = texture2D( texture, gl_TexCoord[0].st ) * delta;
	//gl_FragColor = vec4( vec3( delta ), 1 );
	//gl_FragColor = vec4( textureNormal, 1 );
}