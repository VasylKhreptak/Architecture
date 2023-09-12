using Infrastructure.Services.PersistenceData;
using Infrastructure.Services.PersistenceData.Core;
using Zenject;

namespace Infrastructure.Zenject.Installers.ProjectContext
{
    public class PersistenceDataServiceInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            IPersistenceDataService persistenceDataService = Container.Instantiate<PersistenceDataService>();
            Container.BindInstance(persistenceDataService).AsSingle();
        }
    }
}
