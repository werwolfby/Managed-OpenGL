uniform sampler2D texture;

uniform sampler2D heightMap;
uniform sampler2D normalMap;

varying vec3 eyeDir;
varying vec3 v;

void main()
{
	float h = 0.03 * (1.0 - texture2D( heightMap, gl_TexCoord[0].xy ).b);
	
	vec3 e = normalize( eyeDir );
	
	vec2 texDisp = gl_TexCoord[0].xy - e.xy * h / e.z;

	//gl_FragColor = vec4( texture2D( texture, texDisp ).rgb, 1.0 );
	gl_FragColor = vec4( e.rgb, 1.0 );
}