varying vec3 eyeDirection;
varying vec3 normal;

varying mat3 tSpace;
varying mat3 inverseTSpace;

attribute vec3 tangent;
attribute vec3 binormal;

mat3 TangentSpace( vec3 tangent, vec3 binormal, vec3 normal )
{
	return mat3( tangent.x, binormal.x, normal.x,
	             tangent.y, binormal.y, normal.y,
	             tangent.z, binormal.z, normal.z );
}

float azeDet2x2( float a00, float a01, float a10, float a11)
{
	return (a00*a11 - a01*a10);
}

mat3 inverse( mat3 A )
{
	mat3 C;

	C[0][0] =  azeDet2x2(A[1][1], A[1][2], A[2][1], A[2][2]);
	C[0][1] = -azeDet2x2(A[0][1], A[0][2], A[2][1], A[2][2]);
	C[0][2] =  azeDet2x2(A[0][1], A[0][2], A[1][1], A[1][2]);

	C[1][0] = -azeDet2x2(A[1][0], A[1][2], A[2][0], A[2][2]);
	C[1][1] =  azeDet2x2(A[0][0], A[0][2], A[2][0], A[2][2]);
	C[1][2] = -azeDet2x2(A[0][0], A[0][2], A[1][0], A[1][2]);

	C[2][0] =  azeDet2x2(A[1][0], A[1][1], A[2][0], A[2][1]);
	C[2][1] = -azeDet2x2(A[0][0], A[0][1], A[2][0], A[2][1]);
	C[2][2] =  azeDet2x2(A[0][0], A[0][1], A[1][0], A[1][1]);

	float det = (A[0][0] * C[0][0]) + (A[1][0] * C[0][1]) + (A[2][0] * C[0][2]);

	C /= det;

	return C;
}

void main()
{
	normal = ( gl_NormalMatrix * gl_Normal );
	vec3 eyeD = ( vec3( gl_ModelViewMatrix * gl_Vertex ) );
	
	vec3 t = gl_NormalMatrix * tangent;
	vec3 b = gl_NormalMatrix * binormal;
	vec3 n = - gl_NormalMatrix * gl_Normal;
	
	tSpace = TangentSpace( t, b, n );
	inverseTSpace = inverse( tSpace );
	
	eyeDirection = tSpace * eyeD;
	
	//eyeDirection.x = +dot( eyeD, t );
	//eyeDirection.y = +dot( eyeD, b );
	//eyeDirection.z = +dot( eyeD, n );
	
	gl_TexCoord[0] = gl_MultiTexCoord0;
	gl_Position = ftransform();
}