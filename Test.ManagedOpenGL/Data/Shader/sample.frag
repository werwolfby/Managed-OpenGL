uniform vec3 BrickColor, MortalColor;
uniform vec2 BrickSize;
uniform vec2 BrickPct;

varying float LightIntensity;
varying vec2 MCPosition;

void main()
{
	vec3 color;
	vec2 position, useBrick;
	
	position = MCPosition / BrickSize;
	
	if (fract( position.y * 0.5) > 0.5)
	{
		position.x += 0.5;
	}
	
	position = fract( position );
	
	useBrick = step( position, BrickPct );
	
	color = mix( MortalColor, BrickColor, useBrick.x*useBrick.y );
	color *= LightIntensity;

	gl_FragColor = vec4( color, 1 );
}