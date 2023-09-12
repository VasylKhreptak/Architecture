using Infrastructure.EntryPoints.Core;
using Infrastructure.SceneManagement.Core;
using UnityEngine;
using Zenject;

namespace Infrastructure.EntryPoints
{
    public class BootstrapEntryPoint : MonoBehaviour, IEntryPoint
    {
        private ISceneLoader _sceneLoader;

        [Inject]
        private void Constructor(ISceneLoader sceneLoader)
        {
            _sceneLoader = sceneLoader;
        }

        #region MonoBehaviour

        private void Awake()
        {
            Enter();
        }

        #endregion

        public void Enter()
        {
            Debug.Log("BootstrapEntryPoint");


        }
    }
}
