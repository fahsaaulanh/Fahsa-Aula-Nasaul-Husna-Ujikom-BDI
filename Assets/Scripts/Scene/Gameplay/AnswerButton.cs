using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.Scene.Gameplay
{
    public class AnswerButton : MonoBehaviour
    {
        public static UnityAction<string> OnButtonClick;
        [SerializeField] private TMP_Text _answerText;
        private string _answer;
        Button _button;

        private void Start()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(delegate { OnButtonClick?.Invoke(_answer); });
        }

        public void SetAnswerButton(string choice)
        {
            _answer = choice;
            _answerText.text = _answer;
        }
    }
}