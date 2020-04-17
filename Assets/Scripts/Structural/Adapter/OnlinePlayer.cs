using UnityEngine;

namespace Structural.Adapter
{
    public class OnlinePlayer: ScriptableObject
    {
        public string GetFirstName(int id)
        {
            // Lookup online database
            return "John";
        }

        public string GetLastName(int id)
        {
            // Lookup online database
            return "Doe";
        }

        public string GetFullName(int id)
        {
            // Lookup online database
            return "Doe John";
        }
    }
}