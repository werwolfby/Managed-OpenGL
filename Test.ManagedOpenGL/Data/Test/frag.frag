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
	float currentHeight = 1;
	
	while (textureHeight < currentHeight)
	{
		textureHeight = texture2D( heightMap, coord ).b;
		currentHeight -= stepLength;
		coord += deltaTexCoord;
		
		if (currentHeight < 0) break;
	}
	
	vec4 pixel = texture2D( texture, coord );

	gl_FragColor = pixel;
}