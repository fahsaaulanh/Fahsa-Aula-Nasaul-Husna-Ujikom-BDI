using System.Collections.Generic;
using UnityEngine;

namespace Game.Global.Database
{
    [System.Serializable]
    [CreateAssetMenu]
    public class LevelDatabase : ScriptableObject
    {
        [System.Serializable]
        public struct LevelData
        {
            public string question;
            public Sprite hint;
            public List<string> answers;
            public string correctAnswer;
        }

        public LevelData levelData;
    }
}
