using Infrastructure.Coroutines.Runner;
using Infrastructure.Coroutines.Runner.Core;
using Infrastructure.Curtain;
using Infrastructure.Curtain.Core;
using Infrastructure.SceneManagement;
using Infrastructure.SceneManagement.Core;
using Infrastructure.Services.Framerate;
using Infrastructure.Services.ID;
using Infrastructure.Services.ID.Core;
using Infrastructure.Services.Log;
using Infrastructure.Services.Log.Core;
using Infrastructure.Services.RuntimeData;
using Infrastructure.Services.RuntimeData.Core;
using Infrastructure.Services.SaveLoad;
using Infrastructure.Services.SaveLoad.Core;
using Infrastructure.Services.SaveLoadHandler;
using Infrastructure.Services.StaticData;
using Infrastructure.Services.StaticData.Core;
using UnityEngine;
using Zenject;

namespace Infrastructure.Zenject.Installers.ProjectContext.Bootstrap
{
    public class BootstrapInstaller : MonoInstaller
    {
        [Header("References")]
        [SerializeField] private GameObject _coroutineRunnerPrefab;
        [SerializeField] private GameObject _loadingCurtainPrefab;

        public override void InstallBindings()
        {
            BindMonoServices();
            BindServices();
            BindSignalBus();
        }

        private void BindMonoServices()
        {
            Container.Bind<ICoroutineRunner>().To<CoroutineRunner>().FromComponentInNewPrefab(_coroutineRunnerPrefab).AsSingle();
            Container.Bind<ILoadingCurtain>().To<LoadingCurtain>().FromComponentInNewPrefab(_loadingCurtainPrefab).AsSingle();
        }

        private void BindServices()
        {
            Container.Bind<IIDService>().To<IDService>().AsSingle();
            Container.Bind<ILogService>().To<LogService>().AsSingle();
            Container.Bind<ISceneLoader>().To<SceneLoader>().AsSingle();
            Container.Bind<IStaticDataService>().To<StaticDataService>().AsSingle();
            Container.Bind<IRuntimeDataService>().To<RuntimeDataService>().AsSingle();
            Container.Bind<ISaveLoadService>().To<SaveLoadService>().AsSingle();
            Container.BindInterfacesAndSelfTo<FramerateService>().AsSingle();
            
            BindSaveLoadHandlerService();
        }

        private void BindSaveLoadHandlerService()
        {
            SaveLoadHandlerService saveLoadHandlerService = Container.Instantiate<SaveLoadHandlerService>();

            saveLoadHandlerService.Add(Container.Resolve<IRuntimeDataService>());
            saveLoadHandlerService.AddLoadHandler(Container.Resolve<IStaticDataService>());

            Container.BindInterfacesAndSelfTo<SaveLoadHandlerService>().FromInstance(saveLoadHandlerService).AsSingle();
        }

        private void BindSignalBus()
        {
            SignalBusInstaller.Install(Container);
        }
    }
}
