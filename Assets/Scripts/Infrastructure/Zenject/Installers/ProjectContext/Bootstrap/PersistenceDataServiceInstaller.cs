using Infrastructure.Services.PersistenceData;
using Infrastructure.Services.PersistenceData.Core;
using Zenject;

namespace Infrastructure.Zenject.Installers.ProjectContext.Bootstrap
{
    public class PersistenceDataServiceInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IPersistenceDataService>().To<PersistenceDataService>().AsSingle();
        }
    }
}
