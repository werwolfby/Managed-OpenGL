uniform vec3 LightPosition;

const float SpecularContribution = 0.3;
const float DiffuseContribution = 1.0 - SpecularContribution;

varying float LightIntensity;
varying vec2 MCPosition;

void main()
{
	vec3 ecPosition = vec3( gl_ModelViewMatrix * gl_Vertex );
	vec3 norm = normalize( gl_NormalMatrix * gl_Normal );
	vec3 lightVec = normalize( LightPosition - ecPosition );
	vec3 reflectVec = reflect( -lightVec, norm );
	vec3 viewVec = normalize( -ecPosition );
	float diffuse = max( dot( lightVec, norm ), 0.0 );
	float spec = 0.0;
	
	if (diffuse > 0.0)
	{
		spec = max( dot( reflectVec, viewVec ), 0.0 );
		spec = pow( spec, 16.0 );
	}
	
	LightIntensity = DiffuseContribution * diffuse + SpecularContribution * spec;
	
	MCPosition = gl_Vertex.xy;
	gl_Position = ftransform();
}