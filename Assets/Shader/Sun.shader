// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:33209,y:32712,varname:node_9361,prsc:2|custl-1644-OUT;n:type:ShaderForge.SFN_Slider,id:9026,x:32160,y:32837,ptovrint:False,ptlb:node_9026,ptin:_node_9026,varname:node_9026,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:10;n:type:ShaderForge.SFN_Fresnel,id:6562,x:32436,y:33037,varname:node_6562,prsc:2|EXP-9026-OUT;n:type:ShaderForge.SFN_Color,id:5868,x:32191,y:33198,ptovrint:False,ptlb:node_5868,ptin:_node_5868,varname:node_5868,prsc:2,glob:False,taghide:False,taghdr:True,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Multiply,id:1417,x:32509,y:33191,varname:node_1417,prsc:2|A-6562-OUT,B-5868-RGB;n:type:ShaderForge.SFN_Multiply,id:4401,x:32776,y:33166,varname:node_4401,prsc:2|A-1417-OUT,B-1680-OUT;n:type:ShaderForge.SFN_Slider,id:1680,x:32539,y:33380,ptovrint:False,ptlb:node_1680,ptin:_node_1680,varname:node_1680,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:10;n:type:ShaderForge.SFN_Add,id:1644,x:32879,y:32933,varname:node_1644,prsc:2|A-2914-RGB,B-4401-OUT;n:type:ShaderForge.SFN_Tex2d,id:2914,x:32563,y:32777,ptovrint:False,ptlb:node_2914,ptin:_node_2914,varname:node_2914,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:81fbfbdca7610b34a8e0b4491dee2f12,ntxv:0,isnm:False;proporder:9026-5868-1680-2914;pass:END;sub:END;*/

Shader "Shader Forge/Sun" {
    Properties {
        _node_9026 ("node_9026", Range(0, 10)) = 1
        [HDR]_node_5868 ("node_5868", Color) = (1,0,0,1)
        _node_1680 ("node_1680", Range(0, 10)) = 1
        _node_2914 ("node_2914", 2D) = "white" {}
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float _node_9026;
            uniform float4 _node_5868;
            uniform float _node_1680;
            uniform sampler2D _node_2914; uniform float4 _node_2914_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                UNITY_FOG_COORDS(3)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
////// Lighting:
                float4 _node_2914_var = tex2D(_node_2914,TRANSFORM_TEX(i.uv0, _node_2914));
                float3 finalColor = (_node_2914_var.rgb+((pow(1.0-max(0,dot(normalDirection, viewDirection)),_node_9026)*_node_5868.rgb)*_node_1680));
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    
}
