using Cysharp.Threading.Tasks;

namespace Infrastructure.SceneManagement.Core
{
    public interface ISceneLoader
    {
        public void Load(string name);

        public UniTask LoadAsync(string name);

        public void LoadCurrentScene();

        public UniTask LoadCurrentSceneAsync();
    }
}