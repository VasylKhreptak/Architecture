﻿using Infrastructure.SceneManagement;
using Infrastructure.SceneManagement.Core;
using Zenject;

namespace Infrastructure.Zenject.Installers.ProjectContext
{
    public class SceneLoaderServiceInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<ISceneLoader>().To<SceneLoader>().AsSingle();
        }
    }
}
