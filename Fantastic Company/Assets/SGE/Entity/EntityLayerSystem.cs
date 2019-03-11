using UnityEngine;
using System.Collections.Generic;

namespace SGE
{
    namespace Entity
    {
        public class EntityLayerSystem {
            private static readonly HashSet<EntityLayerSystem> systems = new HashSet<EntityLayerSystem>();
            protected HashSet<Entity> entites = new HashSet<Entity>();
            public EntityLayerSystem()
            {
                systems.Add(this);
            }
        }
    }
}
