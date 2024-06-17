using Cysharp.Threading.Tasks;
using Infrastructure.Coroutines.Runner.Core;
using Infrastructure.SceneManagement.Core;
using UnityEngine.SceneManagement;
using Zenject;

namespace Infrastructure.SceneManagement
{
    public class SceneLoader : ISceneLoader
    {
        private ICoroutineRunner _coroutineRunner;

        [Inject]
        private void Constructor(ICoroutineRunner coroutineRunner)
        {
            _coroutineRunner = coroutineRunner;
        }

        public void Load(string name) => SceneManager.LoadScene(name);

        public async UniTask LoadAsync(string name) => await LoadSceneAsync(name);

        public void LoadCurrentScene() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        public async UniTask LoadCurrentSceneAsync() => await LoadSceneAsync(SceneManager.GetActiveScene().name);

        private async UniTask LoadSceneAsync(string name) => await SceneManager.LoadSceneAsync(name).ToUniTask();
    }
}