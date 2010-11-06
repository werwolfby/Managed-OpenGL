uniform sampler2D texture;
uniform sampler2D heightMap;

uniform vec3 top;

uniform float bias;
uniform float scale;

varying vec3 vertexLocation;

const float steps = 8.0;

void main()
{
	float stepLength = 1.0 / steps;

	vec3 eyeDir = top - vec3( vertexLocation );
	eyeDir = normalize( eyeDir );

	float textureHeight = texture2D( heightMap, gl_TexCoord[0].xy ).b;
	
	vec2 coord = gl_TexCoord[0].xy;
	vec2 deltaTexCoord = eyeDir.xy * (scale / steps) / eyeDir.z;
	float currentHeight = 1.0;
	float prevTextureHeight;
	vec2 prevCoord;
	
	while (textureHeight < currentHeight)
	{
		prevTextureHeight = textureHeight;
		prevCoord = coord;
		
		currentHeight -= stepLength;
		coord -= deltaTexCoord;

		textureHeight = texture2D( heightMap, coord ).b;
		
		if (currentHeight < 0.0) break;
	}
	
	//vec2 delta = 0.5 * deltaTexCoord;
	//vec2 mid   = coord + delta;

	//for ( int i = 0; i < 5; i++ )
	//{
	//	delta *= 0.5;

	//	if ( texture2D ( heightMap, mid ).a < currentHeight ) mid -= delta;
	//	else                                                  mid += delta;
	//}

    //coord = mid;
	vec4 pixel = texture2D( texture, coord );

	gl_FragColor = pixel;
}