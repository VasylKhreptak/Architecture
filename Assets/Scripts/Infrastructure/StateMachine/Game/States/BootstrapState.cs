using Infrastructure.LoadingScreen.Core;
using Infrastructure.Services.Log.Core;
using Infrastructure.StateMachine.Game.States.Core;
using Infrastructure.StateMachine.Main.Core;
using Infrastructure.StateMachine.Main.States.Core;

namespace Infrastructure.StateMachine.Game.States
{
    public class BootstrapState : IState, IGameState
    {
        private readonly IStateMachine<IGameState> _stateMachine;
        private readonly ILoadingScreen _loadingScreen;
        private readonly ILogService _logService;

        public BootstrapState(IStateMachine<IGameState> stateMachine, ILoadingScreen loadingScreen, ILogService logService)
        {
            _stateMachine = stateMachine;
            _loadingScreen = loadingScreen;
            _logService = logService;
        }

        public void Enter()
        {
            _logService.Log("BootstrapState");

            _loadingScreen.Show();

            _stateMachine.Enter<LoadDataState>();
        }
    }
}