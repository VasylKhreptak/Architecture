using Infrastructure.Services.SaveLoad;
using Infrastructure.Services.SaveLoad.Core;
using Zenject;

namespace Infrastructure.Zenject.Installers.ProjectContext
{
    public class SaveLoadServiceInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            ISaveLoadService saveLoadService = Container.Instantiate<SaveLoadService>();
            Container.BindInstance(saveLoadService).AsSingle();
        }
    }
}
