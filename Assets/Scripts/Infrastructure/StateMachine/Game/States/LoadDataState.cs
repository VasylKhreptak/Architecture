using Infrastructure.Services.PersistentData.Core;
using Infrastructure.StateMachine.Game.States.Core;
using Infrastructure.StateMachine.Main.Core;
using Infrastructure.StateMachine.Main.States.Core;

namespace Infrastructure.StateMachine.Game.States
{
    public class LoadDataState : IState, IGameState
    {
        private readonly IPersistentDataService _persistentDataService;
        private readonly IStateMachine<IGameState> _gameStateMachine;

        public LoadDataState(IPersistentDataService persistentDataService, IStateMachine<IGameState> gameStateMachine)
        {
            _persistentDataService = persistentDataService;
            _gameStateMachine = gameStateMachine;
        }

        public void Enter()
        {
            _persistentDataService.Load();
            _gameStateMachine.Enter<BootstrapAnalyticsState>();
        }
    }
}