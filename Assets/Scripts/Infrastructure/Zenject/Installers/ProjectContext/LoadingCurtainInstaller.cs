using Infrastructure.Curtain.Core;
using UnityEngine;
using Zenject;

namespace Infrastructure.Zenject.Installers.ProjectContext
{
    public class LoadingCurtainInstaller : MonoInstaller
    {
        [Header("References")]
        [SerializeField] private GameObject _loadingCurtainPrefab;

        public override void InstallBindings()
        {
            GameObject instance = Container.InstantiatePrefab(_loadingCurtainPrefab);
            ILoadingCurtain loadingCurtain = instance.GetComponent<ILoadingCurtain>();

            Container.BindInstance(loadingCurtain).AsSingle();
        }
    }
}
