using Game.Global.Database;
using UnityEngine;

namespace Game.Scene.Level
{
    public class LevelList : MonoBehaviour
    {
        [SerializeField] private SaveData currentData;
        [SerializeField] private PackDatabase _packData;
        [SerializeField] private LevelButton levelButtonPrefab;

        private void Start()
        {
            SpawnLevelList();
        }

        private void OnEnable()
        {
            LevelButton.OnLevelClick += SetCurrentLevel;
        }

        private void OnDisable()
        {
            LevelButton.OnLevelClick -= SetCurrentLevel;
        }

        private void SetCurrentLevel(int index)
        {
            string currentPack = currentData.currentPack;
            for (int i = 0; i < _packData.packData.Count; i++)
            {
                if (currentPack == _packData.packData[i].packName)
                {
                    currentData.currentLevel = _packData.packData[i].levelData[index];
                    currentData.currentLevelIndex = index;
                    break;
                }
            }
        }

        private void SpawnLevelList()
        {
            string currentPack = currentData.currentPack;
            for(int i = 0; i < _packData.packData.Count; i++)
            {
                if(currentPack == _packData.packData[i].packName)
                {
                    for(int j = 0; j < _packData.packData[i].levelData.Count; j++)
                    {
                        var obj = Instantiate(levelButtonPrefab, parent: gameObject.transform);
                        obj.SetLevelInfo("Level", j); 
                    }
                    break;
                }
            }
        }
    }
}