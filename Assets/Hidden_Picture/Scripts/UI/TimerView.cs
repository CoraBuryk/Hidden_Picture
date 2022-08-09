using Assets.Hidden_Picture.Scripts.Gameplay;
using TMPro;
using UnityEngine;

namespace Assets.Hidden_Picture.Scripts.UI
{
    public class TimerView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _timerText;
        [SerializeField] private TimerController _timer;

        private void OnEnable()
        {
            _timer.TimerChange += UpdateTimeText;
        }

        private void OnDisable()
        {
            _timer.TimerChange -= UpdateTimeText;
        }

        private void UpdateTimeText()
        {
            float seconds = Mathf.FloorToInt(TimerController.TimeLeft % 60);
            _timerText.text = string.Format("{00:00}", seconds);
        }
    }
}
