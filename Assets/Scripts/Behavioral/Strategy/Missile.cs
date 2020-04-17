using UnityEngine;

namespace Behavioral.Strategy
{
    public abstract class Missile: ScriptableObject
    {
        protected ISeekBehaviour SeekBehaviour;

        public void SetSeekBehaviour(ISeekBehaviour seekType)
        {
            this.SeekBehaviour = seekType;
        }

        public void ApplySeek()
        {
            SeekBehaviour.Seek();
        }
    }
}