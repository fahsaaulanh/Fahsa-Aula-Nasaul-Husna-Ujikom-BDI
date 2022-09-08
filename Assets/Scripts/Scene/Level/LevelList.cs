using Game.Global.Database;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Scene.Level
{
    public class LevelList : MonoBehaviour
    {
        [SerializeField] private SaveData currentData;
        [SerializeField] private LevelButton levelButtonPrefab;
    }
}