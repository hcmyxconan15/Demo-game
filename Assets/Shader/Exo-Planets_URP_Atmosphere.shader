Shader "Exo-Planets/URP/Atmosphere" {
	Properties {
		_ExteriorIntensity ("Exterior Intensity", Range(0, 1)) = 0.25
		[HDR] _AtmosphereColor ("Atmosphere Color", Vector) = (0.3764706,1.027451,1.498039,0)
		_ExteriorSize ("Exterior Size", Range(0.1, 1)) = 0.3
		_LightSourceAtmo ("_LightSource", Vector) = (1,0,0,0)
		[Toggle] _EnableAtmosphere ("Enable Atmosphere", Float) = 1
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
	//CustomEditor "AtmosphereEditor"
}