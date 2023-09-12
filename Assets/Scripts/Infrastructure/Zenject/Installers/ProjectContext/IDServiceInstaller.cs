using Infrastructure.Services.ID;
using Infrastructure.Services.ID.Core;
using Zenject;

namespace Infrastructure.Zenject.Installers.ProjectContext
{
    public class IDServiceInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IIDService>().To<IDService>().AsSingle();
        }
    }
}
