using Infrastructure.Data;

namespace Infrastructure.Services.PersistenceProgress.Core
{
    public interface IPersistenceDataService
    {
        public PlayerData PlayerData { get; set; }
    }
}
