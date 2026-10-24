Shader "SineVFX/TopDownEffects/SG/DissolveParticleDepth" {
	Properties {
		_FinalColor ("Final Color", Vector) = (1,1,1,1)
		_FinalPower ("Final Power", Range(0, 60)) = 0
		_FinalOpacityPower ("Final Opacity Power", Range(1, 8)) = 1
		_FinalOpacityExp ("Final Opacity Exp", Range(0.2, 8)) = 1
		[NoScaleOffset] _Ramp ("Ramp", 2D) = "white" {}
		_RampColorTint ("Ramp Color Tint", Vector) = (1,1,1,1)
		[ToggleUI] _RAMPAFFECTEDBYVERTEXCOLOR ("Ramp Affected By Vertex Color", Float) = 0
		_RampAffectedByDynamics ("Ramp Affected By Dynamics", Range(0, 1)) = 1
		_RampOffsetMultiply ("Ramp Offset Multiply", Float) = 1
		_RampOffsetExp ("Ramp Offset Exp", Range(0.2, 8)) = 1
		[ToggleUI] _RIMMASKFLIP ("Rim Mask Flip", Float) = 0
		_RimMaskExp ("Rim Mask Exp", Range(0.2, 8)) = 1
		[NoScaleOffset] _OffsetNoise ("Offset Noise", 2D) = "white" {}
		_OffsetPower ("Offset Power", Float) = 0.5
		_OffsetScaleWithSizeFixSwitch ("Offset Scale With Size Fix Switch", Range(0, 1)) = 1
		[NoScaleOffset] _DissolveNoise ("Dissolve Noise", 2D) = "white" {}
		[ToggleUI] _DISSOLVENOISEFLIP ("Dissolve Noise Flip", Float) = 0
		_DissolveNoiseExp ("Dissolve Noise Exp", Float) = 6.47
		_DissolveNoiseExpReversed ("Dissolve Noise Exp Reversed", Float) = 2
		[ToggleUI] _DEPTHFADEMAXMODE ("Depth Fade Max Mode", Float) = 1
		[ToggleUI] _DEPTHFADEFLIP ("Depth Fade Flip", Float) = 1
		_DepthFadeDistance ("Depth Fade Distance", Float) = 1
		_DepthFadeExp ("Depth Fade Exp", Float) = 2
		_LossyScaleGlobal ("_LossyScaleGlobal", Float) = 1
		[HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
		[HideInInspector] _QueueControl ("_QueueControl", Float) = -1
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
		[Toggle] _RAMPENABLED ("Ramp Enabled", Float) = 0
		[Toggle] _RIMMASKENABLED ("Rim Mask Enabled", Float) = 0
	}
	SubShader {
		Tags { "RenderType"="Transparent" "Queue"="Transparent" "RenderPipeline"="UniversalPipeline" "IgnoreProjector"="True" "PreviewType"="Plane" }
		// Fallback written for the ripped project: original shader source was not recoverable.
		Blend SrcAlpha One
		ZWrite Off
		Cull Off
		Pass {
			Name "ParticleFallback"
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#pragma multi_compile_instancing
			#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

			TEXTURE2D(_DissolveNoise); SAMPLER(sampler_DissolveNoise); float4 _DissolveNoise_ST;
			#define SAMPLE_TEX(uv) SAMPLE_TEXTURE2D(_DissolveNoise, sampler_DissolveNoise, uv)
			#define TEX_ST ((any(_DissolveNoise_ST.xy)) ? _DissolveNoise_ST : float4(1,1,0,0))
			float4 _FinalColor;
			#define TINT _FinalColor
			TEXTURE2D(_Ramp); SAMPLER(sampler_Ramp);
			#define SHADE(m) half4(SAMPLE_TEXTURE2D(_Ramp, sampler_Ramp, float2(saturate((m).r), 0.5)).rgb, (m).r)

			struct Attributes { float4 positionOS : POSITION; float4 color : COLOR; float2 uv : TEXCOORD0; UNITY_VERTEX_INPUT_INSTANCE_ID };
			struct Varyings { float4 positionCS : SV_POSITION; float4 color : COLOR; float2 uv : TEXCOORD0; };

			Varyings vert(Attributes v)
			{
				Varyings o;
				UNITY_SETUP_INSTANCE_ID(v);
				o.positionCS = TransformObjectToHClip(v.positionOS.xyz);
				o.color = v.color;
				o.uv = v.uv * TEX_ST.xy + TEX_ST.zw;
				return o;
			}

			half4 frag(Varyings i) : SV_Target
			{
				half4 c = SHADE(SAMPLE_TEX(i.uv)) * i.color * TINT;
				return c;
			}
			ENDHLSL
		}
	}
}
