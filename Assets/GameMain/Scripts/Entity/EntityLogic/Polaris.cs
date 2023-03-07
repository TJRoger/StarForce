using UnityEngine;

namespace StarForce
{
    public class Polaris: Entity
    {
        [SerializeField] 
        private PolarisData _polarisData = null;
        private bool _isSpawn = false; 
        protected override void OnShow(object userData)
        {
            base.OnShow(userData);
            _polarisData = (PolarisData)userData;
            CachedTransform.SetLocalPositionX(_polarisData.Position.x);
            CachedTransform.SetLocalPositionY(_polarisData.Position.y);
        }

        protected override void OnUpdate(float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(elapseSeconds, realElapseSeconds);
            if (!_polarisData.Show) {
                GameEntry.Entity.HideEntity(this);
            }
        }

        protected override void OnHide(bool isShutdown, object userData)
        {
            base.OnHide(isShutdown, userData);
            _isSpawn = false;
        }
    }
}