using System;

namespace Behavioral.Strategy
{
    public class SideWinder: Missile
    {
        private void Awake()
        {
            this.SeekBehaviour = new SeekWithHeat();
        }
    }
}