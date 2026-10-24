Shader "SineVFX/TopDownEffects/SG/DissolveParticleSimple" {
	Properties {
		_FinalColor ("Final Color", Vector) = (1,1,1,1)
		_FinalPower ("Final Power", Range(0, 60)) = 4
		_FinalOpacityPower ("Final Opacity Power", Float) = 1
		[NoScaleOffset] _Ramp ("Ramp", 2D) = "white" {}
		_RampColorTint ("Ramp Color Tint", Vector) = (1,1,1,1)
		[ToggleUI] _RAMPAFFECTEDBYVERTEXCOLOR ("Ramp Affected By Vertex Color", Float) = 0
		_RampAffectedByDynamics ("Ramp Affected By Dynamics", Range(0, 1)) = 1
		_RampOffsetExp ("Ramp Offset Exp", Range(0.2, 8)) = 1
		[NoScaleOffset] _MainTex ("MainTex", 2D) = "white" {}
		_MainTexChannels ("MainTex Channels", Vector) = (1,0,0,0)
		_MainTexRotation ("MainTex Rotation", Range(0, 1)) = 0
		_FlipbookRows ("Flipbook Rows", Float) = 1
		_FlipbookColums ("Flipbook Colums", Float) = 1
		[NoScaleOffset] _DissolveTexture ("Dissolve Texture", 2D) = "white" {}
		[ToggleUI] _DISSOLVETEXTUREFLIP ("Dissolve Texture Flip", Float) = 0
		_DissolveTextureScale ("Dissolve Texture Scale", Float) = 1
		_DissolveExp ("Dissolve Exp", Float) = 2
		_DissolveExpReversed ("Dissolve Exp Reversed", Float) = 2
		[HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
		[HideInInspector] _QueueControl ("_QueueControl", Float) = -1
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
		[Toggle] _RAMPENABLED ("Ramp Enabled", Float) = 0
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

			TEXTURE2D(_MainTex); SAMPLER(sampler_MainTex); float4 _MainTex_ST;
			#define SAMPLE_TEX(uv) SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, uv)
			#define TEX_ST ((any(_MainTex_ST.xy)) ? _MainTex_ST : float4(1,1,0,0))
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
