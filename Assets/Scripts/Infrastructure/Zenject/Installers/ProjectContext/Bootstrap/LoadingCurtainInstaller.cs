using Infrastructure.Curtain;
using Infrastructure.Curtain.Core;
using UnityEngine;
using Zenject;

namespace Infrastructure.Zenject.Installers.ProjectContext.Bootstrap
{
    public class LoadingCurtainInstaller : MonoInstaller
    {
        [Header("References")]
        [SerializeField] private GameObject _loadingCurtainPrefab;

        public override void InstallBindings()
        {
            Container.Bind<ILoadingCurtain>().To<LoadingCurtain>().FromComponentInNewPrefab(_loadingCurtainPrefab).AsSingle();
        }
    }
}
