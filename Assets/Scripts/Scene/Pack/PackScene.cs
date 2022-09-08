using Game.Global.Database;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Game.Scene.Pack
{
    public class PackScene : MonoBehaviour
    {
        [SerializeField] private Button _backButton;

        private void Start()
        {
            _backButton.onClick.AddListener(HomeLauncher);
        }

        private void HomeLauncher()
        {
            SceneManager.LoadScene("Home");
        }

        private void LevelLauncher()
        {
            SceneManager.LoadScene("Level");
        }
    }
}