using Infrastructure.Data.Core;
using Infrastructure.Data.Persistence;

namespace Infrastructure.Services.PersistenceData.Core
{
    public interface IPersistenceDataService : ISaveLoadHandler
    {
        public PlayerData PlayerData { get; set; }
    }
}
