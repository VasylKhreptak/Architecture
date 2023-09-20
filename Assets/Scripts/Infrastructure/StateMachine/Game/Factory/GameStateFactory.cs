using System;
using System.Collections.Generic;
using Infrastructure.StateMachine.Game.States;
using Infrastructure.StateMachine.Main.States.Core;
using Infrastructure.StateMachine.Main.States.Factory;
using Zenject;

namespace Infrastructure.StateMachine.Game.Factory
{
    public class GameStateFactory : StateFactory
    {
        public GameStateFactory(DiContainer container) : base(container)
        {
        }

        protected override Dictionary<Type, Func<IBaseState>> BuildStatesRegister(DiContainer container)
        {
            return new Dictionary<Type, Func<IBaseState>>()
            {
                [typeof(BootstrapState)] = container.Resolve<BootstrapState>,
                [typeof(SetupApplicationState)] = container.Resolve<SetupApplicationState>,
                [typeof(LoadDataState)] = container.Resolve<LoadDataState>,
                [typeof(BootstrapAnalyticsState)] = container.Resolve<BootstrapAnalyticsState>,
                [typeof(LoadLevelState)] = container.Resolve<LoadLevelState>,
                [typeof(GameLoopState)] = container.Resolve<GameLoopState>,
            };
        }
    }
}
