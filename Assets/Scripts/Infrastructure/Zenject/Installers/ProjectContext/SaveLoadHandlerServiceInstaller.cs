using System.Runtime.InteropServices;
using Infrastructure.Services.PersistenceData.Core;
using Infrastructure.Services.SaveLoadHandler;
using Infrastructure.Services.SaveLoadHandler.Core;
using Infrastructure.Services.StaticData.Core;
using Zenject;

namespace Infrastructure.Zenject.Installers.ProjectContext
{
    public class SaveLoadHandlerServiceInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            SaveLoadHandlerService saveLoadHandlerService = new SaveLoadHandlerService();
            ISaveLoadHandlerService saveLoadHandlerServiceInterface = saveLoadHandlerService;

            saveLoadHandlerService.Add(Container.Resolve<IPersistenceDataService>());
            saveLoadHandlerService.AddLoadHandler(Container.Resolve<IStaticDataService>());
            
            Container.BindInterfacesTo<SaveLoadHandlerService>().FromInstance(saveLoadHandlerService).AsSingle();
            
            Container.BindInstance(saveLoadHandlerServiceInterface).AsSingle();
        }
    }
}
