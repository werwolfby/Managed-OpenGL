uniform vec3 top;
uniform bool normalizeVector;

varying vec3 eyeDir;
varying vec3 vertexLocation;

void main()
{
	vec3 color = top - vec3( vertexLocation );
	if (normalizeVector) color = normalize( color );
	color = (color + 1) * 0.5;

	gl_FragColor = vec4( color, 1 );
}