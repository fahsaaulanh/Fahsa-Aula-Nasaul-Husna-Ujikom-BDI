using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Game.Scene.Home
{
    public class HomeScene : MonoBehaviour
    {
        [SerializeField] private Button _startButton;
        [SerializeField] private TMP_Text _coinText;

        private void Start()
        {
            _startButton.onClick.AddListener(PackLauncher);
            _coinText.text = "Coin : " + PlayerPrefs.GetInt("PlayerCoin").ToString();
        }

        private void PackLauncher()
        {
            SceneManager.LoadScene("Pack");
        }
    }
}