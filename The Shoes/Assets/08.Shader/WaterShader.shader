Shader "Custom/WaterShader"
{
    Properties
    {
        _CubeMap("CubeMap", cube) = "" {}
        _MainTex("MainTex", 2D) = "white" {}
        _BumpMap("Water Bump", 2D) = "bump" {}
        _BumpMap2("Water Bump2", 2D) = "bump" {}

        _SpecColor("Spec", color) = (1,1,1,1)
    }
        SubShader
        {
            Tags { "RenderType" = "Opaque"}
            LOD 200

            GrabPass{}

            CGPROGRAM
            #pragma surface surf BlinnPhong vertex:vert
            #pragma target 3.0

            samplerCUBE _CubeMap;
            sampler2D _BumpMap, _BumpMap2;
            sampler2D _MainTex, _GrabTexture;

            float4 _SepcColor;

            struct Input
            {
                float2 uv_MainTex, uv_BumpMap, uv_BumpMap2;
                float3 worldRefl;
                float3 viewDir;
                float4 screenPos;

                INTERNAL_DATA
            };

            //기울기, 진폭, 파장 조절 부분
            void vert(inout appdata_full v)
            {
                v.vertex.y += sin((abs(v.texcoord.x * 2 - 1) * 3) + sin(_Time.y * 1)) * 0.1;
            }

            void surf(Input IN, inout SurfaceOutput o)
            {
                // Normal 반대로 움직임
                float3 fNormal1 = UnpackNormal(tex2D(_BumpMap, IN.uv_BumpMap + float2(_Time.y * 0.07, 0.0f)));
                float3 fNormal2 = UnpackNormal(tex2D(_BumpMap2, IN.uv_BumpMap2 - float2(_Time.y * 0.05, 0.0f)));
                o.Normal = (fNormal1 + fNormal2) / 2;

                // 큐브맵과 환경반사 계산
                float3 fRefl = texCUBE(_CubeMap, WorldReflectionVector(IN, o.Normal));

                // 프리넬반사 ...수면과 뷰벡터 계산
                float fRim = dot(o.Normal, IN.viewDir);
                fRim = saturate(pow(1 - fRim, 2));

                // 굴절
                float4 fNoise = tex2D(_MainTex, IN.uv_MainTex + _Time.x);
                float3 scrPos = IN.screenPos.xyz / (IN.screenPos.w + 0.0000001);
                float3 fGrab = tex2D(_GrabTexture, scrPos.xy + fNoise.r * 0.05);

                o.Gloss = 1;
                o.Specular = 0.9;
                o.Alpha = 1;

                o.Emission = lerp(fGrab+0.05, fRefl-0.05, fRim);
            }
            ENDCG
        }
            FallBack "Diffuse"
}

/*
* 11/20
텍스쳐 두개가 반대방향으로 움직이고, 자체에 기울기+sin을 주어 파도치게 만든다.

* 11/22
반사는 카메라와 수면의 기울기에 따라 수직과 가까우면 투명해 보이도록 프리넬 반사를 이용함
물거품? 도 만들면 좋을 것 같은데 조금 더 생각해보면 좋을 것 같음

그래프로 만든 버전도 만들어볼까 생각중.
생각보다 원하던 느낌이 아니라 아쉽다.

*/