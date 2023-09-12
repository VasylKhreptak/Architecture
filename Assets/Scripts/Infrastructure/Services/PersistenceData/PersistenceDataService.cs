using Infrastructure.Data;
using Infrastructure.Data.Persistence;
using Infrastructure.Services.PersistenceData.Core;

namespace Infrastructure.Services.PersistenceData
{
    public class PersistenceDataService : IPersistenceDataService
    {
        public PlayerData PlayerData { get; set; }
        
        public void Save()
        {
            
        }
        
        public void Load()
        {
            
        }
    }
}
