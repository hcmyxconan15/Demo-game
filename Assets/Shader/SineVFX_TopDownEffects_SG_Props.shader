Shader "SineVFX/TopDownEffects/SG/Props" {
	Properties {
		[NoScaleOffset] _AlbedoDecalMask ("AlbedoDecalMask", 2D) = "white" {}
		_AlbedoColorTint ("Albedo Color Tint", Vector) = (1,1,1,1)
		_AlbedoDecalColor ("Albedo Decal Color", Vector) = (1,0,0,1)
		_AlbedoDecalNegate ("Albedo Decal Negate", Range(0, 1)) = 0
		[NoScaleOffset] [Normal] _Normal ("Normal", 2D) = "bump" {}
		[NoScaleOffset] _MetallicSmoothness ("MetallicSmoothness", 2D) = "white" {}
		_Metallic ("Metallic", Range(0, 1)) = 1
		_Smoothness ("Smoothness", Range(0, 1)) = 1
		[NoScaleOffset] _Emission ("Emission", 2D) = "white" {}
		_EmissionColor ("Emission Color", Vector) = (0,0,0,0)
		_EmissionPower ("Emission Power", Range(0, 60)) = 0
		_RimEmissionNormal ("Rim Emission Normal", Range(0, 1)) = 1
		_RimEmissionColor ("Rim Emission Color", Vector) = (1,0,0,1)
		_RimEmissionExp ("Rim Emission Exp", Range(0.1, 10)) = 3
		_RimEmissionPower ("Rim Emission Power", Range(0, 60)) = 6
		[NoScaleOffset] _DissolveTexture ("Dissolve Texture", 2D) = "white" {}
		_DissolveTextureScaleU ("Dissolve Texture Scale U", Float) = 1
		_DissolveTextureScaleV ("Dissolve Texture Scale V", Float) = 1
		[ToggleUI] _DISSOLVETEXTUREFLIP ("Dissolve Texture Flip", Float) = 0
		[NoScaleOffset] _DissolveDirectionMask ("Dissolve Direction Mask", 2D) = "black" {}
		[ToggleUI] _DISSOLVEDIRECTIONMASKFLIP ("Dissolve Direction Mask Flip", Float) = 0
		_DissolveDirectionScale ("Dissolve Direction Scale", Range(0, 4)) = 1
		_DissolveEmissionOffset ("Dissolve Emission Offset", Float) = 0
		_DissolveEmissionColor ("Dissolve Emission Color", Vector) = (1,0,0,1)
		_DissolveEmissionPower ("Dissolve Emission Power", Range(0, 80)) = 1
		_DissolveEmissionRemapMax ("Dissolve Emission Remap Max", Range(0, 1)) = 0.25
		_DissolveEmissionExp ("Dissolve Emission Exp", Range(0.2, 8)) = 1
		[ToggleUI] _DISSOLVEMANUALCONTROL ("Dissolve Manual Control", Float) = 0
		_DissolveManualProgress ("Dissolve Manual Progress", Range(-2, 2)) = 0
		[ToggleUI] _EMISSIONVSCONTROLENABLED ("Emission VS Control Enabled", Float) = 0
		[HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
		[HideInInspector] _QueueControl ("_QueueControl", Float) = -1
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
		[Toggle] _RIMEMISSIONENABLED ("Rim Emission Enabled", Float) = 0
		[Toggle] _RIMEMISSIONAFFECTSMASK ("Rim Emission Affects Mask", Float) = 0
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

			TEXTURE2D(_AlbedoDecalMask); SAMPLER(sampler_AlbedoDecalMask); float4 _AlbedoDecalMask_ST;
			#define SAMPLE_TEX(uv) SAMPLE_TEXTURE2D(_AlbedoDecalMask, sampler_AlbedoDecalMask, uv)
			#define TEX_ST ((any(_AlbedoDecalMask_ST.xy)) ? _AlbedoDecalMask_ST : float4(1,1,0,0))
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
