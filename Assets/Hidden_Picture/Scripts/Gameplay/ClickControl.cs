using UnityEngine;

namespace Assets.Hidden_Picture.Scripts.Gameplay
{
    public class ClickControl : MonoBehaviour
    {
        private void OnMouseDown()
        {
            Destroy(gameObject);
            TimerController.TimeLeft += 15;
            CloneControl.End(CloneControl.NumberOfClone -= 1);
            ClickTrack.TotalClick = 0;
        }
    }
}
