using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;

namespace Components
{
    [MaterialProperty("_BaseColor")]
    public struct BlockColorComponent : IComponentData
    {
        public float4 Value;
    }
}