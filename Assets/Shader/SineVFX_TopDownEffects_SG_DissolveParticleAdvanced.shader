Shader "SineVFX/TopDownEffects/SG/DissolveParticleAdvanced" {
	Properties {
		_FinalColor ("Final Color", Vector) = (1,1,1,1)
		_FinalPower ("Final Power", Range(0, 60)) = 4
		_FinalOpacityPower ("Final Opacity Power", Range(0, 10)) = 1
		_FinalOpacityExp ("Final Opacity Exp", Range(0.2, 8)) = 1
		[NoScaleOffset] _Ramp ("Ramp", 2D) = "white" {}
		_RampColorTint ("Ramp Color Tint", Vector) = (1,1,1,1)
		_RampAffectedByDynamics ("Ramp Affected By Dynamics", Range(0, 1)) = 1
		_RampOffsetMultiply ("Ramp Offset Multiply", Float) = 1
		_RampOffsetExp ("Ramp Offset Exp", Range(0.2, 8)) = 1
		_RampIgnoreVertexColor ("Ramp Ignore Vertex Color", Range(0, 1)) = 0
		[NoScaleOffset] _CustomColorMask ("Custom Color Mask", 2D) = "white" {}
		_CustomColorMaskChannels ("Custom Color Mask Channels", Vector) = (1,0,0,0)
		_CustomColorMaskSwitch ("Custom Color Mask Switch", Range(0, 1)) = 0
		_CustomColorMaskAffectedByDynamics ("Custom Color Mask Affected By Dynamics", Range(0, 1)) = 1
		[NoScaleOffset] _MainMask ("Main Mask", 2D) = "white" {}
		_MainMaskScaleU ("Main Mask Scale U", Float) = 1
		_MainMaskScaleV ("Main Mask Scale V", Float) = 1
		_MainMaskChannelsMultiply ("Main Mask Channels Multiply", Vector) = (1,0,0,0)
		_MainMaskScrollSpeedU ("Main Mask Scroll Speed U", Float) = 0
		_MainMaskScrollSpeedV ("Main Mask Scroll Speed V", Float) = 0
		_MainMaskExp ("Main Mask Exp", Range(0.2, 4)) = 1
		[NoScaleOffset] _SecondMask ("Second Mask", 2D) = "white" {}
		_SecondMaskScaleU ("Second Mask Scale U", Float) = 1
		_SecondMaskScaleV ("Second Mask Scale V", Float) = 1
		[NoScaleOffset] _SecondMaskProfile ("Second Mask Profile", 2D) = "white" {}
		_SecondMaskNegate ("Second Mask Negate", Range(0, 1)) = 1
		_SecondMaskVSMoveU ("Second Mask VS Move U", Range(0, 1)) = 0
		_SecondMaskVSMoveV ("Second Mask VS Move V", Range(0, 1)) = 0
		_SecondMaskAffectsDistortion ("Second Mask Affects Distortion", Range(0, 1)) = 0
		_SecondMaskAffectsNoise01Negate ("Second Mask Affects Noise 01 Negate", Range(0, 1)) = 0
		_SecondMaskAffectsRamp ("Second Mask Affects Ramp", Range(0, 1)) = 0
		_SecondMaskBoostsEmission ("Second Mask Boosts Emission", Range(0, 40)) = 0
		_SecondMaskFractSwitch ("Second Mask Fract Switch", Range(0, 1)) = 0
		_SecondMaskFractShrink ("Second Mask Fract Shrink", Float) = 1
		[NoScaleOffset] _Noise01 ("Noise 01", 2D) = "white" {}
		_Noise01ScaleU ("Noise 01 Scale U", Float) = 1
		_Noise01ScaleV ("Noise 01 Scale V", Float) = 1
		_Noise01Negate ("Noise 01 Negate", Range(0, 1)) = 0
		_Noise01Exp ("Noise 01 Exp", Range(0.2, 8)) = 1
		_Noise01ScrollSpeedU ("Noise 01 Scroll Speed U", Float) = 0
		_Noise01ScrollSpeedV ("Noise 01 Scroll Speed V", Float) = 0
		_Noise01RandomMin ("Noise 01 Random Min", Range(0.5, 1)) = 0.9
		_Noise01RandomMax ("Noise 01 Random Max", Range(1, 1.5)) = 1.1
		_NOISE01RADIALScaleU ("Noise 01 Radial Scale U", Float) = 1
		_NOISE01RADIALScaleV ("Noise 01 Radial Scale V", Float) = 1
		[NoScaleOffset] _DissolveTexture ("Dissolve Texture", 2D) = "white" {}
		_DISSOLVETEXTUREFLIPSwitch ("Dissolve Texture Flip Switch", Range(0, 1)) = 1
		_DissolveTextureScaleU ("Dissolve Texture Scale U", Float) = 1
		_DissolveTextureScaleV ("Dissolve Texture Scale V", Float) = 1
		_DissolveTextureRandomMin ("Dissolve Texture Random Min", Range(0.5, 1)) = 0.9
		_DissolveTextureRandomMax ("Dissolve Texture Random Max", Range(1, 1.5)) = 1.1
		_DISSOLVETEXTURERADIALScaleU ("Dissolve Texture Radial Scale U", Float) = 1
		_DISSOLVETEXTURERADIALScaleV ("Dissolve Texture Radial Scale V", Float) = 1
		_DissolveExp ("Dissolve Exp", Float) = 2
		_DissolveExpReversed ("Dissolve Exp Reversed", Float) = 2
		_DissolveGlowAmount ("Dissolve Glow Amount", Range(0, 120)) = 0
		_DissolveGlowPower ("Dissolve Glow Power", Range(0.2, 8)) = 1
		_DissolveGlowOffset ("Dissolve Glow Offset", Range(-1, 1)) = 0.125
		_DissolveGlowAffectsRamp ("Dissolve Glow Affects Ramp", Range(0, 1)) = 1
		[NoScaleOffset] _DissolveMask ("Dissolve Mask", 2D) = "black" {}
		_DissolveMaskSteepness ("Dissolve Mask Steepness", Range(0, 10)) = 0
		[NoScaleOffset] _Distortion ("Distortion", 2D) = "white" {}
		_DistortionScaleU ("Distortion Scale U", Float) = 1
		_DistortionScaleV ("Distortion Scale V", Float) = 1
		_DistortionPower ("Distortion Power", Range(-1, 1)) = 0
		_DistortionRemapMin ("Distortion Remap Min", Range(-1, 0)) = 0
		_DistortionRemapMax ("Distortion Remap Max", Range(1, 2)) = 1
		_DistortionExp ("Distortion Exp", Range(0.2, 8)) = 1
		[ToggleUI] _DISTORTIONUVORSPHERICAL ("Distortion UV or Spherical", Float) = 0
		_DistortionSpheticalStyle ("Distortion Sphetical Style", Range(0, 1)) = 0
		_DistortionU ("Distortion U", Float) = 1
		_DistortionV ("Distortion V", Float) = 1
		_DistortionScrollSpeedU ("Distortion Scroll Speed U", Float) = 0
		_DistortionScrollSpeedV ("Distortion Scroll Speed V", Float) = 0
		[ToggleUI] _DISTORTIONRADIAL ("Distortion Radial", Float) = 0
		_DISTORTIONRADIALScaleU ("Distortion Radial Scale U", Float) = 1
		_DISTORTIONRADIALScaleV ("Distortion Radial Scale V", Float) = 1
		_DISTORTIONRADIALOldMethodSwitch ("Distortion Radial Old Method Switch", Range(0, 1)) = 0
		[NoScaleOffset] _DistortionMask ("Distortion Mask", 2D) = "white" {}
		_DistortionMaskNegate ("Distortion Mask Negate", Range(0, 1)) = 0
		_DistortionMaskVSMoveU ("Distortion Mask VS Move U", Range(0, 1)) = 0
		_DistortionMaskVSMoveV ("Distortion Mask VS Move V", Range(0, 1)) = 0
		[ToggleUI] _EMISSIONVERTEXSTREAMENABLED ("Emission Vertex Stream Enabled", Float) = 0
		_SoftParticlesDistance ("Soft Particles Distance", Float) = 0.2
		[HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
		[HideInInspector] _QueueControl ("_QueueControl", Float) = -1
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
		[Toggle] _RAMPENABLED ("Ramp Enabled", Float) = 0
		[Toggle] _NOISE01RADIAL ("Noise 01 Radial", Float) = 0
		[Toggle] _DISSOLVETEXTURERADIAL ("Dissolve Texture Radial", Float) = 0
		[Toggle] _DISTORTIONENABLED ("Distortion Enabled", Float) = 0
		[Toggle] _SOFTPARTICLESENABLED ("Soft Particles Enabled", Float) = 0
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
