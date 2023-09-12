using Infrastructure.Services.Log;
using Infrastructure.Services.Log.Core;
using Zenject;

namespace Infrastructure.Zenject.Installers.ProjectContext
{
    public class LogServiceInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            ILogService logService = Container.Instantiate<LogService>();
            Container.BindInstance(logService).AsSingle();
        }
    }
}
