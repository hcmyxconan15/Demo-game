Shader "FORGE3D/Battleships/Ship PBR (Specular)" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[ASEBegin] _Tint ("Tint", Vector) = (0.5294118,0.5294118,0.5294118,1)
		_Albedo ("Albedo", 2D) = "white" {}
		_Normal ("Normal", 2D) = "bump" {}
		_SpecularSmoothness ("SpecularSmoothness", 2D) = "white" {}
		_Specular ("Specular", Range(0.03, 1)) = 0.03
		_Smoothness ("Smoothness", Range(0, 1)) = 0
		_NormalScale ("NormalScale", Range(0, 1)) = 0
		_Mask ("Mask", 2D) = "black" {}
		_Windows ("Windows", Vector) = (1,0,0,1)
		_TeamColor ("TeamColor", Vector) = (1,0,0,1)
		_BlinkLights ("BlinkLights", Vector) = (1,0,0,1)
		[ASEEnd] _Exhaust ("Exhaust", Vector) = (1,0,0,1)
		[HideInInspector] _texcoord ("", 2D) = "white" {}
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
	Fallback "Hidden/InternalErrorShader"
	//CustomEditor "UnityEditor.ShaderGraph.PBRMasterGUI"
}