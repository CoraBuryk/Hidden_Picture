using System;
using UnityEngine;

namespace Assets.Hidden_Picture.Scripts.Gameplay
{
    public class ClickTrack : MonoBehaviour
    {              
        public event Action ClickTracking;
        public static int TotalClick = 0;

        public void Click(int number)
        {
            TotalClick = number;
            ClickTracking?.Invoke();
        }
    }
}