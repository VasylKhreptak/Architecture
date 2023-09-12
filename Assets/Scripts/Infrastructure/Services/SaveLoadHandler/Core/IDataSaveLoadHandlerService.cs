using Infrastructure.Data.Core;

namespace Infrastructure.Services.SaveLoadHandler.Core
{
    public interface IDataSaveLoadHandlerService : IDataSaveLoadHandler
    {
        public void Add<T>(T t) where T : IDataSaveHandler, IDataLoadHandler;
        
        public void Remove<T>(T t) where T : IDataSaveHandler, IDataLoadHandler;
    }
}
