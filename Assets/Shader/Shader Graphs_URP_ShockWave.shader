Shader "Shader Graphs/URP_ShockWave" {
	Properties {
		[NoScaleOffset] _MainTexture ("Main Texture", 2D) = "white" {}
		_MainTexTiling ("MainTex Tiling", Vector) = (1,1,0,0)
		[NoScaleOffset] _Noise ("Noise", 2D) = "white" {}
		_NoiseTiling ("Noise Tiling", Vector) = (1,1,0,0)
		[NoScaleOffset] _Flow ("Flow", 2D) = "white" {}
		_FlowTiling ("Flow Tiling", Vector) = (1,1,0,0)
		[NoScaleOffset] _Mask ("Mask", 2D) = "white" {}
		_MaskTiling ("Mask Tiling", Vector) = (1,1,0,0)
		_DistortionSpeedXYPowerZ ("Distortion Speed XY Power Z", Vector) = (0,0,0,0)
		_NoiseSpeedXYPowerZ ("Noise Speed XY Power Z", Vector) = (0,0,1,0)
		_Emission ("Emission", Float) = 2
		_NoiseOpacityLerp ("Noise Opacity Lerp", Range(0, 1)) = 0
		[ToggleUI] _UV2Tswitch ("UV2Tswitch", Float) = 0
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

			TEXTURE2D(_MainTexture); SAMPLER(sampler_MainTexture); float4 _MainTexture_ST;
			#define SAMPLE_TEX(uv) SAMPLE_TEXTURE2D(_MainTexture, sampler_MainTexture, uv)
			#define TEX_ST ((any(_MainTexture_ST.xy)) ? _MainTexture_ST : float4(1,1,0,0))
			#define TINT half4(1,1,1,1)
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
				c.a *= 0.15;
				return c;
			}
			ENDHLSL
		}
	}
}
