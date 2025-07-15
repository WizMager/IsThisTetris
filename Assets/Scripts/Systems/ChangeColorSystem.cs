using Components;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

namespace Systems
{
    public partial struct ChangeColorSystem : ISystem
    {
        public void OnUpdate(ref SystemState state)
        {
            var ecb = new EntityCommandBuffer(Allocator.TempJob);
            
            foreach (var (colorProperty, entity) in SystemAPI.Query<RefRO<BlockColorComponent>>().WithAll<BlockComponent>().WithEntityAccess())
            {
                //colorProperty maybe will be need for read current color
                ecb.AddComponent(entity, new BlockColorComponent
                {
                    Value = new float4(1, 1, 1, 1)
                });
            }
            
            ecb.Playback(state.EntityManager);
        }
    }
}