using Infrastructure.Curtain.Core;
using Infrastructure.EntryPoints.Core;
using Infrastructure.SceneManagement.Core;
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

        [Inject]
        private void Constructor(ISceneLoader sceneLoader,
            IStaticDataService staticDataService,
            ILoadingCurtain loadingCurtain)
        {
            _sceneLoader = sceneLoader;
            _staticDataService = staticDataService;
            _loadingCurtain = loadingCurtain;
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
            _sceneLoader.LoadAsync(_staticDataService.Config.MainScene, () =>
            {
                _loadingCurtain.Hide();
            });
        }

        private void SetupApplication()
        {
            RemoveFPSConstraint();
            DisableScreenSleep();
        }

        private void RemoveFPSConstraint()
        {
            Application.targetFrameRate = (int)Screen.currentResolution.refreshRateRatio.value;
            QualitySettings.vSyncCount = 0;
        }

        private void DisableScreenSleep()
        {
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
        }
    }
}
