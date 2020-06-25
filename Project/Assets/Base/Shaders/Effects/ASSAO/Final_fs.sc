$input v_texCoord0

#include "../../Common.sh"

SAMPLER2D(s_sourceTexture, 0);
SAMPLER2D(s_blurTexture, 1);

uniform vec4 intensity;
uniform vec4 showAO;

void main()
{
	vec4 sourceColor = texture2D(s_sourceTexture, v_texCoord0);
	float occlusion = 1.0 - texture2D(s_blurTexture, v_texCoord0).x;

	float coef = saturate(occlusion * intensity.x);
	vec3 color;

	if(showAO.x > 0)
		color = lerp(vec3(1, 1, 1), vec3(0, 0, 0), coef);
	else
		color = lerp(sourceColor.rgb, vec3(0, 0, 0), coef);

	gl_FragColor = lerp(sourceColor, vec4(color, sourceColor.w), intensity.x);
}