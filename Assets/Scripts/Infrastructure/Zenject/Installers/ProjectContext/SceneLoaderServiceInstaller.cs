using Infrastructure.SceneManagement;
using Infrastructure.SceneManagement.Core;
using Zenject;

namespace Infrastructure.Zenject.Installers.ProjectContext
{
    public class SceneLoaderServiceInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            ISceneLoader sceneLoaderInterface = Container.Instantiate<SceneLoader>();
            Container.BindInstance(sceneLoaderInterface).AsSingle();
        }
    }
}
