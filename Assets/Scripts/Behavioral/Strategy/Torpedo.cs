using System;

namespace Behavioral.Strategy
{
    public class Torpedo: Missile
    {
        private void Awake()
        {
            this.SeekBehaviour = new SeekWithSonar();
        }
    }
}