using Infrastructure.Data;

namespace Infrastructure.Services.PersistenceProgress.Core
{
    public interface IPersistenceProgressService
    {
        public PlayerData PlayerData { get; set; }
    }
}
