Shader "BloodEffectsPack/URP/BloodFX_PBR_URP" {
	Properties {
		_ViewDirMaskThreshold ("ViewDirMaskThreshold", Range(0, 1)) = 0.1
		_BaseColor ("BaseColor", Vector) = (1,1,1,0)
		_ColorIntensity ("ColorIntensity", Float) = 1
		_AlbedoPower ("AlbedoPower", Float) = 1
		_HueShift ("HueShift", Range(-180, 180)) = 0
		_AmbientColorIntensity ("AmbientColorIntensity", Float) = 1
		[NoScaleOffset] _MainTex ("MainTex", 2D) = "white" {}
		_Smoothness ("Smoothness", Range(0, 1)) = 0
		[NoScaleOffset] _NormalTex ("NormalTex", 2D) = "white" {}
		_NormalScale ("NormalScale", Float) = 0
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

			TEXTURE2D(_MainTex); SAMPLER(sampler_MainTex); float4 _MainTex_ST;
			#define SAMPLE_TEX(uv) SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, uv)
			#define TEX_ST ((any(_MainTex_ST.xy)) ? _MainTex_ST : float4(1,1,0,0))
			float4 _BaseColor;
			#define TINT _BaseColor
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
