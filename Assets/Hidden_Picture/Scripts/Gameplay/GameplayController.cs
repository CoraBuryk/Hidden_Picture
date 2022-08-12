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
        [SerializeField] private SpawnControll _spawnControll;
        [SerializeField] private ClickTrack _clickTrack;
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
            if (_hintsCounter.Counter > 0 && _hintsCounter.Counter <= 3)
            {
                _objectToFind = GameObject.FindGameObjectWithTag("Character");
                Instantiate(_particleSystem, _objectToFind.transform.position, Quaternion.identity);
                _hintsCounter.ChangeNumberOfHints(_hintsCounter.Counter - 1);
                _clickTrack.Click(0);
            }
        }

        public void Restart()
        {
            _spawnControll.ToDestroy();
            TimerController.TimeLeft = 30;
            _timerController.TimerSwitch(1);
            _hintsCounter.ChangeNumberOfHints(_hintsCounter.Counter = 3);
            _spawnControll.ObjectSpawn();
            _clickTrack.Click(0);
        }

        public void Continue()
        {
            _timerController.TimerSwitch(1);
            _clickTrack.Click(0);
        }

        public void Pause()
        {
            _timerController.TimerSwitch(0);
            _clickTrack.Click(0);
        }
    }
}
