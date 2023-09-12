using Infrastructure.Services.StaticData;
using Infrastructure.Services.StaticData.Core;
using Zenject;

namespace Infrastructure.Zenject.Installers.ProjectContext
{
    public class StaticDataServiceInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            IStaticDataService staticDataService = Container.Instantiate<StaticDataService>();
            Container.BindInstance(staticDataService).AsSingle();
        }
    }
}
