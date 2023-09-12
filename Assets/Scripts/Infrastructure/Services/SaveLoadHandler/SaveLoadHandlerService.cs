using System;
using System.Collections.Generic;
using Infrastructure.Data.Core;
using Infrastructure.Services.SaveLoadHandler.Core;
using Zenject;

namespace Infrastructure.Services.SaveLoadHandler
{
    public class SaveLoadHandlerService : IDataSaveLoadHandlerService, IInitializable, IDisposable
    {
        private List<IDataSaveHandler> _saveHandlers;
        private List<IDataLoadHandler> _loadHandlers;

        public void Save()
        {
            foreach (var saveHandler in _saveHandlers)
            {
                saveHandler.Save();
            }
        }

        public void Load()
        {
            foreach (var loadHandler in _loadHandlers)
            {
                loadHandler.Load();
            }
        }

        public void Add<T>(T t) where T : IDataSaveHandler, IDataLoadHandler
        {
            if (t is IDataSaveHandler dataSaveHandler)
            {
                _saveHandlers.Add(dataSaveHandler);
            }

            if (t is IDataLoadHandler dataLoadHandler)
            {
                _loadHandlers.Add(dataLoadHandler);
            }
        }

        public void Remove<T>(T t) where T : IDataSaveHandler, IDataLoadHandler
        {
            if (t is IDataSaveHandler dataSaveHandler)
            {
                _saveHandlers.Remove(dataSaveHandler);
            }

            if (t is IDataLoadHandler dataLoadHandler)
            {
                _loadHandlers.Remove(dataLoadHandler);
            }
        }
        
        public void Initialize()
        {
            Load();
        }
        
        public void Dispose()
        {
            Save();
        }
    }
}
