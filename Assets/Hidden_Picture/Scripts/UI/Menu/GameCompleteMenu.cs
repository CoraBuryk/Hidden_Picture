using Assets.Hidden_Picture.Scripts.Gameplay;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Hidden_Picture.Scripts.UI.Menu
{
    public class GameCompleteMenu : MonoBehaviour
    {
        #region Serialized Variables
        [SerializeField] private Button _restartButton;
        [SerializeField] private Button _exitButton;
        [SerializeField] private GameObject _gamePanel;
        [SerializeField] private GameObject _gameCompletePanel;
        [SerializeField] private GameplayController _gameplayController;
        #endregion

        private bool _isOpened = false;

        private void OnEnable()
        {
            _restartButton.onClick.AddListener(RestartGame);
            _exitButton.onClick.AddListener(ExitGame);
        }

        private void OnDisable()
        {
            _restartButton.onClick.RemoveListener(RestartGame);
            _exitButton.onClick.RemoveListener(ExitGame);
        }

        private void RestartGame()
        {
            _gameCompletePanel.SetActive(_isOpened);
            _gamePanel.SetActive(!_isOpened);
            _gameplayController.Restart();
        }

        private void ExitGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }

        public void CompleteGame()
        {
            _gameplayController.Pause();
            _gameCompletePanel.SetActive(!_isOpened);
            _gamePanel.SetActive(_isOpened);
        }
    }
}
