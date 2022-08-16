using Assets.Hidden_Picture.Scripts.Gameplay;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Hidden_Picture.Scripts.UI.Menu
{
    public class SceenBehavior : MonoBehaviour
    {
        #region Serialized Variables
        [SerializeField] private Button _pauseButton;
        [SerializeField] private PauseMenu _pauseMenu;
        [SerializeField] private SpawnControl spawnControll;
        [SerializeField] private TimerController _timerController;
        [SerializeField] private GameCompleteMenu _gameCompleteMenu;
        [SerializeField] private HintsCounter _hintsCounter;
        [SerializeField] private ClickTrack _clickTrack;
        #endregion

        private void OnEnable()
        {
            _pauseButton.onClick.AddListener(_pauseMenu.PauseGame);
            _timerController.TimerChange += TimeOver;
            CloneControl.Change += ZeroClone;
            _clickTrack.ClickTracking += NumberOfClick;
        }

        private void OnDisable()
        {
            _pauseButton.onClick.RemoveListener(_pauseMenu.PauseGame);
            _timerController.TimerChange -= TimeOver;
            CloneControl.Change -= ZeroClone;
            _clickTrack.ClickTracking -= NumberOfClick;
        }

        public void TimeOver()
        {
            if (TimerController.TimeLeft <= 0)
            {
                TimerController.TimeLeft = 30;
                _gameCompleteMenu.CompleteGame();
            }
        }

        public void ZeroClone()
        {
            if (CloneControl.NumberOfClone == 0)
            {
                CloneControl.NumberOfClone = 10;
               _gameCompleteMenu.CompleteGame();
            }
        }

        public void NumberOfClick()
        {
            if(ClickTrack.TotalClick > 6)
            {
                _gameCompleteMenu.CompleteGame();
            }
        }
    }
}
