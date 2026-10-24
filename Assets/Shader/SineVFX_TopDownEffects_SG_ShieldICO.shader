Shader "SineVFX/TopDownEffects/SG/ShieldICO" {
	Properties {
		_FinalColor ("Final Color", Vector) = (1,1,1,1)
		_FinalPower ("Final Power", Range(0, 100)) = 4
		_FinalOpacityPower ("Final Opacity Power", Float) = 1
		[NoScaleOffset] _Ramp ("Ramp", 2D) = "white" {}
		_RampColorTint ("Ramp Color Tint", Vector) = (1,1,1,1)
		_RampAffectedByDynamics ("Ramp Affected By Dynamics", Range(0, 1)) = 1
		_RampOffsetMultiply ("Ramp Offset Multiply", Float) = 1
		_RampOffsetExp ("Ramp Offset Exp", Range(0.2, 8)) = 1
		[NoScaleOffset] _MainTex ("MainTex", 2D) = "white" {}
		_MainTexChannels ("MainTex Channels", Vector) = (1,0,0,0)
		_MainTexScrollSpeed ("MainTex Scroll Speed", Float) = 0
		[NoScaleOffset] _OffsetTexture ("Offset Texture", 2D) = "white" {}
		_OffsetTextureScaleU ("Offset Texture Scale U", Float) = 1
		_OffsetTextureScaleV ("Offset Texture Scale V", Float) = 1
		_OffsetTextureScrollSpeedU ("Offset Texture Scroll Speed U", Float) = 0
		_OffsetTextureScrollSpeedV ("Offset Texture Scroll Speed V", Float) = 0
		_OffsetStyle ("Offset Style", Range(0, 1)) = 0
		_OffsetPower ("Offset Power", Float) = 0
		_OffsetGChannelMasking ("Offset G Channel Masking", Range(0, 1)) = 0
		_OffsetToOpacityNegate ("Offset To Opacity Negate", Range(0, 1)) = 1
		_OffsetToOpacityExp ("Offset To Opacity Exp", Range(0.2, 8)) = 1
		_OffsetToOpacityTopFixExp ("Offset To Opacity Top Fix Exp", Range(0.2, 8)) = 8
		_OffsetToOpacityTopFixValue ("Offset To Opacity Top Fix Value", Range(0, 1)) = 0.25
		[NoScaleOffset] _TrisGlareTexture ("Tris Glare Texture", 2D) = "white" {}
		_TrisGlareTextureScaleU ("Tris Glare Texture Scale U", Float) = 1
		_TrisGlareTextureScaleV ("Tris Glare Texture Scale V", Float) = 1
		_TrisGlareNegate ("Tris Glare Negate", Range(0, 1)) = 1
		_VerticalGradientFlipSwitch ("Vertical Gradient Flip Switch", Range(0, 1)) = 0
		_VerticalGradientAbsSwitch ("Vertical Gradient Abs Switch", Range(0, 1)) = 1
		_VerticalGradientClampSwitch ("Vertical Gradient Clamp Switch", Range(0, 1)) = 0
		_VerticalGradientRemapMax ("Vertical Gradient Remap Max", Float) = 1
		_VerticalGradientOffset ("Vertical Gradient Offset", Float) = 0
		[NoScaleOffset] _VerticalGradientProfile ("Vertical Gradient Profile", 2D) = "white" {}
		[ToggleUI] _INNERRIMENABLED ("Inner Rim Enabled", Float) = 0
		_InnerRimExp ("Inner Rim Exp", Range(0.1, 16)) = 4
		_InnerRimFlipSwitch ("Inner Rim Flip Switch", Range(0, 1)) = 1
		_WavesSpeed ("Waves Speed", Float) = 4
		_WavesScale ("Waves Scale", Float) = 8
		_DepthMaskDistance ("Depth Mask Distance", Float) = 1
		_DepthMaskRemapMax ("Depth Mask Remap Max", Float) = 1
		_DepthMaskExp ("Depth Mask Exp", Float) = 2
		_DepthMaskMultiply ("Depth Mask Multiply", Float) = 0.25
		_AppearGradientFlipSwitch ("Appear Gradient Flip Switch", Range(0, 1)) = 0
		_AppearGradientAbsSwitch ("Appear Gradient Abs Switch", Range(0, 1)) = 1
		_AppearGradientClampSwitch ("Appear Gradient Clamp Switch", Range(0, 1)) = 0
		_AppearGradientRemapMax ("Appear Gradient Remap Max", Float) = 1
		_AppearGradientOffset ("Appear Gradient Offset", Float) = 0
		_AppearGradientDynamicsNegate ("Appear Gradient Dynamics Negate", Range(0, 1)) = 0
		_AppearGradientDistortionAmount ("Appear Gradient Distortion Amount", Range(0, 1)) = 0
		[NoScaleOffset] _AppearGradientProfile ("Appear Gradient Profile", 2D) = "white" {}
		[HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
		[HideInInspector] _QueueControl ("_QueueControl", Float) = -1
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
		[Toggle] _RAMPENABLED ("Ramp Enabled", Float) = 0
		[Toggle] _TRISGLAREENABLED ("Tris Glare Enabled", Float) = 0
		[Toggle] _VERTICALGRADIENTENABLED ("Vertical Gradient Enabled", Float) = 0
		[Toggle] _WAVESENABLED ("Waves Enabled", Float) = 0
		[Toggle] _DEPTHMASKENABLED ("Depth Mask Enabled", Float) = 0
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;
			float4 _MainTex_ST;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct Vertex_Stage_Output
			{
				float2 uv : TEXCOORD0;
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.uv = (input.uv.xy * _MainTex_ST.xy) + _MainTex_ST.zw;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			Texture2D<float4> _MainTex;
			SamplerState sampler_MainTex;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, input.uv.xy);
			}

			ENDHLSL
		}
	}
	Fallback "Hidden/Shader Graph/FallbackError"
	//CustomEditor "UnityEditor.ShaderGraph.GenericShaderGraphMaterialGUI"
}