using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Game.Scene.Gameplay
{
    public class GameplayScene : MonoBehaviour
    {
        [SerializeField] private Button _backBtn;
        [SerializeField] private GameObject _winPopup;
        [SerializeField] private GameObject _LosePopup;

        private void Start()
        {
            _backBtn.onClick.AddListener(LevelLauncher);
        }

        private void OnEnable()
        {
            GameplayFlow.OnPlayerWin += SetPlayerResult;
        }

        private void OnDisable()
        {
            GameplayFlow.OnPlayerWin -= SetPlayerResult;
        }

        private void SetPlayerResult(bool isPlayerWin)
        {
            if(isPlayerWin)
            {
                _winPopup.SetActive(true);
            }
            else
            {
                _LosePopup.SetActive(true);
            }
        }

        public void LevelLauncher()
        {
            SceneManager.LoadScene("Level");
        }

    }
}