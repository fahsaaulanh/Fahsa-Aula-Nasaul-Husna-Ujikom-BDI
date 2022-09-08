using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.Scene.Level
{
    public class LevelButton : MonoBehaviour
    {
        public static UnityAction<int> OnLevelClick;
        [SerializeField] private TMP_Text _levelNameText;
        private string _levelName;
        private int _index;
        Button _button;
        private void Start()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(delegate { OnLevelClick?.Invoke(_index); });
        }

        public void SetLevelInfo(string levelName, int index)
        {
            _levelName = levelName;
            _index = index;
            _levelNameText.text = _levelName + " " + (index + 1);
        }
    }
}