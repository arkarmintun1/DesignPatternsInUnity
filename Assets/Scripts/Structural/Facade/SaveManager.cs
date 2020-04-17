using System.IO;
using System.Net.Mime;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace Structural.Facade
{
    public class SaveManager: Singleton<SaveManager>
    {
        private PlayerData _playerData;
        private UIManager _uiManager;
        private ScoreManager _scoreManager;
        private CloudManager _cloudManager;

        public void SaveGame(Player player)
        {
            _uiManager = new UIManager();
            _uiManager.DisplaySaveIcon();
            
            _playerData = new PlayerData();
            _playerData.health = player.GetHealth();
            _playerData.playerId = player.GetPlayerId();
            
            _scoreManager = new ScoreManager();
            _playerData.score = _scoreManager.GetScore(player.GetPlayerId());
            
            SerializePlayerData(_playerData, true);
        }

        private void SerializePlayerData(PlayerData playerData, bool isCloudSave)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = File.Create(Application.persistentDataPath + "/playerInfo.dat");
            binaryFormatter.Serialize(fileStream, playerData);
            fileStream.Close();

            if (isCloudSave)
            {
                _cloudManager = new CloudManager();
                _cloudManager.UploadSaveGame(Application.persistentDataPath + "/playerInfo.dat");
            }
        }
    }
}