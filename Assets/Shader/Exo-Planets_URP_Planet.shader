Shader "Exo-Planets/URP/Planet" {
	Properties {
		[NoScaleOffset] _ColorTexture ("Color Texture", 2D) = "gray" {}
		[Toggle] _EnableClouds ("Enable Clouds", Float) = 1
		_PolarMask ("Polar Mask", 2D) = "white" {}
		[NoScaleOffset] _NecessaryWaterMask ("Necessary Water Mask", 2D) = "black" {}
		[NoScaleOffset] _CloudsTexture ("CloudsTexture", 2D) = "black" {}
		_CitiesTexture ("Cities Texture", 2D) = "black" {}
		[HDR] _ColorA ("Color + A", Vector) = (4.541205,4.541205,4.541205,0.3607843)
		_CloudSpeed ("Cloud Speed", Range(0, 10)) = 1
		_ShadowsYOffset ("Shadows Y Offset", Range(-0.02, 0.02)) = -0.005
		_ShadowsXOffset ("Shadows X Offset", Range(-0.02, 0.02)) = -0.005
		_ShadowsSharpness ("Shadows Sharpness", Range(0, 10)) = 2.5
		[Toggle] _EnableCities ("Enable Cities", Float) = 1
		[HDR] _Citiescolor ("Cities color", Vector) = (7.906699,2.649365,1.200494,0)
		[HDR] _AtmosphereColor ("Atmosphere Color", Vector) = (0.3764706,1.027451,1.498039,0)
		_InteriorSize ("Interior Size", Range(-2, 10)) = 0.3
		_IlluminationSmoothness ("Illumination Smoothness", Float) = 4
		_InteriorIntensity ("Interior Intensity", Range(0, 1)) = 0.65
		_IlluminationAmbient ("Illumination Ambient", Vector) = (0.09019608,0.06666667,0.1490196,0)
		[Toggle] _EnableAtmosphere ("Enable Atmosphere", Float) = 1
		_LightSource ("_LightSource", Vector) = (1,0,0,0)
		_CitiesDetail ("Cities Detail", Range(1, 20)) = 4
		_EnumFloat ("_EnumFloat", Float) = 0
		_WaterColor ("Water Color", Vector) = (0.282353,0.4431373,0.5176471,0)
		_SpecularIntensity ("Specular Intensity", Range(0, 1)) = 1
		_Normals ("Normals", 2D) = "bump" {}
		_NormalsIntensity ("Normals Intensity", Range(0, 2)) = 1
		[Toggle] _EnableWater ("Enable Water", Float) = 1
		_CloudsNormals ("Clouds Normals", 2D) = "bump" {}
		_BaseColormodifier ("Base Color modifier", Vector) = (1,1,1,0)
		_ShadowColorA ("Shadow Color + A", Vector) = (0.09803922,0.2313726,0.4117647,1)
		_ReliefIntensity ("ReliefIntensity", Float) = 2
		_ReliefSmoothness ("Relief Smoothness", Range(0, 5)) = 2
		_IlluminationBoost ("Illumination Boost", Float) = 1
		_SkyblendA ("Sky blend (A)", Vector) = (0.55918,0.6696877,0.766,0)
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
	//CustomEditor "PlanetEditor"
}