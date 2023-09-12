using Infrastructure.Coroutines.Runner.Core;
using UnityEngine;
using Zenject;

namespace Infrastructure.Zenject.Installers.ProjectContext
{
    public class CoroutineRunnerInstaller : MonoInstaller
    {
        [Header("References")]
        [SerializeField] private GameObject _coroutineRunnerPrefab;

        public override void InstallBindings()
        {
            GameObject instance = Container.InstantiatePrefab(_coroutineRunnerPrefab);
            ICoroutineRunner coroutineRunner = instance.GetComponent<ICoroutineRunner>();

            Container.BindInstance(coroutineRunner).AsSingle();
        }
    }
}
