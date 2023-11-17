﻿using System.Collections.Generic;
using Infrastructure.Data.Static.Core;
using Sirenix.Serialization;
using UnityEngine;

namespace Infrastructure.Data.Static
{
    [CreateAssetMenu(fileName = "GamePrefabs", menuName = "ScriptableObjects/Static/GamePrefabs", order = 0)]
    public class GamePrefabs : ScriptableObject
    {
       [SerializeField] private SerializedDictionary<Prefab, GameObject> _prefabs = new SerializedDictionary<Prefab, GameObject>();

        public GameObject this[Prefab prefab] => _prefabs[prefab];
    }
}