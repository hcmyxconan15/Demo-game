Shader "NV3D/ShatterStone/Gemstone" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		_Albedo ("Albedo", 2D) = "white" {}
		_AlbedoHueShift ("Albedo  Hue Shift", Range(0, 1)) = 0
		_AlbedoSaturationShift ("Albedo Saturation Shift", Range(-1, 1)) = 0
		_Normal ("Normal", 2D) = "bump" {}
		_Masks ("Masks", 2D) = "white" {}
		_BaseSmoothness ("Base Smoothness", Range(0, 2)) = 1
		_DirtColor ("Dirt Color", Vector) = (0,0,0,0)
		_DirtStrength ("Dirt Strength", Range(0, 2)) = 0
		_DirtSmoothness ("Dirt Smoothness", Float) = 0
		[HDR] _EmissionColor ("Emission Color", Vector) = (1,1,1,0)
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[ToggleOff] [HideInInspector] _SpecularHighlights ("Specular Highlights", Float) = 1
		[ToggleOff] [HideInInspector] _EnvironmentReflections ("Environment Reflections", Float) = 1
		[ToggleOff] [HideInInspector] _ReceiveShadows ("Receive Shadows", Float) = 1
		[HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
		[HideInInspector] _QueueControl ("_QueueControl", Float) = -1
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
	}
	SubShader {
		Tags { "RenderType"="Transparent" "Queue"="Transparent" "RenderPipeline"="UniversalPipeline" "IgnoreProjector"="True" "PreviewType"="Plane" }
		// Fallback written for the ripped project: original shader source was not recoverable.
		Blend SrcAlpha OneMinusSrcAlpha
		ZWrite Off
		Cull Off
		Pass {
			Name "ParticleFallback"
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#pragma multi_compile_instancing
			#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

			TEXTURE2D(_Albedo); SAMPLER(sampler_Albedo); float4 _Albedo_ST;
			#define SAMPLE_TEX(uv) SAMPLE_TEXTURE2D(_Albedo, sampler_Albedo, uv)
			#define TEX_ST ((any(_Albedo_ST.xy)) ? _Albedo_ST : float4(1,1,0,0))
			float4 _EmissionColor;
			#define TINT _EmissionColor
			#define SHADE(m) (m)

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
