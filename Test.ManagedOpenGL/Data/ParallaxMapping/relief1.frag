uniform sampler2D texture;

uniform sampler2D heightMap;
uniform sampler2D normalMap;

varying vec3 eyeDir;
varying vec3 v;

void main()
{
	const float numSteps  = 8.0;
	const float scale = 0.07;
	
	vec3 e = normalize( eyeDir );
	
	float	step   = 1.0 / numSteps;
	vec2	dtex   = e.xy * scale / ( numSteps * e.z );	// adjustment for one layer
	float	height = 1.0;											// height of the layer
	vec2	tex    = gl_TexCoord [0].xy;							// our initial guess
	float	h      = texture2D ( heightMap, tex ).b;				// get height
	
	float count = 1.0;
	
	while ( h < height )
	{
		height -= step;
		tex    -= dtex;
		h       = texture2D ( heightMap, tex ).b;
		count  -= step;
	}
		
	//gl_FragColor = vec4( texture2D( texture, tex ).rgb, 1.0 );
	//gl_FragColor = vec4( vec3( count ), 1.0 );
	//gl_FragColor = vec4( vec3( abs(e.y) ), 1.0 );	
	gl_FragColor = gl_Color;
}