using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Creational.Prototype
{
    public class Enemy : MonoBehaviour, ICopyable
    {
        public ICopyable Copy()
        {
            return Instantiate(this);
        }
    }
}
