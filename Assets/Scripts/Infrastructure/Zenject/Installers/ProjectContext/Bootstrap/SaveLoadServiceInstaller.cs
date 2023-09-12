using Infrastructure.Services.SaveLoad;
using Infrastructure.Services.SaveLoad.Core;
using Zenject;

namespace Infrastructure.Zenject.Installers.ProjectContext.Bootstrap
{
    public class SaveLoadServiceInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<ISaveLoadService>().To<SaveLoadService>().AsSingle();
        }
    }
}
