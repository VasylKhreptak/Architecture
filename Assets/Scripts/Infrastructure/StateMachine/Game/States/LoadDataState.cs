using Infrastructure.Data.Models.Persistent.Core;
using Infrastructure.Data.Models.Persistent.Data.Core;
using Infrastructure.Services.Log.Core;
using Infrastructure.Services.SaveLoad.Core;
using Infrastructure.StateMachine.Game.States.Core;
using Infrastructure.StateMachine.Main.Core;
using Infrastructure.StateMachine.Main.States.Core;

namespace Infrastructure.StateMachine.Game.States
{
    public class LoadDataState : IGameState, IState
    {
        private const string Key = "Data";

        private readonly IPersistentDataModel _persistentDataModel;
        private readonly IStateMachine<IGameState> _gameStateMachine;
        private readonly ILogService _logService;
        private readonly ISaveLoadService _saveLoadService;

        public LoadDataState(IPersistentDataModel persistentDataModel, IStateMachine<IGameState> gameStateMachine,
            ILogService logService, ISaveLoadService saveLoadService)
        {
            _persistentDataModel = persistentDataModel;
            _gameStateMachine = gameStateMachine;
            _logService = logService;
            _saveLoadService = saveLoadService;
        }

        public void Enter()
        {
            _logService.Log("LoadDataState");
            _persistentDataModel.Data = _saveLoadService.Load(Key, new PersistentData());
            _logService.Log("Loaded local data");
            _gameStateMachine.Enter<SetupApplicationState>();
        }
    }
}