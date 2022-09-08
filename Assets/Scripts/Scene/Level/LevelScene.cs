using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Game.Scene.Level
{
    public class LevelScene : MonoBehaviour
    {
        [SerializeField] private Button _backButton;

        private void Start()
        {
            _backButton.onClick.AddListener(PackLauncher);
        }

        private void OnEnable()
        {
            LevelButton.OnLevelClick += GameplayLauncher;
        }

        private void OnDisable()
        {
            LevelButton.OnLevelClick -= GameplayLauncher;
        }

        private void PackLauncher()
        {
            SceneManager.LoadScene("Pack");
        }

        private void GameplayLauncher(int index)
        {
            SceneManager.LoadScene("Gameplay");
        }
    }
}