using System;
using UnityEngine;

namespace Structural.Adapter
{
    public class Client : MonoBehaviour
    {
        private OnlinePlayer _onlinePlayer;
        private OnlinePlayerObjectAdapter _onlinePlayerObjectAdapter;

        private IOnlinePlayer _onlinePlayerClassAdapter;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                _onlinePlayer = ScriptableObject.CreateInstance<OnlinePlayer>();
                _onlinePlayerObjectAdapter = ScriptableObject.CreateInstance<OnlinePlayerObjectAdapter>();

                string firstName = _onlinePlayer.GetFirstName(79);
                string lastName = _onlinePlayer.GetLastName(79);
                string fullNameLastFirst = _onlinePlayer.GetFullName(79);
                string fullNameFirstLast = _onlinePlayerObjectAdapter.GetFullName(_onlinePlayer, 79);
                
                Debug.Log(firstName);
                Debug.Log(lastName);
                Debug.Log(fullNameLastFirst);
                Debug.Log(fullNameFirstLast);
            }
            
            if (Input.GetKeyDown(KeyCode.C))
            {
                _onlinePlayerClassAdapter = ScriptableObject.CreateInstance<OnlinePlayerClassAdapter>();

                string firstName = _onlinePlayerClassAdapter.GetFirstName(79);
                string lastName = _onlinePlayerClassAdapter.GetLastName(79);
                string fullNameLastFirst = _onlinePlayerClassAdapter.GetFullNameLastFirst(79);
                string fullNameFirstLast = _onlinePlayerClassAdapter.GetFullNameFirstLast(79);
                
                Debug.Log(firstName);
                Debug.Log(lastName);
                Debug.Log(fullNameLastFirst);
                Debug.Log(fullNameFirstLast);
            }
        }
    }
}