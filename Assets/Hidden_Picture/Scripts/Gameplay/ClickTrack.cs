using System;
using UnityEngine;

namespace Assets.Hidden_Picture.Scripts.Gameplay
{
    public class ClickTrack : MonoBehaviour
    {              
        public event Action ClickTracking;
        public static int TotalClick = 0;

        public bool ignoreUI { get; set; }

        public void Click(bool UI)
        {
            ignoreUI = UI;
            if(UI == false)
            {
                TotalClick++;
                
            }
            else if (UI == true)
            {
                TotalClick = 0;
            }
            ClickTracking?.Invoke();
        }
    }
}