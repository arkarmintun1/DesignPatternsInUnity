using System;

namespace Behavioral.Strategy
{
    public class Tomahawk: Missile
    {
        private void Awake()
        {
            this.SeekBehaviour = new SeekWithGPS();
        }
    }
}