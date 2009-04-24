uniform sampler2D texture;
uniform sampler2D heightMap;

uniform vec3 top;

uniform float bias;
uniform float scale;

varying vec3 vertexLocation;

void main()
{
	vec3 eyeDir = top - vec3( vertexLocation );
	eyeDir = normalize( eyeDir );

	float height = 1.0 - texture2D( heightMap, gl_TexCoord[0].xy ).b;
	height = scale * height + bias;
	
	vec4 pixel = texture2D( texture, gl_TexCoord[0].xy - eyeDir.xy * height / eyeDir.z );

	gl_FragColor = pixel;
}