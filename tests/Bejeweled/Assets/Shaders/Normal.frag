#version 330

in vec3 fNormal;

out vec4 oColor;

void main() {
	// We are storing the normals in an unsigned format.
	oColor = vec4(fNormal * 0.5 + 0.5, 1.0);
}