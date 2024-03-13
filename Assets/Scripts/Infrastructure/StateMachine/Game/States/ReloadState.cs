using Infrastructure.Services.Log.Core;
using Infrastructure.StateMachine.Game.States.Core;
using Infrastructure.StateMachine.Main.Core;
using Infrastructure.StateMachine.Main.States.Core;

namespace Infrastructure.StateMachine.Game.States
{
    public class ReloadState : IGameState, IState
    {
        private readonly IStateMachine<IGameState> _stateMachine;
        private readonly ILogService _logService;

        public ReloadState(IStateMachine<IGameState> stateMachine, ILogService logService)
        {
            _stateMachine = stateMachine;
            _logService = logService;
        }

        public void Enter()
        {
            _logService.Log("ReloadState");
            _stateMachine.Enter<SaveDataState>();
            _stateMachine.Enter<BootstrapState>();
        }
    }
}