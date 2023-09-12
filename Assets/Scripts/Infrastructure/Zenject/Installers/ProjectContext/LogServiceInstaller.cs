using Infrastructure.Services.Log;
using Infrastructure.Services.Log.Core;
using Zenject;

namespace Infrastructure.Zenject.Installers.ProjectContext
{
    public class LogServiceInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<ILogService>().To<LogService>().AsSingle();
        }
    }
}
