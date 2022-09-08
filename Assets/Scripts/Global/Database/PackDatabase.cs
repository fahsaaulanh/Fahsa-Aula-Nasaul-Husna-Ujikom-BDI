using UnityEngine;
using System.Collections.Generic;

namespace Game.Global.Database
{
    [System.Serializable]
    [CreateAssetMenu]
    public class PackDatabase : ScriptableObject
    {
        [System.Serializable]
        public struct PackData
        {
            public string packName;
            public List<LevelDatabase> levelData;
        }
        public List<PackData> packData;
    }
}