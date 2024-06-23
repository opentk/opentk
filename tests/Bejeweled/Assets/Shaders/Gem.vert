#version 330

in vec3 aPosition;
in vec3 aNormal;
in vec2 aUV;
in float aThickness;

out vec3 fWorldPosition;
out vec3 fNormal;
out vec2 fUV;
out float fThickness;

uniform mat4 uMVP;
uniform mat4 uModel;
uniform mat3 uNormalMat;

void main() {
	gl_Position = vec4(aPosition, 1.0) * uMVP;
	fWorldPosition = (vec4(aPosition, 1.0) * uModel).xyz;
	fNormal = aNormal * uNormalMat;
	fUV = aUV;

	// Here we assume unifom scaling...
	fThickness = aThickness * uModel[0][0];
}