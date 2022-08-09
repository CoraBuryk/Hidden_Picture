using UnityEngine;
using UnityEngine.UI;

namespace Assets.Hidden_Picture.Scripts.Gameplay
{
    public class GameplayController : MonoBehaviour
    {
        #region Serialized Variables
        [SerializeField] private GameObject _objectToFind;
        [SerializeField] private GameObject _particleSystem;
        [SerializeField] private Button _hintButton;
        [SerializeField] private HintsCounter _hintsCounter;
        [SerializeField] private TimerController _timerController;
        #endregion

        private void Start()
        {
            StartCoroutine(_timerController.StartTimer());
        }

        private void OnEnable()
        {
            _hintButton.onClick.AddListener(Hints);
        }
        private void OnDisable()
        {
            _hintButton.onClick.RemoveListener(Hints);
        }

        private void Hints()
        {
            ClickTrack.TotalClick = 0;
            if (_hintsCounter.Counter > 0 && _hintsCounter.Counter <= 3)
            {
                _objectToFind = GameObject.FindGameObjectWithTag("Character");
                Instantiate(_particleSystem, _objectToFind.transform.position, Quaternion.identity);
                _hintsCounter.ChangeNumberOfHints(_hintsCounter.Counter - 1);
            }
        }

        public void Restart()
        {
            _timerController.TimerSwitch(1);
            TimerController.TimeLeft = 30;
        }

        public void Continue()
        {
            _timerController.TimerSwitch(1);
        }

        public void Pause()
        {
            _timerController.TimerSwitch(0);
        }
    }
}
