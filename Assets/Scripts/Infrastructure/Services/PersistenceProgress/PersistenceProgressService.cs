using Infrastructure.Data;
using Infrastructure.Services.PersistenceProgress.Core;

namespace Infrastructure.Services.PersistenceProgress
{
    public class PersistenceProgressService : IPersistenceProgressService
    {
        public PlayerData PlayerData { get; set; }
    }
}
