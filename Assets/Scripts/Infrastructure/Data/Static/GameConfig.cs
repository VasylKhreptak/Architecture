using UnityEngine;

namespace Infrastructure.Data.Static
{
    [CreateAssetMenu(fileName = "GameConfig", menuName = "ScriptableObjects/Static/GameConfig", order = 0)]
    public class GameConfig : ScriptableObject
    {
        [Header("Scenes")]
        [SerializeField] private string _bootstrapScene = "Bootstrap";
        [SerializeField] private string _mainScene = "MainScene";

        public string BootstrapScene => _bootstrapScene;
        public string MainScene => _mainScene;
    }
}
