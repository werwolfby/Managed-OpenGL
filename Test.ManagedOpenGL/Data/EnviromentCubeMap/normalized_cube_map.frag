uniform samplerCube cubeMapTexture; 
uniform bool isNormalize = true;

void main()
{
	// Normalizacia proishodit v samoi vuborke tak chto
	// bagi navernoe v samom algorithme
	gl_FragColor = textureCube( cubeMapTexture, gl_TexCoord[0].xyz  );
}