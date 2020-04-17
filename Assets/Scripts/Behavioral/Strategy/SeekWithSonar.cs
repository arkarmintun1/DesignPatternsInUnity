using UnityEngine;

namespace Behavioral.Strategy
{
    public class SeekWithSonar: ISeekBehaviour
    {
        public void Seek()
        {
            Debug.Log("Seeking with sonar");
        }
    }
}