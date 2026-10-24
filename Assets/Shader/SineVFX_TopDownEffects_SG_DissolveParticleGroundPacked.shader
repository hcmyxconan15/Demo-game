Shader "SineVFX/TopDownEffects/SG/DissolveParticleGroundPacked" {
	Properties {
		_FinalPower ("Final Power", Float) = 4
		_FinalOpacityPower ("Final Opacity Power", Float) = 1
		_FinalOpacityExp ("Final Opacity Exp", Range(0.2, 20)) = 1
		[NoScaleOffset] _Ramp ("Ramp", 2D) = "white" {}
		_RampColorTint ("Ramp Color Tint", Vector) = (1,1,1,1)
		_RampOffsetMultiply ("Ramp Offset Multiply", Range(0, 4)) = 1
		_RampOffsetExp ("Ramp Offset Exp", Range(0.2, 8)) = 1
		_RampSmoothstepMin ("Ramp Smoothstep Min", Float) = 0.25
		_RampSmoothstepMax ("Ramp Smoothstep Max", Float) = 0.75
		[NoScaleOffset] _PackedTex ("PackedTex", 2D) = "white" {}
		_HeightSlopeControl ("Height Slope Control", Range(0, 1)) = 0
		_HeightBoost ("Height Boost", Float) = 1
		_HeightMapNegate ("Height Map Negate", Range(0, 1)) = 0
		_AlbedoColor ("Albedo Color", Vector) = (0.6235294,0.4745098,0.427451,1)
		_AlbedoColor2 ("Albedo Color 2", Vector) = (0,0,0,1)
		_AlbedoMapExp ("Albedo Map Exp", Range(0.5, 2)) = 1
		[NoScaleOffset] _OpacityMask ("Opacity Mask", 2D) = "white" {}
		_OpacityMaskScaler ("Opacity Mask Scaler", Range(0.5, 2)) = 1
		_OpacityMaskPower ("Opacity Mask Power", Float) = 1
		_OpacityMaskExp ("Opacity Mask Exp", Range(0.2, 8)) = 0.2
		[NoScaleOffset] _SecondMask ("Second Mask", 2D) = "white" {}
		_SecondMaskScaleU ("Second Mask Scale U", Float) = 1
		_SecondMaskScaleV ("Second Mask Scale V", Float) = 1
		_SecondMaskExp ("Second Mask Exp", Range(0.2, 4)) = 1
		_SecondMaskEdgeGlow ("Second Mask Edge Glow", Float) = 0
		[NoScaleOffset] _SecondMaskProfile ("Second Mask Profile", 2D) = "white" {}
		[NoScaleOffset] _LavaAppearMask ("Lava Appear Mask", 2D) = "white" {}
		_LavaAppearMaskScaleU ("Lava Appear Mask Scale U", Float) = 1
		_LavaAppearMaskScaleV ("Lava Appear Mask Scale V", Float) = 1
		_LavaAppearMaskExp ("Lava Appear Mask Exp", Range(0.2, 8)) = 1
		[NoScaleOffset] _LavaNoise ("Lava Noise", 2D) = "white" {}
		_LavaNoiseScaleU ("Lava Noise Scale U", Float) = 1
		_LavaNoiseScaleV ("Lava Noise Scale V", Float) = 1
		_LavaNoiseNegate ("Lava Noise Negate", Range(0, 1)) = 0
		_LavaNoiseScrollSpeed ("Lava Noise Scroll Speed", Float) = 0
		[NoScaleOffset] _LavaNoiseDistortion ("Lava Noise Distortion", 2D) = "white" {}
		_LavaNoiseDistortionScaleU ("Lava Noise Distortion Scale U", Float) = 1
		_LavaNoiseDistortionScaleV ("Lava Noise Distortion Scale V", Float) = 1
		_LavaNoiseDistortionAmount ("Lava Noise Distortion Amount", Float) = 0
		_LavaNoiseDistortionScrollSpeed ("Lava Noise Distortion Scroll Speed", Float) = 0.075
		_LavaDistortionSlopeNegate ("Lava Distortion Slope Negate", Range(0, 1)) = 1
		_LavaDistortionSlopeStyle ("Lava Distortion Slope Style", Range(0, 1)) = 0
		_LavaOnlyInValleysNegate ("Lava Only In Valleys Negate", Range(0, 1)) = 1
		_LavaOnlyInValleysExp ("Lava Only In Valleys Exp", Range(0.2, 8)) = 1
		[NoScaleOffset] _SurfaceNoise ("Surface Noise", 2D) = "white" {}
		_SurfaceNoiseScaleU ("Surface Noise Scale U", Float) = 1
		_SurfaceNoiseScaleV ("Surface Noise Scale V", Float) = 1
		_SurfaceNoiseAdd ("Surface Noise Add", Range(0, 4)) = 0
		_SurfaceNoiseExp ("Surface Noise Exp", Range(0.2, 4)) = 1
		[ToggleUI] _VALLEYSEMISSIONBOOSTENABLED ("Valleys Emission Boost Enabled", Float) = 0
		_ValleysEmissionBoostAmount ("Valleys Emission Boost Amount", Range(0, 100)) = 80
		_ValleysEmissionBoostBloom ("Valleys Emission Boost Bloom", Range(0, 1)) = 1
		[NoScaleOffset] _Cracks ("Cracks", 2D) = "white" {}
		_CracksScaleU ("Cracks Scale U", Float) = 1
		_CracksScaleV ("Cracks Scale V", Float) = 1
		_CracksNegate ("Cracks Negate", Range(0, 1)) = 0
		_CracksNegateSlope ("Cracks Negate Slope", Range(0, 1)) = 0
		[NoScaleOffset] _DissolveTexture ("Dissolve Texture", 2D) = "white" {}
		[ToggleUI] _DISSOLVETEXTUREFLIP ("Dissolve Texture Flip", Float) = 1
		_DissolveTextureScaleU ("Dissolve Texture Scale U", Float) = 1
		_DissolveTextureScaleV ("Dissolve Texture Scale V", Float) = 1
		_DissolveTextureRandomMin ("Dissolve Texture Random Min", Range(0.5, 1)) = 0.9
		_DissolveTextureRandomMax ("Dissolve Texture Random Max", Range(1, 1.5)) = 1.1
		_DissolveExp ("Dissolve Exp", Float) = 6.47
		_DissolveExpReversed ("Dissolve Exp Reversed", Float) = 2
		[HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
		[HideInInspector] _QueueControl ("_QueueControl", Float) = -1
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
		[Toggle] _LAVANOISEENABLED ("Lava Noise Enabled", Float) = 0
		[Toggle] _SURFACENOISEENABLED ("Surface Noise Enabled", Float) = 0
		[Toggle] _CRACKSENABLED ("Cracks Enabled", Float) = 0
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

			TEXTURE2D(_OpacityMask); SAMPLER(sampler_OpacityMask); float4 _OpacityMask_ST;
			#define SAMPLE_TEX(uv) SAMPLE_TEXTURE2D(_OpacityMask, sampler_OpacityMask, uv)
			#define TEX_ST ((any(_OpacityMask_ST.xy)) ? _OpacityMask_ST : float4(1,1,0,0))
			#define TINT half4(1,1,1,1)
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
