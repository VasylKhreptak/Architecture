using Infrastructure.Coroutines.Runner;
using Infrastructure.Coroutines.Runner.Core;
using UnityEngine;
using Zenject;

namespace Infrastructure.Zenject.Installers.ProjectContext.Bootstrap
{
    public class CoroutineRunnerInstaller : MonoInstaller
    {
        [Header("References")]
        [SerializeField] private GameObject _coroutineRunnerPrefab;

        public override void InstallBindings()
        {
            Container.Bind<ICoroutineRunner>().To<CoroutineRunner>().FromComponentInNewPrefab(_coroutineRunnerPrefab).AsSingle();
        }
    }
}
