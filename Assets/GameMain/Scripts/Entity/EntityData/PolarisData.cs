using UnityEngine;

namespace StarForce
{
    public class PolarisData: EntityData
    {
        public Vector2 Position { get; private set; }
        
        public bool Show { get; private set; }
        
        public PolarisData(int entityId, int typeId, Vector2 position, bool show) : base(entityId, typeId)
        {
            Position = position;
            Show = show;
        }
        
    }
}