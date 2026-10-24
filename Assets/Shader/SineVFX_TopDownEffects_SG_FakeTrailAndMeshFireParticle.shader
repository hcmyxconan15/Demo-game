Shader "SineVFX/TopDownEffects/SG/FakeTrailAndMeshFireParticle" {
	Properties {
		_FinalColor ("Final Color", Vector) = (1,1,1,1)
		_FinalPower ("Final Power", Range(0, 60)) = 4
		_FinalOpacityPower ("Final Opacity Power", Range(0, 40)) = 1
		_FinalOpacityExp ("Final Opacity Exp", Float) = 4
		[NoScaleOffset] _Ramp ("Ramp", 2D) = "white" {}
		_RampAffectedByDynamics ("Ramp Affected By Dynamics", Range(0, 1)) = 1
		_RampOffsetMultiply ("Ramp Offset Multiply", Float) = 1
		_RampOffsetExp ("Ramp Offset Exp", Range(0.2, 8)) = 1
		[NoScaleOffset] _MainMask ("Main Mask", 2D) = "white" {}
		_MainMaskScaleU ("Main Mask Scale U", Float) = 1
		_MainMaskScaleV ("Main Mask Scale V", Float) = 1
		_MainMaskScrollSpeed ("Main Mask Scroll Speed", Float) = 0
		_MainMaskExp ("Main Mask Exp", Range(0.2, 4)) = 1
		[NoScaleOffset] _Distortion ("Distortion", 2D) = "white" {}
		_DistortionScaleU ("Distortion Scale U", Float) = 1
		_DistortionScaleV ("Distortion Scale V", Float) = 1
		[NoScaleOffset] _DistortionMask ("Distortion Mask", 2D) = "white" {}
		_DistortionPowerU ("Distortion Power U", Range(-1, 1)) = 0
		_DistortionPowerV ("Distortion Power V", Range(-1, 1)) = 0
		_DistortionScrollSpeedU ("Distortion Scroll Speed U", Float) = 0
		_DistortionScrollSpeedV ("Distortion Scroll Speed V", Float) = 0
		[NoScaleOffset] _Noise01 ("Noise 01", 2D) = "white" {}
		_Noise01ScaleU ("Noise 01 Scale U", Float) = 1
		_Noise01ScaleV ("Noise 01 Scale V", Float) = 1
		_Noise01Negate ("Noise 01 Negate", Range(0, 1)) = 0
		_Noise01Exp ("Noise 01 Exp", Range(0.2, 8)) = 1
		_Noise01ScrollSpeed ("Noise 01 Scroll Speed", Float) = 0
		_SqueezeUVAmount ("Squeeze UV Amount", Float) = 0
		_SqueezeUVExp ("Squeeze UV Exp", Range(0.2, 8)) = 1
		_EndPointMaskExp ("End Point Mask Exp", Range(0.2, 8)) = 2
		_StartPointMaskAdd ("Start Point Mask Add", Range(0, 1)) = 0
		_StartPointMaskExp ("Start Point Mask Exp", Range(0.2, 8)) = 1
		_RimMaskExp ("Rim Mask Exp", Range(0.2, 8)) = 1
		_RimStartPointBoostPower ("Rim Start Point Boost Power", Range(0, 20)) = 0
		_RimStartPointBoostExp ("Rim Start Point Boost Exp", Range(0.2, 8)) = 1
		_FakeTrailScrollMultiplier ("Fake Trail Scroll Multiplier", Float) = 0.15
		_FakeTrailScrollRandomMin ("Fake Trail Scroll Random Min", Range(0.5, 1)) = 0.8
		_FakeTrailScrollRandomMax ("Fake Trail Scroll Random Max", Range(1, 1.5)) = 1.1
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

			TEXTURE2D(_MainMask); SAMPLER(sampler_MainMask); float4 _MainMask_ST;
			#define SAMPLE_TEX(uv) SAMPLE_TEXTURE2D(_MainMask, sampler_MainMask, uv)
			#define TEX_ST ((any(_MainMask_ST.xy)) ? _MainMask_ST : float4(1,1,0,0))
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
