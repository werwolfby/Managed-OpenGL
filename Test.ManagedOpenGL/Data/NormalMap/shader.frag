uniform sampler2D texture;
uniform sampler2D normalMap;

varying vec3 eyeDirection;

void main()
{
	vec3 textureNormal = vec3( texture2D( normalMap, gl_TexCoord[0].st ) );

	vec3 normal = (textureNormal - vec3(0.5)) * 2;
	
	float delta = dot( normal, normalize(eyeDirection) );

	gl_FragColor = texture2D( texture, gl_TexCoord[0].st ) * delta;
}