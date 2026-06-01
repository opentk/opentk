#version 450

layout(location = 0) in vec3 fColor;

layout(location = 0) out vec4 oColor;

void main() {
	oColor = vec4(fColor, 1.0);
}