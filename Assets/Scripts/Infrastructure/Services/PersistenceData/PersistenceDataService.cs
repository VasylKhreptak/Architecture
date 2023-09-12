using Infrastructure.Data.Persistence;
using Infrastructure.Services.PersistenceData.Core;
using Infrastructure.Services.SaveLoad.Core;
using Zenject;

namespace Infrastructure.Services.PersistenceData
{
    public class PersistenceDataService : IPersistenceDataService
    {
        private const string PlayerDataKey = "PlayerData";

        private ISaveLoadService _saveLoadService;

        [Inject]
        private void Constructor(ISaveLoadService saveLoadService)
        {
            _saveLoadService = saveLoadService;
        }

        public PlayerData PlayerData { get; set; }

        public void Save()
        {
            _saveLoadService.Save(PlayerDataKey, PlayerDataKey);
        }

        public void Load()
        {
            PlayerData = _saveLoadService.Load(PlayerDataKey, new PlayerData());
        }
    }
}
