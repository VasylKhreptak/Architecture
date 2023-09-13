using Infrastructure.Data.Persistence;
using Infrastructure.Services.PersistenceData.Core;
using Infrastructure.Services.SaveLoad.Core;
using Newtonsoft.Json;
using Plugins.Banks.Data.Economy.Core;
using UnityEngine;
using Zenject;
using Zenject.SpaceFighter;

namespace Infrastructure.Services.PersistenceData
{
    public class PersistenceDataService : IPersistenceDataService
    {
        private const string PlayerDataKey = "PlayerData";

        private ISaveLoadService _saveLoadService;

        public PlayerData PlayerData { get; set; }

        [Inject]
        private void Constructor(ISaveLoadService saveLoadService)
        {
            _saveLoadService = saveLoadService;
        }

        public void Save()
        {
            _saveLoadService.Save(PlayerData, PlayerDataKey);
        }

        public void Load()
        {
            PlayerData = _saveLoadService.Load(PlayerDataKey, new PlayerData());
        }
    }
}
