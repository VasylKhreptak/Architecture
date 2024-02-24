using Infrastructure.Services.PersistentData.Core;
using Infrastructure.Services.SaveLoad.Core;

namespace Infrastructure.Services.PersistentData
{
    public class PersistentDataService : IPersistentDataService
    {
        private readonly ISaveLoadService _saveLoadService;

        public PersistentDataService(ISaveLoadService saveLoadService)
        {
            _saveLoadService = saveLoadService;
        }

        public Data.Persistent.PersistentData Data { get; private set; }

        public void Save() => _saveLoadService.Save(nameof(PersistentData), Data);

        public void Load() => Data = _saveLoadService.Load<Data.Persistent.PersistentData>(nameof(PersistentData));
    }
}