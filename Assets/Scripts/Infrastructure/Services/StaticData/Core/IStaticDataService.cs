using Infrastructure.Data.Static;

namespace Infrastructure.Services.StaticData.Core
{
    public interface IStaticDataService
    {
        public GameConfig Config { get; }
        public GameBalance Balance { get; }

        public void Load();
    }
}
