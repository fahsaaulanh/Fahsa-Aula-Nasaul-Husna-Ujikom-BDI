using Game.Global.Database;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Scene.Gameplay
{
    public class Quiz : MonoBehaviour
    {
        [SerializeField] private SaveData _currentLevelData;
        [SerializeField] private TMP_Text _questionText;
        [SerializeField] private Image _hint;
        [SerializeField] private AnswerButton _answerButton;
        [SerializeField] private GameObject _answerList;
        [SerializeField] private List<AnswerButton> _answerButtonsList;

        private void Start()
        {
            SetLevelGameplay();
        }

        private void SetLevelGameplay()
        {
            string question = _currentLevelData.currentLevel.levelData.question;
            Sprite hint = _currentLevelData.currentLevel.levelData.hint;
            List<string> choices = _currentLevelData.currentLevel.levelData.choice;

            _questionText.text = question;
            _hint.sprite = hint;

            for (int i = 0; i < _currentLevelData.currentLevel.levelData.choice.Count; i++)
            {
                var obj = Instantiate(_answerButton, parent: _answerList.transform);
                obj.SetAnswerButton(choices[i]);
            }
        }
    }

}