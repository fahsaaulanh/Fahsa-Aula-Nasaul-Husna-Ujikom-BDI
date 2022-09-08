using Game.Global.Database;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.Scene.Pack
{
    public class PackButton : MonoBehaviour
    {
        public static UnityAction<string> OnButtonClick;

        [SerializeField] private TMP_Text _packNameText;
        [SerializeField] private SaveData _saveData;
        private string _packName;
        Button _button;

        private void Start()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(delegate { OnButtonClick?.Invoke(_packName); });
            IsUnlockButton();
        }

        private void IsUnlockButton()
        {
            for(int i = 0;i < _saveData.unlockPack.Count; i ++)
            {
                if(_packName == _saveData.unlockPack[i])
                {
                    _button.interactable = true;
                }
            }
        }

        public void SetPackInfo(string packName)
        {
            _packName = packName;
            _packNameText.text = _packName; 
        }
    }
}