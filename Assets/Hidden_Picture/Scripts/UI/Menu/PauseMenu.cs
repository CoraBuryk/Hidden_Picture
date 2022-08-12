using Assets.Hidden_Picture.Scripts.Gameplay;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Hidden_Picture.Scripts.UI.Menu
{
    public class PauseMenu : MonoBehaviour
    {
        #region Serialized Variables
        [SerializeField] private Button _continueButton;
        [SerializeField] private Button _exitButton;
        [SerializeField] private Button _restartButton;
        [SerializeField] private GameObject _gamePanel;
        [SerializeField] private GameObject _pausePanel;
        [SerializeField] private GameObject _enviroment;
        [SerializeField] private SpawnControll _spawnControl;
        [SerializeField] private GameplayController _gameplayController;
        #endregion

        private bool _isOpened = false;

        private void OnEnable()
        {
            _continueButton.onClick.AddListener(ContinueGame);
            _exitButton.onClick.AddListener(ExitGame);
            _restartButton.onClick.AddListener(RestartGame);
        }

        private void OnDisable()
        {
            _continueButton.onClick.RemoveListener(ContinueGame);
            _exitButton.onClick.RemoveListener(ExitGame);
            _restartButton.onClick.RemoveListener(RestartGame);
        }

        public void PauseGame()
        {
            _spawnControl.FindObjects();
            _enviroment.SetActive(_isOpened);
            _spawnControl.Activate(_isOpened);
            _pausePanel.SetActive(!_isOpened);
            _gamePanel.SetActive(_isOpened);
            _gameplayController.Pause();
        }

        private void ContinueGame()
        {          
            _enviroment.SetActive(!_isOpened);
            _spawnControl.Activate(!_isOpened);
            _pausePanel.SetActive(_isOpened);
            _gamePanel.SetActive(!_isOpened);
            _gameplayController.Continue();
            _spawnControl.FindObjects();
        }

        private void RestartGame()
        {          
            _spawnControl.Activate(!_isOpened);
            _enviroment.SetActive(!_isOpened);
            _pausePanel.SetActive(_isOpened);
            _gamePanel.SetActive(!_isOpened);
            _spawnControl.FindObjects();
            _gameplayController.Restart();
        }

        private void ExitGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);       
        }
    }
}