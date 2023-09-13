using Infrastructure.Data.Persistence;
using Infrastructure.Services.RuntimeData.Core;
using Infrastructure.Services.SaveLoad.Core;
using Zenject;

namespace Infrastructure.Services.RuntimeData
{
    public class RuntimeDataService : IRuntimeDataService
    {
        private ISaveLoadService _saveLoadService;

        public PlayerData PlayerData { get; set; }

        [Inject]
        private void Constructor(ISaveLoadService saveLoadService)
        {
            _saveLoadService = saveLoadService;
        }

        public void Save()
        {
            _saveLoadService.Save(PlayerData, nameof(PlayerData));
        }

        public void Load()
        {
            PlayerData = _saveLoadService.Load(nameof(PlayerData), new PlayerData());
        }
    }
}
