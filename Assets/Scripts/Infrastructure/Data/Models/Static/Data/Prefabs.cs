using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Infrastructure.Data.Models.Static.Data
{
    [CreateAssetMenu(fileName = "GamePrefabs", menuName = "ScriptableObjects/Static/GamePrefabs", order = 0)]
    public class Prefabs : SerializedScriptableObject
    {
        [SerializeField] private Dictionary<Prefab, GameObject> _prefabs = new Dictionary<Prefab, GameObject>();

        public GameObject this[Prefab prefab] => _prefabs[prefab];
    }
}