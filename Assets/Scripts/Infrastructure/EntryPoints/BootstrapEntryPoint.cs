using Infrastructure.Curtain.Core;
using Infrastructure.EntryPoints.Core;
using Infrastructure.SceneManagement.Core;
using Infrastructure.Services.SaveLoadHandler.Core;
using Infrastructure.Services.StaticData.Core;
using UnityEngine;
using Zenject;

namespace Infrastructure.EntryPoints
{
    public class BootstrapEntryPoint : MonoBehaviour, IEntryPoint
    {
        private ISceneLoader _sceneLoader;
        private IStaticDataService _staticDataService;
        private ILoadingScreen _loadingScreen;
        private ISaveLoadHandlerService _saveLoadHandlerService;

        [Inject]
        private void Constructor(ISceneLoader sceneLoader,
            IStaticDataService staticDataService,
            ILoadingScreen loadingScreen,
            ISaveLoadHandlerService saveLoadHandlerService)
        {
            _sceneLoader = sceneLoader;
            _staticDataService = staticDataService;
            _loadingScreen = loadingScreen;
            _saveLoadHandlerService = saveLoadHandlerService;
        }

        #region MonoBehaviour

        private void Start()
        {
            Enter();
        }

        #endregion

        public void Enter()
        {
            SetupApplication();
            LoadData();
            LoadScene();
        }

        private void LoadScene()
        {
            _sceneLoader.LoadAsync(_staticDataService.Config.MainScene, _loadingScreen.Hide);
        }

        private void SetupApplication()
        {
            DisableScreenSleep();
        }

        private void DisableScreenSleep()
        {
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
        }

        private void LoadData()
        {
            _saveLoadHandlerService.Load();
        }
    }
}
