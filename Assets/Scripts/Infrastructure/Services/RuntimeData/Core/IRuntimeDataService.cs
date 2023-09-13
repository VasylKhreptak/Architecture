using Infrastructure.Data.Core;
using Infrastructure.Data.Persistence;

namespace Infrastructure.Services.RuntimeData.Core
{
    public interface IRuntimeDataService : ISaveLoadHandler
    {
        public PlayerData PlayerData { get; set; }
    }
}
