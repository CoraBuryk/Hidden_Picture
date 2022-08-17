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
            int seconds = Mathf.FloorToInt(TimerController.TimeLeft % 60);
            int minutes = Mathf.FloorToInt(TimerController.TimeLeft / 60);
            string sec = "";

            string min = (minutes < 10) ? "" + minutes.ToString() : minutes.ToString();

            if(seconds >= 10)
                sec = (seconds < 59) ? "" + seconds.ToString() : seconds.ToString();
            else if(seconds < 10)
                sec = (seconds < 59) ? "0" + seconds.ToString() : seconds.ToString();

            _timerText.text = string.Format($"{min} : {sec} ");
        }
    }
}
