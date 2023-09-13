using Infrastructure.Curtain.Core;
using Infrastructure.EntryPoints.Core;
using Infrastructure.SceneManagement.Core;
using Infrastructure.Services.Framerate.Core;
using Infrastructure.Services.StaticData.Core;
using UnityEngine;
using Zenject;

namespace Infrastructure.EntryPoints
{
    public class BootstrapEntryPoint : MonoBehaviour, IEntryPoint
    {
        private ISceneLoader _sceneLoader;
        private IStaticDataService _staticDataService;
        private ILoadingCurtain _loadingCurtain;
        private IFramerateService _framerateService;
        
        [Inject]
        private void Constructor(ISceneLoader sceneLoader,
            IStaticDataService staticDataService,
            ILoadingCurtain loadingCurtain,
            IFramerateService framerateService)
        {
            _sceneLoader = sceneLoader;
            _staticDataService = staticDataService;
            _loadingCurtain = loadingCurtain;
            _framerateService = framerateService;
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

            LoadScene();
        }

        private void LoadScene()
        {
            _sceneLoader.LoadAsync(_staticDataService.Config.MainScene, _loadingCurtain.Hide);
        }

        private void SetupApplication()
        {
            RemoveFPSConstraint();
            DisableScreenSleep();
        }

        private void RemoveFPSConstraint()
        {
            _framerateService.SetTargetFramerate((int)Screen.currentResolution.refreshRateRatio.value);
        }

        private void DisableScreenSleep()
        {
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
        }
    }
}
