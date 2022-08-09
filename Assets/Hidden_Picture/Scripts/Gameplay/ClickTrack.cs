using UnityEngine;

namespace Assets.Hidden_Picture.Scripts.Gameplay
{
    public class ClickTrack : MonoBehaviour
    {
        public static int TotalClick = 0;
        public KeyCode MouseClick;

        void Update()
        {
            if (Input.GetKeyDown(MouseClick))
            {
                TotalClick += 1;
            }
        }
    }
}