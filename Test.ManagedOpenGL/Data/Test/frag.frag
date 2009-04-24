uniform bool normalizeVector;
varying vec3 eyeDir;

void main()
{
	vec3 color = eyeDir;
	if (normalizeVector) color = normalize( color );
	color = (color + 1) * 0.5;

	gl_FragColor = vec4( color, 1 );
}