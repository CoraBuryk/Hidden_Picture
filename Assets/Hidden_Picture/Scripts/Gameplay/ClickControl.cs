using UnityEngine;

namespace Assets.Hidden_Picture.Scripts.Gameplay
{
    public class ClickControl : MonoBehaviour
    {
        private void OnMouseDown()
        {
            Destroy(gameObject);
            TimerController.TimeLeft += 15;
            ClickTrack.TotalClick = 0;
        }
    }
}
