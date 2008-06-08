varying vec4 pos;

void main()
{
	float z = pos.z / pos.w;
	z = (z + 1) / 2;

	gl_FragColor = vec4( z, z, z, 0 );
}