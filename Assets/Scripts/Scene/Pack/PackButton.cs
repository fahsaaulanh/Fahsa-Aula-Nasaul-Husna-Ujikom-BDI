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
        private string _packName;
        Button _button;

        private void Start()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(delegate { OnButtonClick?.Invoke(_packName); });
        }

        public void SetPackInfo(string packName)
        {
            _packName = packName;
            _packNameText.text = _packName; 
        }
    }
}