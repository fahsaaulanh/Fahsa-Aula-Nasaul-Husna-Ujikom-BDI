using System.Collections.Generic;
using UnityEngine;

namespace Game.Global.Database
{
    [System.Serializable]
    [CreateAssetMenu]
    public class SaveData : ScriptableObject
    {
        public string currentPack;
        public LevelDatabase currentLevel;
        public int currentLevelIndex;

        public List<string> unlockPack;
        public List<string> ComplatedPack;
        public List<string> ComplatedLevel;
    }
}