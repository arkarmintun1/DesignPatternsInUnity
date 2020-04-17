using UnityEngine;

namespace Creational.Prototype
{
    public class EnemySpawner : MonoBehaviour
    {
        public ICopyable iCopy;

        public Enemy SpawnEnemy(Enemy prototype)
        {
            iCopy = prototype.Copy();
            return (Enemy) iCopy;
        }
    }
}