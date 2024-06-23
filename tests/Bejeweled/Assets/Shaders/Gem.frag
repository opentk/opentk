#version 410

in vec3 fWorldPosition;
in vec3 fNormal;
in vec2 fUV;
in float fThickness;

out vec4 oColor;

uniform vec3 uCameraPosition;

uniform vec3 uTint;
uniform vec3 uF0;

//uniform samplerCube uEnvironmentMap;
uniform samplerCube uIrradianceMap;
uniform samplerCube uPrefilteredEnvironmentMap;

uniform sampler2D uBRDF_LUT;

uniform vec2 uScreenSize;
uniform float uDepthScale;

uniform sampler2D uBackfaceNormalTexture;
uniform sampler2D uBackfaceDepthTexture;

uniform mat4 uViewProjection;

const float PI = 3.14159265359;

vec3 f_schlick_roughness(float cosTheta, vec3 F0, float roughness)
{
    return F0 + (max(vec3(1.0 - roughness), F0) - F0) * pow(clamp(1.0 - cosTheta, 0.0, 1.0), 5.0);
} 

vec3 reinhard(vec3 x) {
  const float L_white = 4.0;

  return (x * (1.0 + x / (L_white * L_white))) / (1.0 + x);
}

const float IOR = 1.33;

float sample_backface_depth(ivec2 pos)
{
	float backfaceDepth = texelFetch(uBackfaceDepthTexture, pos, 0).r;
	return backfaceDepth;
}

vec3 sample_backface_normal(ivec2 pos)
{
	vec3 backfaceNormal = texelFetch(uBackfaceNormalTexture, pos, 0).rgb;

	// Normals are stored in unsigned format.
	if (backfaceNormal != vec3(0))
		backfaceNormal = backfaceNormal * 2 - 1;

	return backfaceNormal;
}

void main() {
	// We use a orthographic projection, but this generates
	// identical view directions for all pixels leading to
	// pretty booring reflections and refractions.
	// So we fake a camera position here making it so the
	// reflections are not orthographic.
	// This breaks the sampling of the backface properties
	// slightly as the reflections are going to have some bias.
	// This turns out to be fine if the camera is far enough away.
	vec3 V = normalize(vec3(0,0,15) - fWorldPosition);
	vec3 L = normalize(vec3(0.6, 0.6, 1));
	vec3 H = normalize(V + L);
	vec3 N = normalize(fNormal);
	vec3 R = reflect(-V, N);

	float NdotL = max(0.0, dot(N, L));
	float NdotV = max(0.0, dot(N, V));
	float NdotH = max(0.0, dot(N, H));

	float roughness = 0.1;
	float metallic = 0.05;

	vec3 f = f_schlick_roughness(NdotV, uF0, roughness);

	vec3 kS = f;
	vec3 kD = max(vec3(1.0) - kS, vec3(0));
	kD *= 1.0 - metallic;

	// Artistic choice to make refraction 
	// be 1/2 of the normal diffuse part.
	vec3 kR = kD * 0.5;
	kD = kD - kR;

	vec3 irradiance = reinhard(texture(uIrradianceMap, N).rgb);
	vec3 diffuse = irradiance * uTint;

	const float MAX_REFLECTION_LOD = 9.0;
	vec3 prefilteredColor = textureLod(uPrefilteredEnvironmentMap, R.xzy, roughness * MAX_REFLECTION_LOD).rgb;
	vec2 envBRDF  = texture(uBRDF_LUT, vec2(NdotV, roughness)).rg;
	vec3 specular = prefilteredColor * (f * envBRDF.x + envBRDF.y);

	float backfaceDepth = sample_backface_depth(ivec2(gl_FragCoord.xy));
	float frontfaceDepth = gl_FragCoord.z;
	float viewThickness = abs(backfaceDepth - frontfaceDepth) * uDepthScale;
	float normalThickness = fThickness;

	vec3 Rf = refract(-V, N, IOR);
	// FIXME: We should do like they say in the paper
	// where they clamp thetaI to thetaCrit and change
	// the refraction direction using this.
	// See: https://cwyman.org/papers/sig05_approxISRefr.pdf
	if (Rf == vec3(0))
		Rf = -V;
	float thetaI = max(0.0, dot(N, V));
	// FIXME: Revisit negative values for thetaT
	// when we have fixed the above refraction 
	// direction issue.
	float thetaT = dot(-N, Rf);
	float thetaRatio = thetaT / thetaI;
	float thickness = mix(viewThickness, normalThickness, 0);

	vec3 P2 = fWorldPosition + thickness * Rf;
	vec4 P2proj = vec4(P2, 1.0) * uViewProjection;
	vec2 P2ndc = (P2proj.xy / P2proj.w) * 0.5 + 0.5;
	ivec2 P2screen = ivec2(P2ndc * uScreenSize);

	vec3 backfaceNormal = sample_backface_normal(P2screen);
	if (length(backfaceNormal) < 0.0001)
		backfaceNormal = -N;
	
	vec3 Rf2 = refract(Rf, backfaceNormal, 1.0 / IOR);

	// FIXME: What is the physically based model for tinting?
	vec3 f2 = f_schlick_roughness(max(0.0, dot(backfaceNormal, Rf2)), uF0, roughness);
	prefilteredColor = textureLod(uPrefilteredEnvironmentMap, Rf2.xzy, roughness * MAX_REFLECTION_LOD).rgb;
	vec3 refraction = uTint * prefilteredColor * (f2 * envBRDF.x + envBRDF.y);

	oColor = vec4(reinhard(kD * diffuse + specular + refraction), 1.0);
	//oColor = vec4(reinhard(refraction), 1.0);

	//oColor = vec4(thetaI,thetaT,thetaRatio,1.0);
}