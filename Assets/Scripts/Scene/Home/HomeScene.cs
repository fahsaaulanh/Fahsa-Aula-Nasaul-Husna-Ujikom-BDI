using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Game.Scene.Home
{
    public class HomeScene : MonoBehaviour
    {
        [SerializeField] private Button _startButton;

        private void Start()
        {
            _startButton.onClick.AddListener(PackLauncher);
        }

        private void PackLauncher()
        {
            SceneManager.LoadScene("Pack");
        }
    }
}