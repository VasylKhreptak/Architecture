using Infrastructure.Services.StaticData;
using Infrastructure.Services.StaticData.Core;
using Zenject;

namespace Infrastructure.Zenject.Installers.ProjectContext.Bootstrap
{
    public class StaticDataServiceInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IStaticDataService>().To<StaticDataService>().AsSingle();
        }
    }
}
