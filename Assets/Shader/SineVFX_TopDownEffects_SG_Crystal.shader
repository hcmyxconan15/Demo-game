Shader "SineVFX/TopDownEffects/SG/Crystal" {
	Properties {
		[NoScaleOffset] _AlbedoTransparency ("AlbedoTransparency", 2D) = "white" {}
		_AlbedoColorTint ("Albedo Color Tint", Vector) = (1,1,1,1)
		[NoScaleOffset] [Normal] _Normal ("Normal", 2D) = "bump" {}
		[NoScaleOffset] _MetallicSmoothness ("MetallicSmoothness", 2D) = "white" {}
		_Metallic ("Metallic", Range(0, 1)) = 1
		_Smoothness ("Smoothness", Range(0, 1)) = 1
		_FinalColor ("Final Color", Vector) = (1,1,1,1)
		_FinalPower ("Final Power", Range(2, 90)) = 2
		[NoScaleOffset] _Ramp ("Ramp", 2D) = "white" {}
		_RampColorTint ("Ramp Color Tint", Vector) = (1,1,1,1)
		_RampRemapMax ("Ramp Remap Max", Range(0, 1)) = 0.33
		_RampOffsetExp ("Ramp Offset Exp", Range(0.2, 8)) = 1
		_InnerRimHackNormals ("Inner Rim Hack Normals", Range(0, 1)) = 1
		_InnerRimExp ("Inner Rim Exp", Range(0.1, 16)) = 4
		[NoScaleOffset] _InnerRimMask ("Inner Rim Mask", 2D) = "white" {}
		[ToggleUI] _INNERRIMMASKFLIP ("Inner Rim Mask Flip", Float) = 0
		_InnerRimMaskExp ("Inner Rim Mask Exp", Range(0.1, 4)) = 1
		_InnerRimMaskNegate ("Inner Rim Mask Negate", Range(0, 1)) = 0
		[NoScaleOffset] _InnerRimProfile ("Inner Rim Profile", 2D) = "white" {}
		[ToggleUI] _VERTICALGRADIENTWORLDPOSITION ("Vertical Gradient World Position", Float) = 0
		_VerticalGradientFlipSwitch ("Vertical Gradient Flip Switch", Range(0, 1)) = 0
		_VerticalGradientRemapMax ("Vertical Gradient Remap Max", Float) = 1
		_VerticalGradientOffset ("Vertical Gradient Offset", Float) = 0
		_VerticalGradientExp ("Vertical Gradient Exp", Range(0.1, 12)) = 1
		_AppearGradientFlipSwitch ("Appear Gradient Flip Switch", Range(0, 1)) = 1
		_AppearGradientAbsSwitch ("Appear Gradient Abs Switch", Range(0, 1)) = 1
		_AppearGradientRemapMax ("Appear Gradient Remap Max", Float) = 4
		_AppearGradientOffset ("Appear Gradient Offset", Float) = 1.25
		_AppearGradientExp ("Appear Gradient Exp", Range(0.1, 12)) = 4
		_AppearGradientPower ("Appear Gradient Power", Range(0, 10)) = 1
		_AppearVertexYOffset ("Appear Vertex Y Offset", Float) = 0
		[NoScaleOffset] _ParallaxNoise ("Parallax Noise", 2D) = "white" {}
		_ParallaxNoiseScaleU ("Parallax Noise Scale U", Float) = 1
		_ParallaxNoiseScaleV ("Parallax Noise Scale V", Float) = 1
		_ParallaxNoiseDepth ("Parallax Noise Depth", Float) = 0
		_ParallaxNoiseNegate ("Parallax Noise Negate", Range(0, 1)) = 0
		_EmissionVSSwitch ("Emission VS Switch", Range(0, 1)) = 0
		[HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
		[HideInInspector] _QueueControl ("_QueueControl", Float) = -1
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
		[Toggle] _RAMPENABLED ("Ramp Enabled", Float) = 0
		[Toggle] _INNERRIMENABLED ("Inner Rim Enabled", Float) = 0
		[Toggle] _INNERRIMPROFILEENABLED ("Inner Rim Profile Enabled", Float) = 0
		[Toggle] _PARALLAXNOISEENABLED ("Parallax Noise Enabled", Float) = 0
		[Toggle] _VERTICALGRADIENTENABLED ("Vertical Gradient Enabled", Float) = 0
		[Toggle] _APPEARGRADIENTENABLED ("Appear Gradient Enabled", Float) = 0
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return float4(1.0, 1.0, 1.0, 1.0); // RGBA
			}

			ENDHLSL
		}
	}
	Fallback "Hidden/Shader Graph/FallbackError"
	//CustomEditor "UnityEditor.ShaderGraph.GenericShaderGraphMaterialGUI"
}