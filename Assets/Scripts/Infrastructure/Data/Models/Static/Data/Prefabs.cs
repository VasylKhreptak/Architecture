﻿using Infrastructure.Serialization;
using UnityEngine;

namespace Infrastructure.Data.Models.Static.Data
{
    [CreateAssetMenu(fileName = "GamePrefabs", menuName = "ScriptableObjects/Static/GamePrefabs", order = 0)]
    public class Prefabs : ScriptableObject
    {
        [SerializeField] private SerializedDictionary<Prefab, GameObject> _prefabs = new SerializedDictionary<Prefab, GameObject>();

        public GameObject this[Prefab prefab] => _prefabs[prefab];
    }
}