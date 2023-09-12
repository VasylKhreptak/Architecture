using Infrastructure.Data;
using Infrastructure.Services.PersistenceProgress.Core;

namespace Infrastructure.Services.PersistenceData
{
    public class PersistenceDataService : IPersistenceDataService
    {
        public PlayerData PlayerData { get; set; }
    }
}
