using System;
using System.Collections;
using UnityEngine;

namespace Assets.Hidden_Picture.Scripts.Gameplay
{
    public class TimerController : MonoBehaviour
    {
        public static int TimeLeft { get; set; } = 30;
        public event Action TimerChange;

        private int _delta = 0;

        private void Awake()
        {
            TimerSwitch(1);
        }

        public IEnumerator StartTimer()
        {
            while (TimeLeft > 0)
            {
                TimeLeft -= _delta;
                TimerChange?.Invoke();
                yield return new WaitForSeconds(1);
            }
        }

        public void TimerSwitch(int delta)
        {
            _delta = delta;
        }
    }
}
