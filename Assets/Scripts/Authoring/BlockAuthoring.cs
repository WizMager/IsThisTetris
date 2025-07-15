using Components;
using Unity.Entities;
using UnityEngine;

namespace Authoring
{
    public class BlockAuthoring : MonoBehaviour
    {
        private class BlockAuthoringBaker : Baker<BlockAuthoring>
        {
            public override void Bake(BlockAuthoring authoring)
            {
                var entity = GetEntity(TransformUsageFlags.Dynamic);
                AddComponent<BlockTagComponent>(entity);
            }
        }
    }
}