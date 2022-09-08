using Game.Global.Database;
using UnityEngine;

namespace Game.Scene.Pack
{
    public class PackList : MonoBehaviour
    {
        [SerializeField] private PackButton _packButtonPrefab;
        [SerializeField] private SaveData _saveData;
        [SerializeField] private PackDatabase _packData;

        private void Start()
        {
            SpawnPackButton();
        }

        private void OnEnable()
        {
            PackButton.OnButtonClick += SetCurrentPack;
        }

        private void OnDisable()
        {
            PackButton.OnButtonClick -= SetCurrentPack;
        }

        private void SetCurrentPack(string currentPack)
        {
            _saveData.currentPack = currentPack;
        }

        private void SpawnPackButton()
        {
            for (int i = 0; i < _packData.packData.Count; i++)
            {
               var obj = Instantiate(_packButtonPrefab, parent: gameObject.transform);
                obj.SetPackInfo(_packData.packData[i].packName);
            }
        }
    }
}