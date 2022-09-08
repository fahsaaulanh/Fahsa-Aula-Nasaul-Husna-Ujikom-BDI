using Game.Global.Database;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace Game.Scene.Gameplay
{
    public class GameplayFlow : MonoBehaviour
    {
        public static UnityAction<bool> OnPlayerWin;
        [SerializeField] private SaveData _currentLevelData;
        [SerializeField] private PackDatabase _gameLevelData;
        private Currency _currency = new Currency();
        private string levelName;

        private void Start()
        {
            string packName = _currentLevelData.currentPack;
            int packIndex = _currentLevelData.currentLevelIndex;
            levelName = packName + packIndex;
        }

        private void OnEnable()
        {
            AnswerButton.OnButtonClick += CheckPlayerAnswer;
        }

        private void OnDisable()
        {
            AnswerButton.OnButtonClick -= CheckPlayerAnswer;
        }

        public void NextLevel()
        {
            for(int i = 0; i < _gameLevelData.packData.Count; i ++)
            {
                if (_gameLevelData.packData[i].packName == _currentLevelData.currentPack)
                {
                    _currentLevelData.currentLevelIndex++;
                    if (_currentLevelData.currentLevelIndex >= _gameLevelData.packData[i].levelData.Count)
                    {
                        SceneManager.LoadScene("Level");
                    }
                    else { 
                    _currentLevelData.currentLevel = _gameLevelData.packData[i].levelData[_currentLevelData.currentLevelIndex];
                    SceneManager.LoadScene("Gameplay");
                    }
                    break;
                }
            }
        }

        private void CheckPlayerAnswer(string answer)
        {
            string correctAnswer = _currentLevelData.currentLevel.levelData.correctAnswer;
            if(answer == correctAnswer)
            {
                _currentLevelData.ComplatedLevel.Add(levelName);
                _currency.AddCoin(50);
                OnPlayerWin?.Invoke(true);
            }
            else
            {
                OnPlayerWin?.Invoke(false);
            }
        }
    }
}