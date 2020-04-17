using UnityEngine;

namespace Behavioral.Strategy
{
    public class SeekWithGPS: ISeekBehaviour
    {
        public void Seek()
        {
            Debug.Log("Seeking target with GPS coordinates");
        }
    }
}