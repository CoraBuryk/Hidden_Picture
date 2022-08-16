using UnityEngine;
using UnityEngine.UI;

namespace Assets.Hidden_Picture.Scripts.Gameplay
{
    public class ClickControl : MonoBehaviour
    {
        private Button _character;

        private void Awake()
        {
            _character = GetComponent<Button>();
        }

        private void OnEnable()
        {
            _character.onClick.AddListener(CharacterFounded);
        }

        private void OnDisable()
        {
            _character.onClick.RemoveListener(CharacterFounded);
        }

        private void CharacterFounded()
        {
            Destroy(gameObject);
            TimerController.TimeLeft += 15;
            CloneControl.End(CloneControl.NumberOfClone -= 1);
            ClickTrack.TotalClick = 0;
        }
    }
}
