Shader "Exo-Planets/URP/Rings" {
	Properties {
		[NoScaleOffset] _RingsTexture ("Rings Texture", 2D) = "white" {}
		_Opacity ("Opacity", Range(0, 1)) = 1
		_BaseColoRing ("Base Color", Vector) = (0,0,0,0)
		_Color1 ("ColorMore", Vector) = (1,1,1,1)
		_Coloroffset ("Color offset", Range(0, 1)) = 0
		[HideInInspector] _LightSourceRings ("_LightSourceRings", Vector) = (1,0,0,0)
		_Size ("Size", Range(0, 5)) = 0.6
		_ShadowIntensity ("Shadow Intensity", Range(0, 1)) = 0
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