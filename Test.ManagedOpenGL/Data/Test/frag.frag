uniform vec3 top;
varying vec3 vertexLocation;

void main()
{
	vec3 eyeDir = top - vec3( vertexLocation );
	eyeDir = normalize( eyeDir );

	gl_FragColor = vec4( (eyeDir + 1) * 0.5, 1 );
}